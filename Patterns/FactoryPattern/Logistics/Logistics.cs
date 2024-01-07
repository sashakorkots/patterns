
using System.Xml.Serialization;

namespace Patterns.FactoryPattern;
public abstract class Logistics
{
    ITransport transport;
    public void PlanDelivery() 
    { 
        transport = createTransport();
    }

    public void Deliver()
    {
        transport.Deliver();
    }

    public abstract ITransport createTransport();
}