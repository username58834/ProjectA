using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectA
{
    public class Author : Person
    {
        public string? Country;

        public string? Biography;

        public Author(string name, string surname, string? dateOfBirth = null, string? county = null, string? biography = null) : base(name, surname, dateOfBirth)
        {
            throw new NotImplementedException();
        }
    }
}
