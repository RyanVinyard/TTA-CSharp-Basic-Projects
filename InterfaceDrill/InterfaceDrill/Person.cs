using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDrill
{
    public abstract class Person
    {
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public int Id { get; set; }


        public abstract void SayName();

        public static bool operator ==(Person person1, Person person2)
        {
            return (person1.Id == person2.Id);
        }

        public static bool operator !=(Person person1, Person person2)
        {
            return (person1.Id != person2.Id);
        }

    }
}