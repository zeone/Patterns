using System;
using patterns.Behavioral.Iterator;
using patterns.Behavioral.Mediator;
using patterns.Behavioral.Observer;
using patterns.Behavioral.Strategy;
using patterns.Behavioral.TemplateMethod;
using patterns.Behavioral.Visitor;

namespace patterns
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Begavioral
            //BehavioralPatternsProvider.Run();
            #endregion

            #region Creational

            CreationalPatternsProvider.Run();

            #endregion
            Console.WriteLine("Finish");
            Console.ReadLine();
        }
    }
}
