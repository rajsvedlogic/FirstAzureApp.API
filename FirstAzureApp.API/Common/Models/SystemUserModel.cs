using System;
using System.Collections.Generic;
using System.Text;


namespace FirstAzureApp.API.Common.Models
{
    public class SystemUserModel : Base.Model
    {
        public SystemUserModel(System.Guid id, string name) : base("systemuser")
        {
            this.id = id;
            this.name = name;
        }

    }
}
