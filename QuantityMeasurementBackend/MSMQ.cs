using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Experimental.System.Messaging;

namespace QuantityMeasurementBacken
{
    public class MSMQ
    {
        public void sendMessage(string message, decimal value)
        {
            MessageQueue messageQueue = null;
            string description = message;
            string path = @".\Privates$\temp";
            try
            {
                if(MessageQueue.Exists(path))
                {
                    messageQueue = new MessageQueue(path);
                }

                else
                {
                    MessageQueue.Create(path);
                    messageQueue = new MessageQueue(path);
                }
                string result = message + value;
                messageQueue.Send(result, description);
            }
            catch
            {
                throw;
            }
        }
        public void receiveMessage()
        {
            MessageQueue m = new MessageQueue();
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
                        Console.WriteLine(result);
                        MyQueue.Receive();
                    }
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
    }
}
   

