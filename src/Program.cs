using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            double standardDiscount;
            Customer standarCustomer = new Customer(new FileLogger());
            // standarCustomer.Add();
            standardDiscount = standarCustomer.GetDiscount(1000);
            Console.WriteLine("[Standard] Sales: " + 1000 + " / Discount: " + (1000 - standardDiscount).ToString());

            double silverDiscount;
            Customer silverCustomer = new SilverCustomer(new EmailLogger());
            silverDiscount = silverCustomer.GetDiscount(1000);
            Console.WriteLine("[Silver] Sales: " + 1000 + " / Discount: " + (1000 - silverDiscount).ToString());

            double goldDiscount;
            Customer goldCustomer = new GoldCustomer(new EventViewerLogger());
            goldDiscount = goldCustomer.GetDiscount(1000);
            Console.WriteLine("[Gold] Sales: " + 1000 + " / Discount: " + (1000 - goldDiscount).ToString());

            double enquiryDiscount;
            Enquiry enquiry = new Enquiry();
            // enquiry.Add()
            enquiryDiscount = enquiry.GetDiscount(1000);
            Console.WriteLine("[Enquiry] Sales: " + 1000 + " / Discount: " + (1000 - enquiryDiscount).ToString());

            double newDiscount;
            CustomerWithRead newCustomer = new CustomerWithRead();
            //newCustomer.Read()
            newDiscount = newCustomer.GetDiscount(1000);
            Console.WriteLine("[New Customer] Sales: " + 1000 + " / Discount: " + (1000 - newDiscount).ToString());

            Console.ReadLine();
        }
    }
}



/*

















    public abstract class BakeryComponent
    {
        public abstract string GetName();
        public abstract double GetPrice();
    }

    class CakeBase : BakeryComponent
    {
        // In real world these values will typically come from some data store
        private string m_Name = "Cake Base";
        private double m_Price = 200.0;

        public override string GetName()
        {
            return m_Name;
        }

        public override double GetPrice()
        {
            return m_Price;
        }
    }

    class PastryBase : BakeryComponent
    {
        // In real world these values will typically come from some data store
        private string m_Name = "Pastry Base";
        private double m_Price = 20.0;

        public override string GetName()
        {
            return m_Name;
        }

        public override double GetPrice()
        {
            return m_Price;
        }
    }

    public abstract class Decorator : BakeryComponent
    {
        BakeryComponent m_BaseComponent = null;

        protected string m_Name = "Undefined Decorator";
        protected double m_Price = 0.0;

        protected Decorator(BakeryComponent baseComponent)
        {
            m_BaseComponent = baseComponent;
        }

        #region BakeryComponent Members

        string BakeryComponent.GetName()
        {
            return string.Format("{0}, {1}", m_BaseComponent.GetName(), m_Name);
        }

        double BakeryComponent.GetPrice()
        {
            return m_Price + m_BaseComponent.GetPrice();
        }
        #endregion
    }

    class ArtificialScentDecorator : Decorator
    {
        public ArtificialScentDecorator(BakeryComponent baseComponent)
            : base(baseComponent)
        {
            this.m_Name = "Artificial Scent";
            this.m_Price = 3.0;
        }
    }

    class CherryDecorator : Decorator
    {
        public CherryDecorator(BakeryComponent baseComponent)
            : base(baseComponent)
        {
            this.m_Name = "Cherry";
            this.m_Price = 2.0;
        }
    }

    class CreamDecorator : Decorator
    {
        public CreamDecorator(BakeryComponent baseComponent)
            : base(baseComponent)
        {
            this.m_Name = "Cream";
            this.m_Price = 1.0;
        }
    }

    class NameCardDecorator : Decorator
    {
        private int m_DiscountRate = 5;

        public NameCardDecorator(BakeryComponent baseComponent)
            : base(baseComponent)
        {
            this.m_Name = "Name Card";
            this.m_Price = 4.0;
        }

        public override string GetName()
        {
            return base.GetName() +
                string.Format("\n(Please Collect your discount card for {0}%)",
                m_DiscountRate);
        }
    }

}
*/