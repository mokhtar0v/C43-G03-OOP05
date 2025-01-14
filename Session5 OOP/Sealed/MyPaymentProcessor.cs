using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session5_OOP.Sealed
{
    internal class MyPaymentProcessor : PaymentProcessor
    {
        public void ProcessPayment(decimal Amount)
        {
            Console.WriteLine($"Amount: {Amount + 20}");
        }
    }
}
