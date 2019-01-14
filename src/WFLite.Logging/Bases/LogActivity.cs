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

namespace WFLite.Logging.Bases
{
    public abstract class LogActivity<TCategoryName> : SyncActivity
    {
        private readonly ILogger<TCategoryName> _logger;

        public IVariable EventId
        {
            private get;
            set;
        }

        public IVariable Exception
        {
            private get;
            set;
        }

        public IVariable Message
        {
            private get;
            set;
        }

        public IVariable Args
        {
            private get;
            set;
        }

        public LogActivity(ILogger<TCategoryName> logger)
        {
            _logger = logger;
        }

        protected sealed override bool run()
        {
            var eventId = EventId?.GetValue<EventId>();
            var exception = Exception?.GetValue<Exception>();
            var message = Message.GetValue<string>();
            var args = Args?.GetValue<object[]>();

            if (eventId == null && exception == null)
            {
                log(_logger, message, args);
            }
            else if (eventId != null && exception == null)
            {
                log(_logger, eventId.Value, message, args);
            }
            else if (eventId == null && exception != null)
            {
                log(_logger, exception, message, args);
            }
            else
            {
                log(_logger, eventId.Value, exception, message, args);
            }

            return true;
        }

        protected abstract void log(ILogger<TCategoryName> logger, EventId eventId, Exception exception, string message, object[] args);

        protected abstract void log(ILogger<TCategoryName> logger, EventId eventId, string message, object[] args);

        protected abstract void log(ILogger<TCategoryName> logger, Exception exception, string message, object[] args);

        protected abstract void log(ILogger<TCategoryName> logger, string message, object[] args);
     }
}
