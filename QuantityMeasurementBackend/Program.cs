using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Experimental.System.Messaging;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace QuantityMeasurementBackend
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BuildWebHost(args).Run();
            MessageQueue MyQueue = null;
            string path = @".\Private$\quantityQueue";
            try
            {
                MyQueue = new MessageQueue(path);
                Message[] message = MyQueue.GetAllMessages();
                if (message.Length > 0)
                {
                    foreach (Message msg in message)
                    {
                        msg.Formatter = new XmlMessageFormatter(new string[] { "System.String,mscorlib" });
                        string result = msg.Body.ToString();
                        MyQueue.Receive();
                        File.WriteAllText(@"E:\QuantityMeasurementBackend\QuantityMeasurementBackend\Sender.txt", result);
                    }
                    MyQueue.Refresh();
                }
                else
                {
                    Console.WriteLine("No Message");
                }
            }
                catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public static IWebHost BuildWebHost(string[] args) =>
                WebHost.CreateDefaultBuilder(args)
                .UseKestrel()
                .UseIISIntegration()
                    .UseStartup<Startup>()
                    .Build();
    }
}


