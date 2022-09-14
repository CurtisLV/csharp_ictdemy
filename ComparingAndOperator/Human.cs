using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparingAndOperator
{
    internal abstract class Human : IComparable 
    {

        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }

        private static Random random = new Random();
        public Human(string name, string lastName, DateTime birthDate)
        {
            Name = name;
            LastName = lastName;
            BirthDate = birthDate;
        }

        public int CompareTo(object obj)
        {
            // TODO: This also has to sort alphabetically, firstly
            Human other = obj as Human;

            if 

            if (DateTime.Compare(this.BirthDate, other.BirthDate) < 0)
            {
                return -1;
            }
            if (DateTime.Compare(this.BirthDate, other.BirthDate) > 0)
            {
                return 1;
            }
            return 0;
        }

        // overload + operator

        // override ToString()
    }
}
