using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session5_OOP.Sealed
{
    internal class GrandChild : Child
    {
        public new int Salary
        {
            get { return base.Salary; }
            set { base.Salary = value < 6000 ? 6000 : value; }
        }
        public new void Print()
        {
            Console.WriteLine("I am Very Sad");
        }
    }
}
