using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
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
            
            using (var reader = new StreamReader(apiResponse.GetResponseStream()))
            {
                return JsonConvert.DeserializeObject<ApiMessage[]>(reader.ReadToEnd());
            }
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
