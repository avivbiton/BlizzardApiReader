using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace BlizzardApiReader.Core.Exceptions
{
    public class BadResponseException : Exception
    {
        public IApiResponse ResponseMessage;

        public BadResponseException(string message, IApiResponse responseMessage) : base(message)
        {
            ResponseMessage = responseMessage;
        }

        public BadResponseException(IApiResponse responseMessage) : base()
        {
            ResponseMessage = responseMessage;
        }
    }
}
