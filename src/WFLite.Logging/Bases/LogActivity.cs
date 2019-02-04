/*
 * LogActivity.cs
 *
 * Copyright (c) 2019 aratomo-arazon
 *
 * This software is released under the MIT License.
 * http://opensource.org/licenses/mit-license.php
 */

using Microsoft.Extensions.Logging;
using System;
using WFLite.Activities;
using WFLite.Interfaces;
using WFLite.Variables;

namespace WFLite.Logging.Bases
{
    public abstract class LogActivity : SyncActivity
    {
        private readonly ILogger _logger;

        public IOutVariable<string> Message
        {
            private get;
            set;
        }

        public IOutVariable<object[]> Args
        {
            private get;
            set;
        }

        public IOutVariable<EventId> EventId
        {
            private get;
            set;
        }

        public IOutVariable<Exception> Exception
        {
            private get;
            set;
        }

        public LogActivity(ILogger logger)
        {
            _logger = logger;
        }

        public LogActivity(ILogger logger,
            IOutVariable<string> message,
            IOutVariable<object[]> args = null,
            IOutVariable<EventId> eventId = null, 
            IOutVariable<Exception> exception = null)
        {
            _logger = logger;

            Message = message;
            Args = args;
            EventId = eventId;
            Exception = exception;
        }

        protected sealed override void initialize()
        {
            if (Args == null)
            {
                Args = new NullVariable<object[]>();
            }

            if (EventId == null)
            {
                EventId = new NullVariable<EventId>();
            }

            if (Exception == null)
            {
                Exception = new NullVariable<Exception>();
            }
        }

        protected sealed override bool run()
        {
            var message = Message.GetValue();
            var args = Args.GetValue();
            var eventId = EventId.GetValueAsObject();
            var exception = Exception.GetValue();

            if (eventId == null && exception == null)
            {
                log(_logger, message, args);
            }
            else if (eventId != null && exception == null)
            {
                log(_logger, (EventId)eventId, message, args);
            }
            else if (eventId == null && exception != null)
            {
                log(_logger, exception, message, args);
            }
            else
            {
                log(_logger, (EventId)eventId, exception, message, args);
            }

            return true;
        }

        protected abstract void log(ILogger logger, EventId eventId, Exception exception, string message, object[] args);

        protected abstract void log(ILogger logger, EventId eventId, string message, object[] args);

        protected abstract void log(ILogger logger, Exception exception, string message, object[] args);

        protected abstract void log(ILogger logger, string message, object[] args);
     }
}
