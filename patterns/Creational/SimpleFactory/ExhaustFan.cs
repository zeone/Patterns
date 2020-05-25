using System;

namespace patterns.Creational.SimpleFactory
{
    class ExhaustFan : IFan
    {
        public void SwitchOn()
        {
            Console.WriteLine("Exhaust fan run");
        }

        public void SwitchOff()
        {
            Console.WriteLine("Exhaust fan stop");
        }
    }
}
