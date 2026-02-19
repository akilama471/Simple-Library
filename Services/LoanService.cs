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
        private LoanRepository _loanRepo = new LoanRepository();

        public string BorrowBook(Member member, Copy copy)
        {
            if (!copy.IsAvailable)
                return "Book not available";

            if (_loanRepo.GetActiveLoanCount(member.MemberId) >= 5)
                return "Maximum 5 borrowed books allowed";

            if (_loanRepo.HasOverdueLoans(member.MemberId))
                return "Member has overdue books";

            Loan loan = new Loan
            {
                MemberId = member.MemberId,
                CopyId = copy.CopyId,
                LoanDate = DateTime.Now,
                DueDate = DateTime.Now.AddDays(14)
            };

            _loanRepo.AddLoan(loan);

            return "Loan successful";
        }
    }
}
