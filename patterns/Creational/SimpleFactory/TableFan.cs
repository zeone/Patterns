using System;

namespace patterns.Creational.SimpleFactory
{
   public class TableFan:IFan
    {
        public void SwitchOn()
        {
            Console.WriteLine("Table fan run");
        }

        public void SwitchOff()
        {
            Console.WriteLine("Table fan stop");
        }
    }
}
