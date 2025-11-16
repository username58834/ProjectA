using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectA
{
    public class Library
    {
        public string Name;

        public List<Book> Books = new List<Book>();

        public List<Author> Authors = new List<Author>();

        public List<Member> Members = new List<Member>();

        public List<Worker> Workers = new List<Worker>();

        public Library(string name)
        {
            throw new NotImplementedException();
        }
        public bool HireWorker(Worker worker)
        {
            throw new NotImplementedException();
        }

        public bool FireWorker(Worker worker)
        {
            throw new NotImplementedException();
        }

        public bool AddMemeber(Member member)
        {
            throw new NotImplementedException();
        }

        public bool RemoveMemeber(Member member)
        {
            throw new NotImplementedException();
        }
    }
}
