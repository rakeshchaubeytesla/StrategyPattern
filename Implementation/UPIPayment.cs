using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Implementation
{
    public class UPIPayment : IPayment
    {
        public void Payment()
        {
            Console.WriteLine("UPIPayment");


        }
    }
}
