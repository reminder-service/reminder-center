using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace ReminderCenter.Management
{
    internal class MessageHandler
    {
        public static Settings MainForm { private get; set; }

        private static MessageScheduler Scheduler = new MessageScheduler();

        private static int currentMessageCount = 0;
        private static SynchronizedCollection<ApiMessage> messageList = new SynchronizedCollection<ApiMessage>();
        public static NotifyIcon NotifyIcon { get; set; }

        public static bool HasMessages
        {
            get
            {
                return (currentMessageCount > 0);
            }
        }

        public static void AddMessage(string message)
        {
            MainForm.Invoke((MethodInvoker)delegate()
            {
                ApiMessage tempMessage = new ApiMessage(message);
                tempMessage.SetPosition(currentMessageCount);
                messageList.Add(tempMessage);
                tempMessage.Show();
            });
            currentMessageCount++;
        }

        public static void AddMessage(ApiMessage message)
        {
            MainForm.Invoke((MethodInvoker)delegate ()
            {
                message.SetPosition(currentMessageCount);
                messageList.Add(message);
                message.Show();
            });
            currentMessageCount++;
        }

        public static void DismissMessage(ApiMessage message)
        {
            messageList.Remove(message);
            message.Close();
            currentMessageCount--;

            if (currentMessageCount > 0)
            {
                RepositionMessages();
            }
        }

        public static void RescheduleMessage(ApiMessage message)
        {
            TimeSpan timeSpan = Properties.Settings.Default.RescheduleRate;
            Scheduler.ScheduleMessage(message, timeSpan);
            DismissMessage(message);
        }

        public static void DismissAllMessages()
        {
            foreach (ApiMessage message in messageList)
            {
                message.Close();
            }
            currentMessageCount = 0;
            messageList.Clear();
        }

        public static void RescheduleAllMessages()
        {
            TimeSpan timeSpan = Properties.Settings.Default.RescheduleRate;
            foreach (ApiMessage message in messageList)
            {
                Scheduler.ScheduleMessage(message, timeSpan);
            }
            DismissAllMessages();
        }

        public static void RepositionMessages(int positionModifier = 0)
        {
            for (int i = 0; i < messageList.Count; i++)
            {
                messageList[i].SetPosition(i, positionModifier);
            }
        }
    }
}
