using System;
using System.Collections.Generic;

using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace BGN.Grab
{
    public partial class GrabHistoryStruct
    {
        [JsonProperty("unreadNumberInNew")]
        public long UnreadNumberInNew { get; set; }

        [JsonProperty("unreadAANumberInPrepare")]
        public long UnreadAaNumberInPrepare { get; set; }

        [JsonProperty("unreadViaCallNumberInPrepare")]
        public long UnreadViaCallNumberInPrepare { get; set; }

        [JsonProperty("numberInNew")]
        public long NumberInNew { get; set; }

        [JsonProperty("numberInPrepare")]
        public long NumberInPrepare { get; set; }

        [JsonProperty("nextRequestTimestamp")]
        public DateTimeOffset NextRequestTimestamp { get; set; }

        [JsonProperty("merchantModel")]
        public string MerchantModel { get; set; }

        [JsonProperty("isOpen")]
        public bool IsOpen { get; set; }

        [JsonProperty("orders")]
        public object[] Orders { get; set; }

        [JsonProperty("haveMore")]
        public bool HaveMore { get; set; }

        [JsonProperty("pageType")]
        public string PageType { get; set; }

        [JsonProperty("numberReady")]
        public long NumberReady { get; set; }

        [JsonProperty("numberInDelivering")]
        public long NumberInDelivering { get; set; }
    }
}
