using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    public class GoldCustomer: Customer
    {
        public GoldCustomer(ILogger logger)
        {
            this.logger = logger;
        }
        public override double GetDiscount(double totalSales)
        {
            return base.GetDiscount(totalSales) - 100;
        }
    }
}
