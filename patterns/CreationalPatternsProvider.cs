using System;
using System.Collections.Generic;
using System.Text;
using patterns.Creational.AbstractFactory;
using patterns.Creational.Builder;
using patterns.Creational.FactoryMethod;
using patterns.Creational.SimpleFactory;
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
            Console.WriteLine(Environment.NewLine);


            Console.WriteLine("-----------FactoryMethod-------------");
            var dev = new PanelDeveloper("some panel name");
            House house1 = dev.Create();


            var dev2 = new WoodDeveloper("wood dev name");
            var house2 = dev2.Create();

            Console.WriteLine(Environment.NewLine);

            Console.WriteLine("-----------Simple factory-------------");
            var fanFactory = new FanFactory();
            fanFactory.CreateFan(FanType.CeilingFan).SwitchOn();
            fanFactory.CreateFan(FanType.TableFan).SwitchOff();
            var exhaustFan = fanFactory.CreateFan(FanType.ExhaustFan);
            exhaustFan.SwitchOn();
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine(Environment.NewLine);

            Console.WriteLine("-----------Builder-------------");
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("-----------Simple Builder-------------");
            var fluentBuilder = new FluentMailMessageBuilder()
                .To("test@com.ua", "pasha")
                .Subject("simple test builder")
                .From("me@com.ua", "me")
                .Build();
            Console.WriteLine(fluentBuilder.Subject);

            MailMessage test = new FluentMailMessageBuilder().To("test@com.ua", "pasha").Subject("Неявное преобразование");
            Console.WriteLine(test.Subject);

            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("-----------Extensions methods Builder-------------");
            MailMessage mailMessage = new MailMessage().From("me@com.ua", "me").Subject("extension method builder");
            Console.WriteLine(mailMessage.Subject);

            Console.WriteLine(Environment.NewLine);
            Console.WriteLine(Environment.NewLine);



            Console.WriteLine(Environment.NewLine);
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine(Environment.NewLine);
            #endregion


        }
    }
}
