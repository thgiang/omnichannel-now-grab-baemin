using System;
using System.Collections.Generic;

using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace BGN.Now
{
    public partial class NowHistoryStruct
    {
        [JsonProperty("reply")]
        public Reply Reply { get; set; }

        [JsonProperty("result")]
        public string Result { get; set; }
    }

    public partial class Reply
    {
        [JsonProperty("orders")]
        public object[] Orders { get; set; }
    }
}