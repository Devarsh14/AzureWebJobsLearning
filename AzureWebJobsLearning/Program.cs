using System;
using Microsoft.Extensions.Hosting;
using Microsoft.Azure.WebJobs;


namespace AzureWebJobsLearning
{
    // https://docs.microsoft.com/en-us/azure/app-service/webjobs-sdk-get-started Dot net core uses only 3.0.6 or > version of package.
    // Packge installed 
    // 1. Microsoft.Azure.WebJobs
    // 2. Microsoft.Azure.WebJobs.Extensions

        // Note install both package. otherwise addAzureStorageCoreService will show not available. red line.

    class Program
    {
        static void Main(string[] args)
        {
            var builder = new HostBuilder();
            builder.ConfigureWebJobs(b =>
                    {
                        b.AddAzureStorageCoreServices();
                    });
            var host = builder.Build();
            using (host)
            {
                host.Run();
            }
        }
    }
}
