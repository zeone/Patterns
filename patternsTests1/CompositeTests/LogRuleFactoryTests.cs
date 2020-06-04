using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using patterns;
using patterns.Structural.Composite;
using patterns.Structural.Composite.Specification;

namespace patternsTests1.CompositeTests
{
 public   class LogRuleFactoryTests
    {
        [Test]
        public void CompositeTests()
        {
            var rule = LogRuleFactory.RejectOldEntriesWithLowSeverity(TimeSpan.FromDays(7));

            LogEntry logEntry = new ExceptionLogEntry();
            Assert.IsTrue(rule.ShouldImport(logEntry));
        }
    }
}
