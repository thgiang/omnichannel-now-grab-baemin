using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BGN.Baemin
{
    class BaeminAPI
    {
        public BaeminHistoryStruct getNewOrders()
        {
            string today = DateTime.Now.ToString("yyyy-MM-dd");
            var client = new RestClient("https://api.baemin.vn/v3/stores/Qia8Z-s--/orders?date="+ today + "&page=1");
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            request.AddHeader("x-client-version", "0.37.4");
            request.AddHeader("x-client-platform", "Android");
            request.AddHeader("x-access-token", "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJyb2xlIjoibWFuYWdlciIsImlkIjoiZnQxVHJuRkZoIiwiaWF0IjoxNjIyODM0ODAyLCJleHAiOjE2MjU0MjY4MDJ9.rSa0dNidoK40xN5XCQZl9705hkNFD1TlJ4vrLo55VZI");
            request.AddHeader("Host", "api.baemin.vn");
            request.AddHeader("Connection", "Keep-Alive");
            request.AddHeader("Accept-Encoding", "gzip");
            request.AddHeader("accept", "application/json");
            request.AddHeader("content-type", "application/json");
            request.AddHeader("accept-language", "en");
            //client.UserAgent = "Mozilla/5.0 (Windows NT 6.1; Win64; x64; rv:47.0) Gecko/20100101 Firefox/47.0";
            IRestResponse response = client.Execute(request);
            try
            {
                return JsonConvert.DeserializeObject<BaeminHistoryStruct>(response.Content);
            } catch
            {
                return new BaeminHistoryStruct();
            }
            
        }
    }
}
