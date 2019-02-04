/*
 * LoggingAsyncActivity.cs
 *
 * Copyright (c) 2019 aratomo-arazon
 *
 * This software is released under the MIT License.
 * http://opensource.org/licenses/mit-license.php
 */

using Microsoft.Extensions.Logging;
using WFLite.Activities;

namespace WFLite.Logging.Bases
{
    public abstract class LoggingSyncActivity : SyncActivity
    {
        private readonly ILogger _logger;

        public LoggingSyncActivity(ILogger logger)
        {
            _logger = logger;
        }

        protected sealed override bool run()
        {
            return run(_logger);
        }

        protected abstract bool run(ILogger logger);
    }
}
