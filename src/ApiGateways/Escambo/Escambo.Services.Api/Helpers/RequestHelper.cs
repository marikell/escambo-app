using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.IO;
using System.Net;
using System.Text;

namespace Escambo.Services.Api.Helpers
{
    public class RequestResult
    {
        public string Message { get; set; }
        public HttpStatusCode StatusCode { get; set; }

        public RequestResult(string message, HttpStatusCode httpStatusCode)
        {
            StatusCode = httpStatusCode;
            Message = message;
        }
    }
    public class RequestHelper
    {
        private readonly HttpWebRequest _request;
        public RequestHelper(string uri, params string[] parameters)
        {
            _request = (HttpWebRequest)WebRequest.Create(DoParams(uri, parameters));
            _request.ContentType = "application/json; charset=utf-8";
        }

        private string DoParams(string uri, params string[] parameters)
        {
            for (int i = 0; i < parameters.Length; i++)
            {
                uri = uri.Replace($"p{i}", parameters[i]);
            }

            return uri;
        }
        public RequestResult DoGet()
        {
            _request.Method = "GET";

            var httpResponse = (HttpWebResponse)_request.GetResponse();

            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var responseText = streamReader.ReadToEnd();

                return new RequestResult(responseText, httpResponse.StatusCode);
            }
        }
        public RequestResult DoPost(string json)
        {
            _request.Method = "POST";

            using (var streamWriter = new StreamWriter(_request.GetRequestStream()))
            {
                streamWriter.Write(json);
                streamWriter.Flush();
            }
            var httpResponse = (HttpWebResponse)_request.GetResponse();

            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var responseText = streamReader.ReadToEnd();

                return new RequestResult(responseText, httpResponse.StatusCode);
            }
        }
    }
}
