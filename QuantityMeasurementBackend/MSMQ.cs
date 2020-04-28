using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Experimental.System.Messaging;

namespace QuantityMeasurementBackend
{
    public class MSMQ
    {

        public void sendMessageToQueue()
        {
            string queueName = @".\private$\TestQueue"; 
            MessageQueue msMq = null;

            if (MessageQueue.Exists(queueName))

            {

                msMq = new MessageQueue(queueName);

            }

            else

            {
                MessageQueue.Create(queueName);
                msMq = new MessageQueue(queueName);

            }
            msMq.Send("Hello");
        }
    }
}
