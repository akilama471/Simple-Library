using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SarasaviLibrary.Models
{
    public class Reservation
    {
        public int ReservationId { get; set; }
        
        public int BookId { get; set; }
        public Book Book { get; set; }
        
        public int MemberId { get; set; }
        public Member Member { get; set; }
        
        public DateTime ReservationDate { get; set; }
    }
}
