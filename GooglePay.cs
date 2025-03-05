using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Design_pattern
{
    public class GooglePay : IPayment
    {
        public void pay(double amount)
        {
            Console.WriteLine($"Successfully paid {amount} using GooglePay");
        }
    }
}
   