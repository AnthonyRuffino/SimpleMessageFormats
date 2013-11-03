using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleMessageFormats.StatusMessages
{
    public class SimpleStatus
    {

        public static int SUCCESS_CODE = 1;
        public static int ERROR_CODE = -1;

        public int StatusCode { get; set; }
        public string Description { get; set; }

        public void setSuccess(bool isSuccessful, string description)
        {
            this.StatusCode = isSuccessful ? SUCCESS_CODE : ERROR_CODE;
            this.Description = description != null ? description : "";
        }
    }
}
