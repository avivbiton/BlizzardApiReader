using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace BlizzardApiReader.Core.Exceptions
{
    public class BadResponseException : Exception
    {
        public HttpResponseMessage ResponseMessage;

        public BadResponseException(string message, HttpResponseMessage responseMessage) : base(message)
        {
            ResponseMessage = responseMessage;
        }

        public BadResponseException(HttpResponseMessage responseMessage) : base()
        {
            ResponseMessage = responseMessage;
        }
    }
}
