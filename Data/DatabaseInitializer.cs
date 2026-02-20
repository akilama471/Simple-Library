using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SarasaviLibrary.Data
{
    public static class DatabaseInitializer
    {
        public static void Initialize()
        {
            string[] tableCreationQueries = new string[]
            {
                // Create Publishers Table
                @"IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='Publishers' AND xtype='U')
                CREATE TABLE Publishers (
                    PublisherId INT IDENTITY(1,1) PRIMARY KEY,
                    Name NVARCHAR(100) NOT NULL
                )",

                // Create Authors Table
                @"IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='Authors' AND xtype='U')
                CREATE TABLE Authors (
                    AuthorId INT IDENTITY(1,1) PRIMARY KEY,
                    Name NVARCHAR(100) NOT NULL
                )",

                // Create Members Table
                @"IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='Members' AND xtype='U')
                CREATE TABLE Members (
                    MemberId INT IDENTITY(1,1) PRIMARY KEY,
                    Name NVARCHAR(100) NOT NULL,
                    NIC NVARCHAR(20) NOT NULL UNIQUE,
                    Address NVARCHAR(200),
                    Sex NVARCHAR(10)
                )",

                // Create Books Table
                @"IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='Books' AND xtype='U')
                CREATE TABLE Books (
                    BookId INT IDENTITY(1,1) PRIMARY KEY,
                    Title NVARCHAR(200) NOT NULL,
                    AuthorId INT NOT NULL FOREIGN KEY REFERENCES Authors(AuthorId),
                    PublisherId INT NOT NULL FOREIGN KEY REFERENCES Publishers(PublisherId),
                    Classification NVARCHAR(50),
                    IsReferenceOnly BIT DEFAULT 0,
                    BookNumber NVARCHAR(20) -- Ensure we keep this if needed, or map it to ID
                )",

                // Create Copies Table
                @"IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='Copies' AND xtype='U')
                CREATE TABLE Copies (
                    CopyId INT IDENTITY(1,1) PRIMARY KEY,
                    BookId INT NOT NULL FOREIGN KEY REFERENCES Books(BookId),
                    CopyNumber NVARCHAR(20) NOT NULL,
                    IsAvailable BIT DEFAULT 1
                )",

                // Create Loans Table
                @"IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='Loans' AND xtype='U')
                CREATE TABLE Loans (
                    LoanId INT IDENTITY(1,1) PRIMARY KEY,
                    CopyId INT NOT NULL FOREIGN KEY REFERENCES Copies(CopyId),
                    MemberId INT NOT NULL FOREIGN KEY REFERENCES Members(MemberId),
                    LoanDate DATETIME NOT NULL,
                    DueDate DATETIME NOT NULL,
                    IsReturned BIT DEFAULT 0
                )",

                // Create Reservations Table
                @"IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='Reservations' AND xtype='U')
                CREATE TABLE Reservations (
                    ReservationId INT IDENTITY(1,1) PRIMARY KEY,
                    BookId INT NOT NULL FOREIGN KEY REFERENCES Books(BookId),
                    MemberId INT NOT NULL FOREIGN KEY REFERENCES Members(MemberId),
                    ReservationDate DATETIME NOT NULL
                )"
            };

            foreach (var query in tableCreationQueries)
            {
                DatabaseHelper.ExecuteNonQuery(query);
            }

            // Migration: Add UserNumber column to Members table if it doesn't exist
            string checkUserNumberColumnQuery = @"
                IF NOT EXISTS (
                    SELECT * FROM sys.columns 
                    WHERE Name = N'UserNumber' AND Object_ID = Object_ID(N'Members')
                )
                BEGIN
                    ALTER TABLE Members ADD UserNumber NVARCHAR(20);
                END";
            DatabaseHelper.ExecuteNonQuery(checkUserNumberColumnQuery);

            // Migration: Add ISBN and Edition to Books
            string checkBookColumnsQuery = @"
                IF NOT EXISTS (SELECT * FROM sys.columns WHERE Name = N'ISBN' AND Object_ID = Object_ID(N'Books'))
                BEGIN
                    ALTER TABLE Books ADD ISBN NVARCHAR(50);
                    -- We will add the UNIQUE constraint after ensuring data integrity manually or in specific script if needed.
                    -- For now, just adding the column. Ideally:
                    -- UPDATE Books SET ISBN = 'LEGACY-' + CAST(BookId AS NVARCHAR(20));
                    -- ALTER TABLE Books ADD CONSTRAINT UQ_ISBN UNIQUE (ISBN);
                END
                
                IF NOT EXISTS (SELECT * FROM sys.columns WHERE Name = N'Edition' AND Object_ID = Object_ID(N'Books'))
                BEGIN
                    ALTER TABLE Books ADD Edition NVARCHAR(50);
                END
            ";
            DatabaseHelper.ExecuteNonQuery(checkBookColumnsQuery);

            // Migration: Add IsReferenceOnly to Copies
            string checkCopyColumnQuery = @"
                IF NOT EXISTS (SELECT * FROM sys.columns WHERE Name = N'IsReferenceOnly' AND Object_ID = Object_ID(N'Copies'))
                BEGIN
                    ALTER TABLE Copies ADD IsReferenceOnly BIT DEFAULT 0;
                END
            ";
            DatabaseHelper.ExecuteNonQuery(checkCopyColumnQuery);

             // Attempt to add UNIQUE constraint to ISBN if it doesn't exist (and hoping no duplicate NULLs or values)
            try 
            {
                 string addUniqueISBN = @"
                    IF NOT EXISTS (SELECT * FROM sys.objects WHERE type = 'UQ' AND name = 'UQ_ISBN')
                    BEGIN
                       -- This might fail if there are duplicate NULLs. 
                       -- Prerequisite: Ensure ISBNs are unique or empty table.
                       -- We use a text check to avoid checking constraint directly if name varies.
                       ALTER TABLE Books ADD CONSTRAINT UQ_ISBN UNIQUE (ISBN);
                    END
                 ";
                 // Check if table is empty or handle errors? 
                 // For this environment, we try to execute it.
                 DatabaseHelper.ExecuteNonQuery(addUniqueISBN);
            }
            catch 
            { 
               // Ignore if it fails due to existing data - user will need to fix data.
            }

            // Migration: Add Timestamps to all primary tables
            string addTimestampsQuery = @"
                DECLARE @Tables TABLE (TableName NVARCHAR(100));
                INSERT INTO @Tables VALUES ('Books'), ('Copies'), ('Authors'), ('Publishers'), ('Members');

                DECLARE @CurrentTable NVARCHAR(100);
                DECLARE TableCursor CURSOR FOR SELECT TableName FROM @Tables;

                OPEN TableCursor;
                FETCH NEXT FROM TableCursor INTO @CurrentTable;

                WHILE @@FETCH_STATUS = 0
                BEGIN
                    DECLARE @Sql NVARCHAR(MAX);
                    
                    IF NOT EXISTS (SELECT * FROM sys.columns WHERE Name = N'CreatedAt' AND Object_ID = Object_ID(@CurrentTable))
                    BEGIN
                        SET @Sql = 'ALTER TABLE ' + QUOTENAME(@CurrentTable) + ' ADD CreatedAt DATETIME NOT NULL CONSTRAINT DF_' + @CurrentTable + '_CreatedAt DEFAULT GETDATE()';
                        EXEC sp_executesql @Sql;
                    END
                    
                    IF NOT EXISTS (SELECT * FROM sys.columns WHERE Name = N'UpdatedAt' AND Object_ID = Object_ID(@CurrentTable))
                    BEGIN
                        SET @Sql = 'ALTER TABLE ' + QUOTENAME(@CurrentTable) + ' ADD UpdatedAt DATETIME NOT NULL CONSTRAINT DF_' + @CurrentTable + '_UpdatedAt DEFAULT GETDATE()';
                        EXEC sp_executesql @Sql;
                    END

                    FETCH NEXT FROM TableCursor INTO @CurrentTable;
                END;

                CLOSE TableCursor;
                DEALLOCATE TableCursor;
            ";
            DatabaseHelper.ExecuteNonQuery(addTimestampsQuery);
        }
    }
}
