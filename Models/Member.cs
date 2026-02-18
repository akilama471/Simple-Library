using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SarasaviLibrary.Models
{
    public class Member : User
    {
        public List<Loan> BorrowedBooks { get; set; } = new List<Loan>();
    }
}
