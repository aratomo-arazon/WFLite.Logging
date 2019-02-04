/*
 * LoggingInVariable.cs
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
    public abstract class LoggingInVariable : InVariable
    {
        private readonly ILogger _logger;

        public LoggingInVariable(ILogger logger)
        {
            _logger = logger;
        }
        　
        protected sealed override void setValue(object value)
        {
            setValue(_logger, value);
        }

        protected abstract void setValue(ILogger logger, object value);
    }

    public abstract class LoggingInVariable<TInValue> : InVariable<TInValue>
    {
        private readonly ILogger _logger;

        public LoggingInVariable(ILogger logger)
        {
            _logger = logger;
        }

        protected sealed override void setValue(object value)
        {
            setValue(_logger, value);
        }

        protected abstract void setValue(ILogger logger, object value);
    }
}
