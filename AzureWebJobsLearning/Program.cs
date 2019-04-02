using System;
using Microsoft.Extensions.Hosting;
using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;


namespace AzureWebJobsLearning
{
    // https://docs.microsoft.com/en-us/azure/app-service/webjobs-sdk-get-started Dot net core uses only 3.0.6 or > version of package.
    // Packge installed 
    // 1. Microsoft.Azure.WebJobs
    // 2. Microsoft.Azure.WebJobs.Extensions

    // Note install both package. otherwise addAzureStorageCoreService will show not available. red line.

    //Install the latest stable version of the following NuGet packages: for Logging.
    //Microsoft.Extensions.Logging - The logging framework.
    //Microsoft.Extensions.Logging.Console - The console provider, which sends logs to the console.

        // Install storage binding extension 
        //  Microsoft.Azure.WebJobs.Extensions.Storage 
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new HostBuilder();
            builder.ConfigureWebJobs(b =>
                    {
                        b.AddAzureStorageCoreServices();
                    });
            builder.ConfigureLogging((context, b) =>
            {
                b.AddConsole();
            });
            var host = builder.Build();
            using (host)
            {
                host.Run();
            }
        }
    }
}
