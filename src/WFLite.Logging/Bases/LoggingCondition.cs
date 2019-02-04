/*
 * LoggingCondition.cs
 *
 * Copyright (c) 2019 aratomo-arazon
 *
 * This software is released under the MIT License.
 * http://opensource.org/licenses/mit-license.php
 */

using Microsoft.Extensions.Logging;
using WFLite.Bases;

namespace WFLite.Logging.Bases
{
    public abstract class LoggingCondition : Condition
    {
        private readonly ILogger _logger;

        public LoggingCondition(ILogger logger)
        {
            _logger = logger;
        }

        protected sealed override bool check()
        {
            return check(_logger);
        }

        protected abstract bool check(ILogger logger);
    }
}
