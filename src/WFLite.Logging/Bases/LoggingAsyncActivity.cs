/*
 * LoggingAsyncActivity.cs
 *
 * Copyright (c) 2019 aratomo-arazon
 *
 * This software is released under the MIT License.
 * http://opensource.org/licenses/mit-license.php
 */

using Microsoft.Extensions.Logging;
using System.Threading;
using System.Threading.Tasks;
using WFLite.Activities;

namespace WFLite.Logging.Bases
{
    public abstract class LoggingAsyncActivity : AsyncActivity
    {
        private readonly ILogger _logger;

        public LoggingAsyncActivity(ILogger logger)
        {
            _logger = logger;
        }

        protected sealed override Task<bool> run(CancellationToken cancellationToken)
        {
            return run(_logger, cancellationToken);
        }

        protected abstract Task<bool> run(ILogger logger, CancellationToken cancellationToken);
    }
}
