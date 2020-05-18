using System;
using System.Collections.Generic;
using System.Text;

namespace patterns.Creational.Singleton
{
    public sealed class StaticFieldSingleton
    {
        private static readonly StaticFieldSingleton _instance = new StaticFieldSingleton();
        StaticFieldSingleton() { }
        //статический конструктор, приказывает компилятору не помечать тип атрибутом beforefieldinit
        static StaticFieldSingleton() { }

        public static StaticFieldSingleton Instance
        {
            get { return _instance; }
        }

        public void DoAction()
        {
            Console.WriteLine(this.GetType());
        }
    }
}
