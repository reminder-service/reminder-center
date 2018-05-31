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

            WebRequest apiRequest = CreateBaseRequest(builder.Uri);
            apiRequest.Method = Http.Get;
            WebResponse apiResponse = apiRequest.GetResponseAsync().Result;

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

            WebRequest apiRequest = CreateBaseRequest(builder.Uri);
            apiRequest.Method = "PATCH";
            WebResponse apiResponse = apiRequest.GetResponseAsync().Result;
        }

        private WebRequest CreateBaseRequest(Uri uri)
        {
            WebRequest apiRequest = WebRequest.Create(uri);
            apiRequest.Credentials = GetCredential(uri);
            apiRequest.PreAuthenticate = true;
            return apiRequest;
        }

        private CredentialCache GetCredential(Uri uri)
        {
            CredentialCache credentialCache = new CredentialCache();
            credentialCache.Add(uri, "Basic", new NetworkCredential(username, password));
            return credentialCache;
        }

        private UriBuilder CreateBaseUriBuilder()
        {
            UriBuilder builder = new UriBuilder(baseUri);
            return builder;
        }

    }
}
