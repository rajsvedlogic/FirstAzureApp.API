using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace FirstAzureApp.API.Exceptions
{
    public class BadRequestException : BaseException
    {
        public BadRequestException(string message, Exception innerException = null) : base(HttpStatusCode.BadRequest, message, innerException)
        {
        }
    }
}
