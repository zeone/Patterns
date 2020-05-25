namespace patterns.Creational.SimpleFactory
{
    public interface IFanFactory
    {
        IFan CreateFan(FanType type);
    }
}
