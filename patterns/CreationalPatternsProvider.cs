using System;
using System.Collections.Generic;
using System.Text;
using patterns.Creational.AbstractFactory;
using patterns.Creational.FactoryMethod;
using patterns.Creational.Singleton;

namespace patterns
{

    public static class CreationalPatternsProvider
    {
        public static void Run()
        {
            #region Singleton
            Console.WriteLine("-----------Singleton pattern (lazy)-------------");
            var lazySimple = LazySingleton.Instance;
            lazySimple.DoAction();
            Console.WriteLine(Environment.NewLine);

            Console.WriteLine("-----------Singleton pattern (double check)-------------");
            var doubleCheckSingltone = DoubleCheckedLockSingleton.Instance;
            doubleCheckSingltone.DoSomething();
            Console.WriteLine(Environment.NewLine);

            Console.WriteLine("-----------Singleton pattern (static field)-------------");
            var staticField = StaticFieldSingleton.Instance;
            staticField.DoAction();
            Console.WriteLine(Environment.NewLine);


            Console.WriteLine("-----------Abstract Factory -------------");
            //создаем клиента фабрики
            // передаеться конкретная реализация фабрики
            var warior = new Hero(new WarriorFactory());
            warior.Hit();
            warior.Run();

            var elf = new Hero(new ElfFactory());
            elf.Hit();
            elf.Run();

            Console.WriteLine(Environment.NewLine);

            Console.WriteLine("-----------FactoryMethod-------------");
            var dev = new PanelDeveloper("some panel name");
            House house1 = dev.Create();


            var dev2 = new WoodDeveloper("wood dev name");
            var house2 = dev2.Create();

            Console.WriteLine(Environment.NewLine);


            Console.WriteLine(Environment.NewLine);
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine(Environment.NewLine);
            #endregion


        }
    }
}
