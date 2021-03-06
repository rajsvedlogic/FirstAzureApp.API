using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace FirstAzureApp.API.Exceptions
{
    public class NotFoundException : BaseException
    {
        public NotFoundException(string message, Exception innerException = null) : base(HttpStatusCode.NotFound, message, innerException)
        {
        }
    }
}
