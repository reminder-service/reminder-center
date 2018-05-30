using Newtonsoft.Json;
using System;
using System.IO;
using System.Net;
using System.Text;
using static System.Net.WebRequestMethods;

namespace ReminderCenter.ApiClient
{
    class ReminderClient
    {
        
        private const string IDENTIFIER = "identifier";
        private const string MESSAGE = "message";

        private Uri baseUri;
        private string username;
        private string password;

        public ReminderClient(string baseUri, string username, string password)
        {
            Uri.TryCreate(baseUri, UriKind.Absolute, out this.baseUri);
            this.username = username;
            this.password = password;
        }
        
        /// <summary>
        /// Request all unread messages from api
        /// </summary>
        /// <param name="clientIdentifier"></param>
        /// <returns>Array of messages</returns>
        public ApiMessage[] RequestMessages(string clientIdentifier)
        {
            UriBuilder builder = CreateBaseUriBuilder();
            builder.Path += MESSAGE;
            builder.Query = IDENTIFIER + "=" + clientIdentifier;

            HttpWebRequest apiRequest = CreateBaseRequest(builder.Uri);
            apiRequest.Method = Http.Get;
            HttpWebResponse apiResponse = (HttpWebResponse)apiRequest.GetResponseAsync().Result;

            ApiMessage[] messages;
            using (var reader = new StreamReader(apiResponse.GetResponseStream()))
            {
                messages = JsonConvert.DeserializeObject<ApiMessage[]>(reader.ReadToEnd());
            }

            AcknowledgeMessages(clientIdentifier);
            return messages;
        }

        private void AcknowledgeMessages(string clientIdentifier)
        {
            UriBuilder builder = CreateBaseUriBuilder();
            builder.Path += IDENTIFIER;
            builder.Query = IDENTIFIER + "=" + clientIdentifier;

            HttpWebRequest apiRequest = CreateBaseRequest(builder.Uri);
            apiRequest.Method = "PATCH";
            HttpWebResponse apiResponse = (HttpWebResponse)apiRequest.GetResponseAsync().Result;
        }

        private HttpWebRequest CreateBaseRequest(Uri uri)
        {
            HttpWebRequest apiRequest = (HttpWebRequest)WebRequest.Create(uri);
            string credentials = Convert.ToBase64String(ASCIIEncoding.ASCII.GetBytes(username + ":" + password));
            apiRequest.Headers.Add("Authorization", "Basic " + credentials);
            return apiRequest;
        }

        private UriBuilder CreateBaseUriBuilder()
        {
            UriBuilder builder = new UriBuilder(baseUri);
            if (builder.Scheme == "")
            {
                builder.Scheme = "http";
            }
            return builder;
        }

    }
}
