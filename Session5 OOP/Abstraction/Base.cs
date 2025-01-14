using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session5_OOP.Abstraction
{
    abstract class Base : Shape
    {
        public override decimal CalcArea()
        {
            return Dim01 * Dim02;
        }
    }
}
