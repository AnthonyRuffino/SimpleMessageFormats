using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleMessageFormats.StatusMessages
{
    public class SimpleStatusDetailMap : SimpleStatus
    {
        public Dictionary<string, object> DetailMap { get; set; }
    }
}
