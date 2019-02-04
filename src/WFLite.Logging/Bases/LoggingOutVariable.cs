/*
 * LoggingOutVariable.cs
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
    public abstract class LoggingOutVariable : OutVariable
    {
        private readonly ILogger _logger;

        public LoggingOutVariable(ILogger logger)
        {
            _logger = logger;
        }
        　
        protected sealed override object getValue()
        {
            return getValue(_logger);
        }

        protected abstract object getValue(ILogger logger);
    }

    public abstract class LoggingOutVariable<TOutValue> : OutVariable<TOutValue>
    {
        private readonly ILogger _logger;

        public LoggingOutVariable(ILogger logger)
        {
            _logger = logger;
        }

        protected sealed override object getValue()
        {
            return getValue(_logger);
        }

        protected abstract object getValue(ILogger logger);
    }
}
