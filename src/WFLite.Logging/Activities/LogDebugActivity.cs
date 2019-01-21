/*
 * LogDebugActivity.cs
 *
 * Copyright (c) 2019 aratomo-arazon
 *
 * This software is released under the MIT License.
 * http://opensource.org/licenses/mit-license.php
 */
 
using Microsoft.Extensions.Logging;
using System;
using WFLite.Interfaces;
using WFLite.Logging.Bases;

namespace WFLite.Logging.Activities
{
    public class LogDebugActivity<TCategoryName> : LogActivity<TCategoryName>
    {
        public LogDebugActivity(ILogger<TCategoryName> logger)
            : base(logger)
        {
        }

        public LogDebugActivity(ILogger<TCategoryName> logger, IVariable message, IVariable args = null, IVariable eventId = null, IVariable exception = null)
            : base(logger, message, args, eventId, exception)
        {
        }

        protected sealed override void log(ILogger<TCategoryName> logger, EventId eventId, Exception exception, string message, object[] args)
        {
            logger.LogDebug(eventId, exception, message, args);
        }

        protected sealed override void log(ILogger<TCategoryName> logger, EventId eventId, string message, object[] args)
        {
            logger.LogDebug(eventId, message, args);
        }

        protected sealed override void log(ILogger<TCategoryName> logger, Exception exception, string message, object[] args)
        {
            logger.LogDebug(exception, message, args);
        }

        protected sealed override void log(ILogger<TCategoryName> logger, string message, object[] args)
        {
            logger.LogDebug(message, args);
        }
    }
}