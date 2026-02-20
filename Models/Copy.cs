using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SarasaviLibrary.Models
{
    public class Copy
    {
        public int CopyId { get; set; }
        
        public int BookId { get; set; }
        public Book Book { get; set; }
        
        public string CopyNumber { get; set; }
        public bool IsAvailable { get; set; }
        public bool IsReferenceOnly { get; set; }
    }
}
