using System;
using System.Collections.Generic;
using System.Text;

namespace patterns.Structural.Decorator
{
    public static class LogSaverFactory
    {
        public static ILogSaver CrateLogSaver()
        {
            return new ThrottlingLogSaverDecorator(
                new TraceServerDecorator(
                    new ElasticLogSaver()));
        }
    }
}
