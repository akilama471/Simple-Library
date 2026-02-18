using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SarasaviLibrary.Models
{
    public class Book
    {
        public string BookNumber { get; set; }
        public string Title { get; set; }
        public Author Author { get; set; }
        public string VersionYear { get; set; }
        public string VersionNumber { get; set; }
        public bool IsReferenceOnly { get; set; }
        public List<Copy> Copies { get; set; } = new List<Copy>();
    }
}
