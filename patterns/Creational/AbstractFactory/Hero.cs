using System;
using System.Collections.Generic;
using System.Text;

namespace patterns.Creational.AbstractFactory
{
    /// <summary>
    /// клиент - сам супергерой
    /// </summary>
    public class Hero
    {
        private Weapon weapon;
        private Movement movement;

        public Hero(HeroFactory factory)
        {
            weapon = factory.CreateWeapon();
            movement = factory.CreateMovement();
        }

        public void Run()
        {
            movement.Move();
        }

        public void Hit()
        {
            weapon.Hit();
        }
    }
}
