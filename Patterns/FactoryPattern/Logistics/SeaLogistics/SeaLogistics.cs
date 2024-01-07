namespace Patterns.FactoryPattern;

public class SeaLogistics : Logistics
{
    public override ITransport createTransport()
    {
        return new Ship();
    }
}