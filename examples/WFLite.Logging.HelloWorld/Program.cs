using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WFLite.Logging.Activities;
using WFLite.Variables;

namespace WFLite.Logging.HelloWorld
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var logger = new LoggerFactory().AddConsole().CreateLogger<Program>();

            var activity = new LogInformationActivity<Program>(logger)
            {
                Message = new AnyVariable() { Value = "Hello World!" } 
            };

            await activity.Start();

            Console.ReadKey();
        }
    }
}
