using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;

namespace WFLite.Logging.Bases
{
    public abstract class LoggingConverter<TCategoryName> : WFLite.Bases.Converter
    {
        private readonly ILogger<TCategoryName> _logger;

        public LoggingConverter(ILogger<TCategoryName> logger)
        {
            _logger = logger;
        }

        protected sealed override object convert(object value)
        {
            return convert(_logger, value);
        }

        protected abstract object convert(ILogger<TCategoryName> logger, object value);
    }
}
