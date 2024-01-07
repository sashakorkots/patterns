using Microsoft.VisualStudio.CodeCoverage;
using Patterns.FactoryPattern;
using System.Diagnostics;

namespace TestPatterns.FactoryPattern
{
    public class DeliveryTests
    {
        [Fact]
        public void DeliveryByTruck()
        {
            Delivery delivery = new Delivery(new RoadLogistics());
            delivery.Execute();
        }

        [Fact]
        public void DeliveryByShip()
        {
            Delivery delivery = new Delivery(new SeaLogistics());
            delivery.Execute();
        }

        [Fact]
        public void DeliveryByPlane()
        {
            Delivery delivery = new Delivery(new AirLogistics());
            delivery.Execute();
        }
    }
}