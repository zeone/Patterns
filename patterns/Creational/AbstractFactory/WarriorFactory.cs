using System;
using System.Collections.Generic;
using System.Text;

namespace patterns.Creational.AbstractFactory
{
    /// <summary>
    /// Фабрика создания бегущего героя с мечом
    /// </summary>
    public class WarriorFactory : HeroFactory
    {
        public override Movement CreateMovement()
        {
            return new RunMovement();
        }

        public override Weapon CreateWeapon()
        {
            return new Sword();
        }
    }
}
