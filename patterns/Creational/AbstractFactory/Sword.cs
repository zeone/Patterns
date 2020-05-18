using System;
using System.Collections.Generic;
using System.Text;

namespace patterns.Creational.AbstractFactory
{
    public class Sword : Weapon
    {
        public override void Hit()
        {
            Console.WriteLine("Бьем мечом");
        }
    }
}
