using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectA
{
    public class Person
    {
        static int counter  = 0;
        
        public int ID;
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime? DateOfBirth { get; set; }

        public Person(string name, string surname, string? dateOfBirth)
        {
            throw new NotImplementedException();
        }
    }
}
