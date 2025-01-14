using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session5_OOP.Sealed
{
    internal class Parent
    {
        public virtual int Salary { get; set; }
        public virtual void Print()
        {
            Console.WriteLine("I am Base");
        }
    }
}
