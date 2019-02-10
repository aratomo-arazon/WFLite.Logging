/*
 * LoggingInOutVariable.cs
 *
 * Copyright (c) 2019 aratomo-arazon
 *
 * This software is released under the MIT License.
 * http://opensource.org/licenses/mit-license.php
 */

using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;
using WFLite.Bases;
using WFLite.Interfaces;

namespace WFLite.Logging.Bases
{
    public abstract class LoggingInOutVariable : InOutVariable
    {
        public ILogger Logger
        {
            protected get;
            set;
        } = NullLogger.Instance;

        public LoggingInOutVariable()
        {
        }

        public LoggingInOutVariable(ILogger logger)
        {
            Logger = logger;
        }

        public LoggingInOutVariable(IConverter converter = null)
            : base(converter)
        {
        }

        public LoggingInOutVariable(ILogger logger, IConverter converter = null)
            : base(converter)
        {
            Logger = logger;
        }
    }

    public abstract class LoggingInOutVariable<TValue> : InOutVariable<TValue>
    {
        public ILogger Logger
        {
            protected get;
            set;
        } = NullLogger.Instance;

        public LoggingInOutVariable()
        {
        }

        public LoggingInOutVariable(ILogger logger)
        {
            Logger = logger;
        }

        public LoggingInOutVariable(IConverter<TValue> converter = null)
            : base(converter)
        {
        }

        public LoggingInOutVariable(ILogger logger, IConverter<TValue> converter = null)
            : base(converter)
        {
            Logger = logger;
        }
    }

    public abstract class LoggingInOutVariable<TInValue, TOutValue> : InOutVariable<TInValue, TOutValue>
    {
        public ILogger Logger
        {
            protected get;
            set;
        } = NullLogger.Instance;

        public LoggingInOutVariable()
        {
        }

        public LoggingInOutVariable(ILogger logger)
        {
            Logger = logger;
        }

        public LoggingInOutVariable(IConverter<TOutValue> converter = null)
            : base(converter)
        {
        }

        public LoggingInOutVariable(IConverter<TInValue, TOutValue> converter = null)
            : base(converter)
        {
        }

        public LoggingInOutVariable(ILogger logger, IConverter<TOutValue> converter = null)
            : base(converter)
        {
            Logger = logger;
        }

        public LoggingInOutVariable(ILogger logger, IConverter<TInValue, TOutValue> converter = null)
            : base(converter)
        {
            Logger = logger;
        }
    }
}
