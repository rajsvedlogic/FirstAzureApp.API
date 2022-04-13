using System;
using System.Collections.Generic;
using System.Text;
//udf
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace FirstAzureApp.API.Core
{
    internal class APIResult : ObjectResult
    {
        public APIResult(HttpStatusCode statusCode = HttpStatusCode.OK, object data = null, object message = null) : base(new APIResponse(data, message, statusCode))
        {
            this.StatusCode = (int)statusCode;
        }
    }
    internal class APIResponse
    {
        public object data { get; }
        public object message { get; }
        public object status { get; }

        public APIResponse(object data, object message, HttpStatusCode status)
        {
            this.data = data;
            this.message = message;
            this.status = status;
        }
    }
}
