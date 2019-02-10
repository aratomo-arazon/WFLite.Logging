/*
 * LoggingCondition.cs
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
    public abstract class LoggingCondition : Condition
    {
        public ILogger Logger
        {
            protected get;
            set;
        } = NullLogger.Instance;

        public LoggingCondition()
        {
        }

        public LoggingCondition(ILogger logger)
        {
            Logger = logger;
        }
    }
}
