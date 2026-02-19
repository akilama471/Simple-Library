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
        }
    }
}
