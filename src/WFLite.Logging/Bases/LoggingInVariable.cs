/*
 * LoggingInVariable.cs
 *
 * Copyright (c) 2019 aratomo-arazon
 *
 * This software is released under the MIT License.
 * http://opensource.org/licenses/mit-license.php
 */

using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;
using WFLite.Bases;

namespace WFLite.Logging.Bases
{
    public abstract class LoggingInVariable : InVariable
    {
        public ILogger Logger
        {
            protected get;
            set;
        } = NullLogger.Instance;

        public LoggingInVariable()
        {
        }

        public LoggingInVariable(ILogger logger)
        {
            Logger = logger;
        }
    }

    public abstract class LoggingInVariable<TInValue> : InVariable<TInValue>
    {
        public ILogger Logger
        {
            protected get;
            set;
        } = NullLogger.Instance;

        public LoggingInVariable()
        {
        }

        public LoggingInVariable(ILogger logger)
        {
            Logger = logger;
        }
    }
}
