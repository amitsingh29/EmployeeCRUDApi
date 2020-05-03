using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Experimental.System.Messaging;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using QuantityMeasurementBacken;

namespace QuantityMeasurementBackend
{
    public class Program
    {
        public static void Main(string[] args)
        {
            MSMQ msmq = new MSMQ();
            string value = msmq.ReceivingTheMessage();
            BuildWebHost(args).Run();
        }
        public static IWebHost BuildWebHost(string[] args) =>
                WebHost.CreateDefaultBuilder(args)
                .UseKestrel()
                .UseIISIntegration()
                    .UseStartup<Startup>()
                    .Build();
    }
}


