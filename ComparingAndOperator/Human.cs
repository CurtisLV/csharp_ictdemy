using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparingAndOperator
{
    internal abstract class Human : IComparable 
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string BirthDate { get; set; }

        public int CompareTo()
        {
        }

        

    }
}
