using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;
using WFLite.Bases;

namespace WFLite.Logging.Bases
{
    public abstract class LoggingCondition<TCategoryName> : Condition
    {
        private readonly ILogger<TCategoryName> _logger;

        public LoggingCondition(ILogger<TCategoryName> logger)
        {
            _logger = logger;
        }

        protected sealed override bool check()
        {
            return check(_logger);
        }

        protected abstract bool check(ILogger<TCategoryName> logger);
    }
}
