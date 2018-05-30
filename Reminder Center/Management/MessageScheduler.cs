using System;
using System.Threading;
using System.Collections.Concurrent;

namespace ReminderCenter.Management
{
    internal class MessageScheduler
    {
        public bool IsRunning { get; private set; }
        private Thread WaitingThread;
        private ConcurrentQueue<ScheduledMessage> messageQueue = new ConcurrentQueue<ScheduledMessage>();

        private struct ScheduledMessage
        {
            public ApiMessage Message;
            public DateTime Time;

            public ScheduledMessage(ApiMessage message, TimeSpan timeSpan)
            {
                Message = message;
                Time = DateTime.Now.Add(timeSpan);
            }
        }

        public MessageScheduler()
        {
            WaitingThread = new Thread(new ThreadStart(WaitingLoop))
            {
                Name = "ConnectLoop",
                IsBackground = true
            };
            WaitingThread.Start();
        }

        public void ScheduleMessage(ApiMessage message, TimeSpan timeSpan)
        {
            messageQueue.Enqueue(new ScheduledMessage(message, timeSpan));
        }
        
        private void WaitingLoop()
        {
            while (true)
            {
                if (!messageQueue.IsEmpty)
                {
                    if (!messageQueue.TryDequeue(out ScheduledMessage scheduledMessage))
                    {
                        Thread.Sleep(2000);
                        continue;
                    }

                    int timeIdentifier = DateTime.Compare(DateTime.Now, scheduledMessage.Time);

                    if (timeIdentifier < 0)
                    {
                        TimeSpan timeLeft = scheduledMessage.Time.Subtract(DateTime.Now);
                        
                        Thread.Sleep((int)timeLeft.TotalMilliseconds);
                        
                        MessageHandler.AddMessage(scheduledMessage.Message);
                    }
                    else
                    {
                        MessageHandler.AddMessage(scheduledMessage.Message);
                    }
                }
                
                Thread.Sleep(2000);
            }
        }




    }
}
