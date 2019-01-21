using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;
using WFLite.Bases;

namespace WFLite.Logging.Bases
{
    public abstract class LoggingVariable<TCategoryName> : Variable
    {
        private readonly ILogger<TCategoryName> _logger;

        public LoggingVariable(ILogger<TCategoryName> logger)
        {
            _logger = logger;
        }

        protected sealed override object getValue()
        {
            return getValue(_logger);
        }
        　
        protected sealed override void setValue(object value)
        {
            setValue(_logger, value);
        }

        protected abstract object getValue(ILogger<TCategoryName> logger);

        protected abstract void setValue(ILogger<TCategoryName> logger, object value);
    }
}
