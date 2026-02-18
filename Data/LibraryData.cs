using SarasaviLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SarasaviLibrary.Models;
using System.Threading.Tasks;

namespace SarasaviLibrary.Data
{
    public static class LibraryData
    {
        public static List<Book> Books = new List<Book>();
        public static List<Member> Members = new List<Member>();
        public static List<Loan> Loans = new List<Loan>();
    }
}
