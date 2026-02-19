using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SarasaviLibrary.Models
{
    public class Member : User
    {
        public int MemberId { get; set; }
        
        // Navigation property for loans
        public List<Loan> Loans { get; set; } = new List<Loan>();
    }
}
