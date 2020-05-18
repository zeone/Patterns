using System;
using System.Collections.Generic;
using System.Text;

namespace patterns.Creational.AbstractFactory
{
    public class CrossBow : Weapon
    {
        public override void Hit()
        {
            Console.WriteLine("Стреляем из арбалета");
        }
    }
}
