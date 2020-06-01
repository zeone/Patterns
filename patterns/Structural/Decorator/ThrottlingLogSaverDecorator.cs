using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace patterns.Structural.Decorator
{
    public class ThrottlingLogSaverDecorator : LogSaverDecorator
    {
        /// <summary>
        /// Concrete decorator
        /// <remarks>
        /// Реализация декоратора
        /// добавляет к декорируему обьетку специфическое поведение 
        /// </remarks>
        /// </summary>
        /// <param name="logSaver"></param>
        public ThrottlingLogSaverDecorator(ILogSaver logSaver) : base(logSaver)
        {
        }

        public override async Task SaveLogEntry(string appId, LogEntry logEntry)
        {
            if (!QuotaReached(appId))
            {
                IncrementUsedQuota();

                await _decoratee.SaveLogEntry(appId, logEntry);
                return;
            }
            //лимит превышен
            throw new QuotaReachedException();
        }

        private void IncrementUsedQuota()
        {
            //уваличиваем квоту
        }

        private bool QuotaReached(string appId)
        {
            //проверяем избежала ли квота
            return false;
        }
    }
}
