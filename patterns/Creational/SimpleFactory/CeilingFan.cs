using System;

namespace patterns.Creational.SimpleFactory
{
    public class CeilingFan : IFan
    {
        public void SwitchOn()
        {
            Console.WriteLine("Ceiling fan run");
        }

        public void SwitchOff()
        {
            Console.WriteLine("Ceiling fan stop");
        }
    }
}
