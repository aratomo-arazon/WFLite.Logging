/*
 * LoggingOutVariable.cs
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
    public abstract class LoggingOutVariable : OutVariable
    {
        public ILogger Logger
        {
            protected get;
            set;
        } = NullLogger.Instance;

        public LoggingOutVariable()
        {
        }

        public LoggingOutVariable(ILogger logger)
        {
            Logger = logger;
        }

        public LoggingOutVariable(IConverter converter = null)
            : base(converter)
        {
        }

        public LoggingOutVariable(ILogger logger, IConverter converter = null)
            : base(converter)
        {
            Logger = logger;
        }
    }

    public abstract class LoggingOutVariable<TOutValue> : OutVariable<TOutValue>
    {
        public ILogger Logger
        {
            protected get;
            set;
        } = NullLogger.Instance;

        public LoggingOutVariable()
        {
        }

        public LoggingOutVariable(ILogger logger)
        {
            Logger = logger;
        }

        public LoggingOutVariable(IConverter<TOutValue> converter = null)
            : base(converter)
        {
        }

        public LoggingOutVariable(ILogger logger, IConverter<TOutValue> converter = null)
            : base(converter)
        {
            Logger = logger;
        }
    }
}
