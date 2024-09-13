using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    public class CustomerWithRead : IDatabaseRead, IDiscount
    {
        public void Add()
        {
            // Implements  logic for add
        }
        public void Read()
        {
            // Implements  logic for read
        }

        public double GetDiscount(double totalSales)
        {
            return totalSales;
        }
    }
}
