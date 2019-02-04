/*
 * LogCriticalActivity.cs
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
    public class LogCriticalActivity : LogActivity
    {
        public LogCriticalActivity(ILogger logger)
            : base(logger)
        {
        }

        public LogCriticalActivity(ILogger logger,
            IOutVariable<string> message,
            IOutVariable<object[]> args = null,
            IOutVariable<EventId> eventId = null,
            IOutVariable<Exception> exception = null)
            : base(logger, message, args, eventId, exception)
        {
        }

        protected sealed override void log(ILogger logger, EventId eventId, Exception exception, string message, object[] args)
        {
            logger.LogCritical(eventId, exception, message, args);
        }

        protected sealed override void log(ILogger logger, EventId eventId, string message, object[] args)
        {
            logger.LogCritical(eventId, message, args);
        }

        protected sealed override void log(ILogger logger, Exception exception, string message, object[] args)
        {
            logger.LogCritical(exception, message, args);
        }

        protected sealed override void log(ILogger logger, string message, object[] args)
        {
            logger.LogCritical(message, args);
        }
    }
}