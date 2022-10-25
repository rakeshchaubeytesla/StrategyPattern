using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Implementation
{
    public class CardPayment : IPayment
    {
        public void Payment()
        {
            Console.WriteLine("CardPayment");
        }
    }
}
