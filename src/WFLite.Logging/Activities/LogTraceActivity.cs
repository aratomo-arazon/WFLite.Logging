/*
 * LogTraceActivity.cs
 *
 * Copyright (c) 2019 aratomo-arazon
 *
 * This software is released under the MIT License.
 * http://opensource.org/licenses/mit-license.php
 */

using Microsoft.Extensions.Logging;
using System;
using WFLite.Logging.Bases;

namespace WFLite.Logging.Activities
{
    public class LogTraceActivity<TCategoryName> : LogActivity<TCategoryName>
    {
        public LogTraceActivity(ILogger<TCategoryName> logger)
            : base(logger)
        {
        }

        protected sealed override void log(ILogger<TCategoryName> logger, EventId eventId, Exception exception, string message, object[] args)
        {
            logger.LogTrace(eventId, exception, message, args);
        }

        protected sealed override void log(ILogger<TCategoryName> logger, EventId eventId, string message, object[] args)
        {
            logger.LogTrace(eventId, message, args);
        }

        protected sealed override void log(ILogger<TCategoryName> logger, Exception exception, string message, object[] args)
        {
            logger.LogTrace(exception, message, args);
        }

        protected sealed override void log(ILogger<TCategoryName> logger, string message, object[] args)
        {
            logger.LogTrace(message, args);
        }
    }
}