using System;
using System.Collections.Generic;
using System.Text;
//udf
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using FirstAzureApp.API.Exceptions;

namespace FirstAzureApp.API.Core
{
    public class Bootstrap
    {
        private readonly ILogger Log;
        public Bootstrap(ILogger<Bootstrap> log)
        {
            Log = log;
        }

        public async Task<IActionResult> Execute(HttpRequest req, Func<Task<IActionResult>> azureFunction)
        {
            try
            {
                Log.LogInformation("---Wrapper Init---");

                return await azureFunction();
            }
            catch (BaseException ex)
            {
                Log.LogError(ex, "Handled exception occured in Wrapper");
                return new APIResult(ex.statusCode, ex.innerException?.Message, ex.errorMessage);
            }
            catch (Exception e)
            {
                Log.LogError(e, "Unhandled exception occured in Wrapper");
                return new APIResult(System.Net.HttpStatusCode.InternalServerError, e.Message, e.InnerException?.Message);
            }
        }
    }

}
