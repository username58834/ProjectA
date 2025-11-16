using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectA
{
    public class Worker : Person
    {
        public string? Position { get; set; }

        double salary;
        public double Salary
        {
            get { return salary; }
            set
            {
                if (value >= 0) salary = value;
                else { throw new NotImplementedException(); }
            }
        }

        public Worker(string name, string surname, string? dateOfBirth = null, double salary = 0) : base(name, surname, dateOfBirth)
        {
            throw new NotImplementedException();
        }
        public bool CheckOutBook(Book book)
        {
            throw new NotImplementedException();
        }

        public bool CheckInBook(Book book)
        {
            throw new NotImplementedException();
        }

        public bool AddBook(Book book)
        {
            throw new NotImplementedException();
        }

        public bool RemoveBook(Book book)
        {
            throw new NotImplementedException();
        }

        public bool AddAuthor(Author author)
        {
            throw new NotImplementedException();
        }

        public bool RemoveAurhor(Author author)
        {
            throw new NotImplementedException();
        }
    }
}
