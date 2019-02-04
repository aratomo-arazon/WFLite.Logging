/*
 * LogginConverter.cs
 *
 * Copyright (c) 2019 aratomo-arazon
 *
 * This software is released under the MIT License.
 * http://opensource.org/licenses/mit-license.php
 */

using Microsoft.Extensions.Logging;

namespace WFLite.Logging.Bases
{
    public abstract class LoggingConverter : WFLite.Bases.Converter
    {
        private readonly ILogger _logger;

        public LoggingConverter(ILogger logger)
        {
            _logger = logger;
        }

        protected sealed override object convert(object value)
        {
            return convert(_logger, value);
        }

        protected abstract object convert(ILogger logger, object value);
    }

    public abstract class LoggingConverter<TValue> : WFLite.Bases.Converter<TValue>
    {
        private readonly ILogger _logger;

        public LoggingConverter(ILogger logger)
        {
            _logger = logger;
        }

        protected sealed override TValue convert(object value)
        {
            return convert(_logger, value);
        }

        protected abstract TValue convert(ILogger logger, object value);
    }

    public abstract class LoggingConverter<TInValue, TOutValue> : WFLite.Bases.Converter<TInValue, TOutValue>
    {
        private readonly ILogger _logger;

        public LoggingConverter(ILogger logger)
        {
            _logger = logger;
        }

        protected sealed override TOutValue convert(TInValue value)
        {
            return convert(_logger, value);
        }

        protected abstract TOutValue convert(ILogger logger, TInValue value);
    }
}
