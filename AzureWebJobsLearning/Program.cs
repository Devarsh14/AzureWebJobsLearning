﻿using System;
using Microsoft.Extensions.Hosting;
using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;


namespace AzureWebJobsLearning
{
    // https://docs.microsoft.com/en-us/azure/app-service/webjobs-sdk-get-started Dot net core uses only 3.0.6 or > version of package.
    // https://docs.microsoft.com/en-us/azure/app-service/webjobs-sdk-how-to
    //https://docs.microsoft.com/en-us/azure/app-service/webjobs-dotnet-deploy-vs
    // Packge installed 
    // 1. Microsoft.Azure.WebJobs
    // 2. Microsoft.Azure.WebJobs.Extensions

    // Note install both package. otherwise addAzureStorageCoreService will show not available. red line.

    //Install the latest stable version of the following NuGet packages: for Logging.
    //3.Microsoft.Extensions.Logging - The logging framework.
    //4.Microsoft.Extensions.Logging.Console - The console provider, which sends logs to the console.

        // Install storage binding extension 
        // 5.  Microsoft.Azure.WebJobs.Extensions.Storage 



        // TODO :: https://docs.microsoft.com/en-us/aspnet/core/fundamentals/configuration/?view=aspnetcore-2.2 --> Configuration provier link

        // app settings .json file. copy to output directory if newer in properties. 

        // 6.  Storage emulator run
        //7. storage explorer run
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new HostBuilder();
            builder.ConfigureWebJobs(b =>
                    {
                        b.AddAzureStorageCoreServices();
                        b.AddAzureStorage();
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
