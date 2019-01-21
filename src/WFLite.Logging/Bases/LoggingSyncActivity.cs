using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;
using WFLite.Activities;

namespace WFLite.Logging.Bases
{
    public abstract class LoggingSyncActivity<TCategoryName> : SyncActivity
    {
        private readonly ILogger<TCategoryName> _logger;

        public LoggingSyncActivity(ILogger<TCategoryName> logger)
        {
            _logger = logger;
        }

        protected sealed override bool run()
        {
            return run(_logger);
        }

        protected abstract bool run(ILogger<TCategoryName> logger);
    }
}
