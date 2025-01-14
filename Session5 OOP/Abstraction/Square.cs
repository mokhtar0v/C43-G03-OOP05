using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session5_OOP.Abstraction
{
    class Square : Base
    {
        public Square(int Dim)
        {
            this.Dim01 = this.Dim02 = Dim;
        }
        public override decimal Parameter
        {
            get { return Dim01 * 4; }
        }
    }
}
