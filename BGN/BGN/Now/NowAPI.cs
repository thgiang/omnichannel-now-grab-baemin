using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BGN.Now
{
    class NowAPI
    {
        public NowHistoryStruct getNewOrders()
        {
            var client = new RestClient("https://gmerchant.deliverynow.vn/api/order/get_processing_orders");
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddHeader("X-Foody-Api-Version", "1");
            request.AddHeader("X-Foody-Client-Type", "4");
            request.AddHeader("X-Foody-Client-Version", "2.55.1");
            request.AddHeader("X-Foody-Client-Id", "9679242d-ea40-44b2-8534-05a2781688a4");
            request.AddHeader("X-Foody-Device-Id", "ffffffff-a342-944e-ffff-ffffce8b89f9");
            request.AddHeader("X-Foody-App-Type", "1001");
            request.AddHeader("X-Foody-Client-Language", "vi");
            request.AddHeader("X-Foody-Access-Token", "fa5e3c0ca7101f8f805327b87f2ae35e6bdfd4b5a5c13d9666348ebdd0cc15db03b37fec62a8720c758e1ae1ce803c80d0e36e387e6dc52a1870c601557cf036");
            request.AddHeader("Content-Type", "application/json; charset=utf-8");
            request.AddHeader("Host", "gmerchant.deliverynow.vn");
            request.AddHeader("Connection", "Keep-Alive");
            request.AddHeader("Accept-Encoding", "gzip");
            client.UserAgent = "okhttp/3.12.1";
            var body = @"{""restaurant_id"":1071890}";
            request.AddParameter("application/json; charset=utf-8", body, ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);
            try
            {
                return JsonConvert.DeserializeObject<NowHistoryStruct>(response.Content);
            }
            catch
            {
                return new NowHistoryStruct();
            }
        }
    }
}
