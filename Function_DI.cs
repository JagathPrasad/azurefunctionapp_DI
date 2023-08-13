using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Routing;

namespace AzureFunction_DI
{
    public class Function_DI
    {

        public readonly IProcessor processor;
        public Function_DI(IProcessor _processor)
        {
            processor = _processor;
        }

        [FunctionName("Function_DI")]
        public void Run(
            [QueueTrigger("add-queue", Connection = "weather")] string req,
            ILogger log)
        {

            processor.Process();
            return;
        }
    }
}
