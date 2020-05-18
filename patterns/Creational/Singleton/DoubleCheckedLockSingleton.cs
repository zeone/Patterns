using System;
using System.Collections.Generic;
using System.Text;

namespace patterns.Creational.Singleton
{
    public sealed class DoubleCheckedLockSingleton
    {
        //должно быть volatile
        //запрещает компилятору оптимизацию
        //без него возможна ситуация что второй поток получит инстанс который не был до конца создан
        private static volatile DoubleCheckedLockSingleton _instance;
        private static readonly object _syncRoot = new object();

        DoubleCheckedLockSingleton() { }

        public static DoubleCheckedLockSingleton Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_syncRoot)
                    {
                        if (_instance == null)
                        {
                            _instance = new DoubleCheckedLockSingleton();
                        }
                    }
                }

                return _instance;
            }
        }

        public void DoSomething()
        {
            Console.WriteLine("DoubleCheckedLockSingleton");
        }
    }
}
