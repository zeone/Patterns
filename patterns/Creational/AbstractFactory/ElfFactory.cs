using System;
using System.Collections.Generic;
using System.Text;

namespace patterns.Creational.AbstractFactory
{
    /// <summary>
    /// Фабрика создания летящего героя с арбалетом
    /// </summary>
    public class ElfFactory : HeroFactory
    {
        public override Movement CreateMovement()
        {
            return new FlyMovement();
        }

        public override Weapon CreateWeapon()
        {
            return new CrossBow();
        }
    }
}
