using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectA
{
    public class Member : Person
    {
        public DateTime MemebershipDate { get; set; }

        public Member(string name, string surname, string? dateOfBirth = null) : base(name, surname, dateOfBirth)
        {
            throw new NotImplementedException();
        }
        public bool BorrowBook()
        {
            throw new NotImplementedException();
        }

        public bool ReturnBook()
        {
            throw new NotImplementedException();
        }

        public bool LeaveReview()
        {
            throw new NotImplementedException();
        }
    }
}
