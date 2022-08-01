using System.IO;
using System.Net;
using System.Collections.Generic;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace NwNsgProject
{
    public static class HttpTriggerFunction
    {
		[FunctionName("HttpTriggerFunction")]
		public static async Task Run([HttpTrigger(AuthorizationLevel.Function, "get", "post", Route = null)] HttpRequest req, ILogger log)
		{
    		log.LogInformation("HTTP trigger function processed a request.");
		}
	}
}