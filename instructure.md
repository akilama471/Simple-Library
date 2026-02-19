Below is your **complete project explanation guide in Markdown format**.
It is structured clearly so an AI agent (or developer) can understand **exactly what to build, how to structure it, and what rules to enforce**.

You can copy this directly into a `.md` file.

---

```md
# Sarasavi Library Management System
## Software Development Project – C# Windows Forms + SQL Server LocalDB

---

# 1. Project Overview

Build a Desktop Application using:

- Language: C#
- Framework: .NET Framework (Windows Forms)
- Database: SQL Server LocalDB
- Architecture: Layered (UI → Services → Repository → Database)
- Programming Paradigm: Object-Oriented Programming (OOP)

The system manages a library with:

- Book Titles
- Physical Copies
- Registered Members
- Loans
- Reservations

---

# 2. Functional Requirements

## 2.1 Loan Process

Rules:

1. A Member can borrow maximum 5 books at a time.
2. A Member cannot borrow if they have overdue books.
3. Reference-only copies cannot be borrowed.
4. Loan period = 14 days.
5. Copy must be available to borrow.

---

## 2.2 Return Process

1. Mark Loan as returned.
2. Set Copy as available.
3. If the Book has reservations:
   - Notify oldest reservation member.
   - Remove oldest reservation.

---

## 2.3 Reservation Process

1. A Member can reserve a Book title.
2. Reservations are handled FIFO (first come first serve).
3. When a copy becomes available:
   - Oldest reservation is fulfilled.

---

## 2.4 Inquiry Process

User can search by:

- Book Title (partial match)
- Author
- Copy Number

System must show:

- Available copies count
- Loaned copies count
- Reservation status
- Reference-only status

---

## 2.5 Book Registration

Rules:

- Maximum 10 copies per book.
- Store:
  - Classification (1 byte)
  - 4-digit number starting from 0001 per classification
  - Title
  - Author
  - Publisher
  - Reference status

---

## 2.6 Member Registration

Capture:

- MemberId
- Name
- NIC
- Address
- Sex

---

# 3. Database Design (SQL Server)

## Tables

### Members

| Column | Type |
|--------|------|
| MemberId | INT (PK, Identity) |
| Name | NVARCHAR(100) |
| NIC | NVARCHAR(20) |
| Address | NVARCHAR(200) |
| Sex | NVARCHAR(10) |

---

### Books

| Column | Type |
|--------|------|
| BookId | INT (PK, Identity) |
| Title | NVARCHAR(200) |
| Author | NVARCHAR(100) |
| Publisher | NVARCHAR(100) |
| Classification | NVARCHAR(10) |
| IsReferenceOnly | BIT |

---

### Copies

| Column | Type |
|--------|------|
| CopyId | INT (PK, Identity) |
| BookId | INT (FK → Books.BookId) |
| CopyNumber | NVARCHAR(20) |
| IsAvailable | BIT |

---

### Loans

| Column | Type |
|--------|------|
| LoanId | INT (PK, Identity) |
| CopyId | INT (FK → Copies.CopyId) |
| MemberId | INT (FK → Members.MemberId) |
| LoanDate | DATETIME |
| DueDate | DATETIME |
| IsReturned | BIT |

---

### Reservations

| Column | Type |
|--------|------|
| ReservationId | INT (PK, Identity) |
| BookId | INT (FK → Books.BookId) |
| MemberId | INT (FK → Members.MemberId) |
| ReservationDate | DATETIME |

---

# 4. Project Folder Structure

```

SarasaviLibrary
│
├── Models
│     ├── Book.cs
│     ├── Copy.cs
│     ├── Member.cs
│     ├── Loan.cs
│     └── Reservation.cs
│
├── Repositories
│     ├── MemberRepository.cs
│     ├── BookRepository.cs
│     ├── LoanRepository.cs
│     └── ReservationRepository.cs
│
├── Services
│     ├── LoanService.cs
│     ├── ReservationService.cs
│     └── InquiryService.cs
│
├── Data
│     └── DatabaseHelper.cs
│
└── Forms
├── MainForm.cs
├── MemberForm.cs
├── BookForm.cs
├── LoanForm.cs
├── ReturnForm.cs
└── InquiryForm.cs

```

---

# 5. Architecture Rules

## Layered Architecture

UI Layer:
- Handles forms and user input
- Calls Service Layer

Service Layer:
- Contains business rules
- Validates logic
- Calls Repository Layer

Repository Layer:
- Executes SQL queries
- Communicates with database

Data Layer:
- Manages connection string
- SQL helper methods

---

# 6. OOP Design Rules

## Encapsulation
All properties must be inside classes.

## Inheritance
If needed, create base `User` class.

## Single Responsibility Principle
Each class must handle only one responsibility.

## Separation of Concerns
UI must not contain SQL code.
Business rules must not be inside Forms.

---

# 7. Core Business Logic Rules

## Borrow Book Logic

Pseudo-code:

```

IF copy is not available
RETURN "Book not available"

IF member borrowed books >= 5
RETURN "Maximum limit reached"

IF member has overdue loans
RETURN "Overdue books exist"

CREATE loan
SET due date = today + 14 days
SET copy IsAvailable = false
SAVE loan

RETURN "Loan successful"

```

---

## Return Book Logic

```

MARK loan IsReturned = true
SET copy IsAvailable = true

CHECK reservations for that book
IF exists
SELECT oldest reservation
NOTIFY member
DELETE reservation

```

---

# 8. Non-Functional Requirements

- Must use OOP
- Must use SQL Server LocalDB
- No SQL inside Forms
- Use parameterized queries (prevent SQL injection)
- Use try-catch for error handling

---

# 9. Technologies Used

- C#
- Windows Forms
- ADO.NET
- SQL Server LocalDB

---

# 10. Final Expected Features

✔ Register Member  
✔ Register Book  
✔ Add Copies  
✔ Borrow Book  
✔ Return Book  
✔ Make Reservation  
✔ Search Books  
✔ Enforce 5 book limit  
✔ Enforce 14-day loan period  

---

# 11. Success Criteria

System is considered complete when:

- All functional requirements are implemented
- Database is properly connected
- Business rules enforced
- Clean layered architecture
- Proper error handling
- UI functional without crashes

---

# End of Project Specification
```