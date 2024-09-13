using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    public class Customer : IDatabase, IDiscount
    {
        protected ILogger logger;

        public Customer()
        {

        }
        public Customer(ILogger logger)
        {
            this.logger = logger;
        }
        public virtual void Add()
        {
            try
            {
                // Database code goes here
            }
            catch (Exception ex)
            {
                logger.Handle(ex.ToString());
            }
        }

        public virtual double GetDiscount(double totalSales)
        {
            return totalSales;
        }

    }
}
