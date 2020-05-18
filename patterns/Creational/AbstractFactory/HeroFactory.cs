using System;
using System.Collections.Generic;
using System.Text;

namespace patterns.Creational.AbstractFactory
{
    /// <summary>
    /// Абстрактный класс фабрики
    ///
    /// Суть абстрактной фабрики состоит в том, то если у нас есть нейкий обобщенный функционал, но возможна разная реализация(поведение)
    /// Например:
    /// для работы с бд мы можем реализовать абстрактную фабрику, при этом не нужно привязываться к конкретному типу бд
    /// создаеться абстрактный класс фабрики
    /// от него создаються конкретные реализации
    /// в клиент принивает тип абстрактной фабрики и в зависимости от реализации будет иметь поведение
    /// клиентом пользуемся в работе
    /// </summary>
    public abstract class HeroFactory
    {
        public abstract Movement CreateMovement();
        public abstract Weapon CreateWeapon();
    }
}
