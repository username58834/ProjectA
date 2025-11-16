using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectA
{
    public class Book : IInfo
    {
        public string Title;

        public List<Genres> Genre = new List<Genres>();
        public DateTime PublicationDate { get; set; }

        public double Rating { get; set; } = 0;

        public bool IsCheckOut;

        public Author Author;

        public DateTime CheckOutDate { get; set; }

        public Book(string title, Genres[] genres, Author author, string published)
        {
            throw new NotImplementedException();
        }
        public bool CheckIfWasEpired()
        {
            throw new NotImplementedException();
        }

        public string Info()
        {
            throw new NotImplementedException();
        }
    }
}
