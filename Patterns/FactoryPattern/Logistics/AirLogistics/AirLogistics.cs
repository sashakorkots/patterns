namespace Patterns.FactoryPattern;

public class AirLogistics : Logistics
{
    public override ITransport createTransport()
    {
        return new Plane();
    }
}