using Microsoft.VisualStudio.CodeCoverage;
using Patterns.FactoryPattern;
using System.Diagnostics;

namespace TestPatterns.FactoryPattern
{
    public class DeliveryTests
    {
        private Delivery delivery;

        public DeliveryTests()
        {
            this.delivery = new Delivery();
        }
        [Fact]
        public void DeliveryByTruck()
        {
            delivery.ByTruck();
        }

        [Fact]
        public void DeliveryByShip()
        {
            delivery.ByShip();
        }

        [Fact]
        public void DeliveryByPlane()
        {
            delivery.ByPlane();
        }
    }
}