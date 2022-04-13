using System;
using System.Collections.Generic;
using System.Text;
//UDF
using System.Net;

namespace FirstAzureApp.API.Exceptions
{
    public class UnauthorizedException : BaseException
    {
        public UnauthorizedException(string message, Exception innerException = null) : base(HttpStatusCode.Unauthorized, message, innerException)
        {
        }
    }
}
