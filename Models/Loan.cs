using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SarasaviLibrary.Models
{
    public class Loan
    {
        public int LoanId { get; set; }
        
        public int CopyId { get; set; }
        public Copy Copy { get; set; }
        
        public int MemberId { get; set; }
        public Member Member { get; set; }
        
        public DateTime LoanDate { get; set; }
        public DateTime DueDate { get; set; }
        public bool IsReturned { get; set; }
    }
}
