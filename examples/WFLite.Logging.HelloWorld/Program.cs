using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WFLite.Interfaces;
using WFLite.Logging.Activities;
using WFLite.Logging.Variables;
using WFLite.Variables;

namespace WFLite.Logging.HelloWorld
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var logger = new LoggerFactory().AddConsole().CreateLogger<Program>();

            var activity = new LogInformationActivity(logger)
            {
                Message = new AnyVariable<string>() { Value = "{0} {1}" },
                Args = new ArgsVariable()
                {
                    Args = new List<IOutVariable>()
                    {
                        new AnyVariable<string>() { Value = "Hello" },
                        new AnyVariable<string>() { Value = "World!" }
                    }
                }
            };

            await activity.Start();

            Console.ReadKey();
        }
    }
}
