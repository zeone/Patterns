using System;
using System.Collections.Generic;
using System.Text;

namespace patterns.Creational.AbstractFactory
{
    public class FlyMovement : Movement
    {
        public override void Move()
        {
            Console.WriteLine("Летим");
        }
    }
}
