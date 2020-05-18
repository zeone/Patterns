using System;
using System.Collections.Generic;
using System.Text;

namespace patterns.Creational.AbstractFactory
{
   public class RunMovement:Movement
    {
        public override void Move()
        {
            Console.WriteLine("Бежим");
        }
    }
}
