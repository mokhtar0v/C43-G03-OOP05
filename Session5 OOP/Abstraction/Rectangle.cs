using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session5_OOP.Abstraction
{
    class Rectangle : Base
    {
        public override decimal Parameter
        {
            get { return (Dim01 + Dim02) * 2; }
        }
    }
}
