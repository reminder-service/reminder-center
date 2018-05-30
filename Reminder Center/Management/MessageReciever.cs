using System.Threading;
using ReminderCenter.ApiClient;
using System.Collections.Generic;
using System.Net;
using System;
using Newtonsoft.Json;

namespace ReminderCenter.Management
{
    internal class MessageReciever
    {
        public bool IsRunning { get; private set; }
        public ReminderClient ApiConnection { get; set; }
        public string ApiIdentifier { get; set; }
        public static Settings MainForm { private get; set; }

        private Thread ApiThread;

        public MessageReciever(ReminderClient reminderConnection, string apiIdentifier)
        {
            this.ApiConnection = reminderConnection;
            this.ApiIdentifier = apiIdentifier;
            ApiThread = new Thread(new ThreadStart(ApiLoop))
            {
                Name = "ApiLoop",
                IsBackground = true
            };
            ApiThread.Start();
        }

        public void Recieve()
        {
            IsRunning = true;
            MainForm.SearchEnabled(!IsRunning);
        }
        
        private void ApiLoop()
        {
            while (true)
            {
                if (IsRunning)
                {
                    try
                    {
                        foreach (ApiMessage message in ApiConnection.RequestMessages(ApiIdentifier))
                        {
                            MessageHandler.AddMessage(message);
                        }
                    }
                    catch (WebException exception)
                    {
                        MessageHandler.AddMessage("Connection Exception: " + exception.Message);
                    }
                    catch (Exception exception)
                    {
                        MessageHandler.AddMessage(exception.Message);
                    }

                    IsRunning = false;
                    MainForm.SearchEnabled(!IsRunning);
                }

                Thread.Sleep(100);
            }
        }




    }
}
