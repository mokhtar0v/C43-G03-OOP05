using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session5_OOP.Static___Constant
{
    internal static class Utility
    {
        //Static Constructor [max only one per class]
        //and you can't specify access modifier or parameters and will be called once per class Lifetime before the first usage of the class
        // Usage of static class:
        /// 1. Create object from this class or from another class
        /// 2. call static property <summary>
        /// 3. call static method
        private const double pi = 3.14;
        public static double PI
        {
            get { return pi; }
        }
        static Utility() { }
        //Object member method: Static Method
        public static double CmToInch(double Cm)
        {
            return Cm / 2.54;
        }
        //Object member method: Static Method
        public static double CalcCircleArea(double Rad)
        {
            return Utility.PI * Rad * Rad;
        }
    }
}
