using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.FactoryPattern
{
    public class Delivery
    {
        private Logistics logistic;

        public Delivery(Logistics logistic) 
        {
            this.logistic = logistic;
        }

        public void Execute()
        {                
            logistic.PlanDelivery();
            logistic.Deliver();
            return;
        }
    }
}
