using SarasaviLibrary.Data;
using SarasaviLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SarasaviLibrary.Services
{
    public class LoanService
    {
        public string BorrowBook(Member member, Copy copy)
        {
            if (!copy.IsAvailable)
                return "Book not available";

            if (member.BorrowedBooks.Count >= 5)
                return "Maximum 5 books allowed";

            Loan loan = new Loan
            {
                Borrower = member,
                BorrowedCopy = copy,
                LoanDate = DateTime.Now,
                DueDate = DateTime.Now.AddDays(14)
            };

            member.BorrowedBooks.Add(loan);
            LibraryData.Loans.Add(loan);

            copy.IsAvailable = false;

            return "Loan successful";
        }
    }
}
