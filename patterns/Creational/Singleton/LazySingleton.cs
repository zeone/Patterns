using System;
using System.Collections.Generic;
using System.Text;

namespace patterns.Creational.Singleton
{
    /// <summary>
    /// простая реализация сингтона с ленивостью и потокобезопасностью
    /// </summary>
    public sealed class LazySingleton
    {
        // инстанс будет создан только при обращении к немуб ф посколько он статичен, то будет создан один раз
        private static readonly Lazy<LazySingleton> _instance = new Lazy<LazySingleton>(() => new LazySingleton());
        //закрытый конструктор что бы небыло возмозности создать обьект класса
        LazySingleton() { }


        public static LazySingleton Instance
        {
            get { return _instance.Value; }
        }

        public void DoAction()
        {
            Console.WriteLine("lazy simple singleton");
        }
    }
}
