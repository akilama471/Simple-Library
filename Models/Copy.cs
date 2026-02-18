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
        public string CopyNumber { get; set; }
        public bool IsAvailable { get; set; } = true;
    }
}
