using System;
using System.Collections;
using System.Collections.Generic;
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
            Message[] messages = null;
            MessageQueue[] QueueList = MessageQueue.GetPrivateQueuesByMachine(".");
            try
            {
                foreach (MessageQueue queue in QueueList)
                {
                    messages = queue.GetAllMessages();
                    if (messages.Length > 0)
                    {
                        foreach (Message m in messages)
                        {
                            m.Formatter = new XmlMessageFormatter(new String[] { "System.String,mscorlib" });
                            object val = queue.Receive();
                            File.WriteAllText(@"C:\Users\admin\Desktop\QuantityMeasurement_Backend\Quantity_Measurement_Backend\Receive.txt", val.ToString());

                        }

                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Queue.Dispose();
            }
            
            MessageQueue MyQueue = null;
            string path = @".\Private$\temp";
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
                        File.WriteAllText(@"C:\Users\admin\Desktop\QuantityMeasurement_Backend\Quantity_Measurement_Backend\Receive.txt", result);
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


