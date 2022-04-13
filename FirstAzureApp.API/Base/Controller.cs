using System;
using System.Collections.Generic;
using System.Text;
//udf
using FirstAzureApp.API.Core;

namespace FirstAzureApp.API.Base
{
    public abstract class Controller
    {
        protected readonly Bootstrap Function;
        public Controller(Bootstrap wrapper)
        {
            Function = wrapper;
        }
    }
}
