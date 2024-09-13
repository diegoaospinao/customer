using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    public class Enquiry : IDiscount
    {
        public double GetDiscount(double totalSales)
        {
            return totalSales - 5;
        }
    }
}
