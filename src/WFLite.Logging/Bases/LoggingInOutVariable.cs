/*
 * LoggingInOutVariable.cs
 *
 * Copyright (c) 2019 aratomo-arazon
 *
 * This software is released under the MIT License.
 * http://opensource.org/licenses/mit-license.php
 */

using Microsoft.Extensions.Logging;
using WFLite.Bases;
using WFLite.Interfaces;

namespace WFLite.Logging.Bases
{
    public abstract class LoggingInOutVariable : InOutVariable
    {
        private readonly ILogger _logger;

        public LoggingInOutVariable(ILogger logger)
        {
            _logger = logger;
        }

        public LoggingInOutVariable(ILogger logger, IConverter converter = null)
            : base(converter)
        {
            _logger = logger;
        }

        protected sealed override object getValue()
        {
            return getValue(_logger);
        }
        　
        protected sealed override void setValue(object value)
        {
            setValue(_logger, value);
        }

        protected abstract object getValue(ILogger logger);

        protected abstract void setValue(ILogger logger, object value);
    }

    public abstract class LoggingInOutVariable<TValue> : InOutVariable<TValue>
    {
        private readonly ILogger _logger;

        public LoggingInOutVariable(ILogger logger)
        {
            _logger = logger;
        }

        public LoggingInOutVariable(ILogger logger, IConverter<TValue> converter = null)
            : base(converter)
        {
            _logger = logger;
        }

        protected sealed override object getValue()
        {
            return getValue(_logger);
        }

        protected sealed override void setValue(object value)
        {
            setValue(_logger, value);
        }

        protected abstract object getValue(ILogger logger);

        protected abstract void setValue(ILogger logger, object value);
    }

    public abstract class LoggingInOutVariable<TInValue, TOutValue> : InOutVariable<TInValue, TOutValue>
    {
        private readonly ILogger _logger;

        public LoggingInOutVariable(ILogger logger)
        {
            _logger = logger;
        }

        public LoggingInOutVariable(ILogger logger, IConverter<TOutValue> converter = null)
            : base(converter)
        {
            _logger = logger;
        }

        public LoggingInOutVariable(ILogger logger, IConverter<TInValue, TOutValue> converter = null)
            : base(converter)
        {
            _logger = logger;
        }

        protected sealed override object getValue()
        {
            return getValue(_logger);
        }

        protected sealed override void setValue(object value)
        {
            setValue(_logger, value);
        }

        protected abstract object getValue(ILogger logger);

        protected abstract void setValue(ILogger logger, object value);
    }
}
