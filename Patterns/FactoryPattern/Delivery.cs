using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.FactoryPattern
{
    public class Delivery
    {
        private Ship ship;
        private Truck truck;
        private Plane plane;

        public Delivery() 
        {
            this.ship = new Ship();
            this.truck = new Truck();
            this.plane = new Plane();
        }

        public void ByTruck()
        {                
            ship.PlanDelivery();
            ship.Deliver();
            return;
        }

        public void ByShip()
        {
            truck.PlanDelivery();
            truck.Deliver();
            return;
        }

        public void ByPlane()
    {                plane.PlanDelivery();
            plane.Deliver();
            return;
        }
    }
}
