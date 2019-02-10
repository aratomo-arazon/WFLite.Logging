/*
 * LogginConverter.cs
 *
 * Copyright (c) 2019 aratomo-arazon
 *
 * This software is released under the MIT License.
 * http://opensource.org/licenses/mit-license.php
 */

using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;

namespace WFLite.Logging.Bases
{
    public abstract class LoggingConverter : WFLite.Bases.Converter
    {
        public ILogger Logger
        {
            protected get;
            set;
        } = NullLogger.Instance;

        public LoggingConverter()
        {
        }

        public LoggingConverter(ILogger logger)
        {
            Logger = logger;
        }
    }

    public abstract class LoggingConverter<TValue> : WFLite.Bases.Converter<TValue>
    {
        public ILogger Logger
        {
            protected get;
            set;
        } = NullLogger.Instance;

        public LoggingConverter()
        {
        }

        public LoggingConverter(ILogger logger)
        {
            Logger = logger;
        }
    }

    public abstract class LoggingConverter<TInValue, TOutValue> : WFLite.Bases.Converter<TInValue, TOutValue>
    {
        public ILogger Logger
        {
            protected get;
            set;
        } = NullLogger.Instance;

        public LoggingConverter()
        {
        }

        public LoggingConverter(ILogger logger)
        {
            Logger = logger;
        }
    }
}
