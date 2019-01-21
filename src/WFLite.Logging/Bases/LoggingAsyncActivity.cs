using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WFLite.Activities;

namespace WFLite.Logging.Bases
{
    public abstract class LoggingAsyncActivity<TCategoryName> : AsyncActivity
    {
        private readonly ILogger<TCategoryName> _logger;

        public LoggingAsyncActivity(ILogger<TCategoryName> logger)
        {
            _logger = logger;
        }

        protected sealed override Task<bool> run(CancellationToken cancellationToken)
        {
            return run(_logger, cancellationToken);
        }

        protected abstract Task<bool> run(ILogger<TCategoryName> logger, CancellationToken cancellationToken);
    }
}
