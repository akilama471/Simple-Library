using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SarasaviLibrary.Models
{
    public class Book
    {
        public int BookId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        
        // This can be used for display or legacy purposes, but ID is primary
        public string BookNumber { get; set; } 

        public string ISBN { get; set; }
        public string Edition { get; set; } 
        
        public string Title { get; set; }
        
        public int AuthorId { get; set; }
        public Author Author { get; set; }
        
        public int PublisherId { get; set; }
        public Publisher Publisher { get; set; }
        
        public string Classification { get; set; }
        
        public bool IsReferenceOnly { get; set; }

        // Display property for grid
        public int CopyCount { get; set; }

        // Copies associated with this book
        public List<Copy> Copies { get; set; } = new List<Copy>();
    }
}
