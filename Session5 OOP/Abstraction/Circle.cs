using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session5_OOP.Abstraction
{
    class Circle : Base
    {
        public Circle(decimal rad)
        {
            this.Dim01 = this.Dim02 = rad;
        }
        public override decimal Parameter
        {
            get { return 2 * 3.14M * Dim01; }
        }
        public override decimal CalcArea()
        {
            return 3.14M * Dim01 * Dim02;
        }
    }
}
