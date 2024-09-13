using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    public class SilverCustomer : Customer
    {
        public SilverCustomer(ILogger logger)
        {
            base.logger = logger;
        }

        public override double GetDiscount(double totalSales)
        {
            return base.GetDiscount(totalSales) - 50;
        }
    }
}
