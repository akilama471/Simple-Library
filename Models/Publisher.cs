using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SarasaviLibrary.Models
{
    public class Publisher
    {
        public int PublisherId { get; set; }
        public string Name { get; set; }
        public int BookCount { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
