using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BGN.Grab
{
    class GrabAPI
    {
        public GrabHistoryStruct getNewOrders()
        {
            var client = new RestClient("https://api.grab.com/food/merchant/v2/orders-pagination?timestamp=&pageType=Preparing");
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            request.AddHeader("DEVICE-MODEL", "SM-N976N");
            request.AddHeader("BUSINESS-TYPE", "FOOD");
            request.AddHeader("DEVICE-OS", "Android");
            request.AddHeader("X-Request-ID", "b2e485f4990649b3babdd4e92ba17806");
            client.UserAgent = "Grab Merchant/4.27.0 (android 5.1.1; Build 90)";
            request.AddHeader("NetworkKit-disable-gzip", "true");
            request.AddHeader("authorization", "eyJhbGciOiJSUzI1NiIsImtpZCI6Il9kZWZhdWx0IiwidHlwIjoiSldUIn0.eyJhdWQiOiJNRVhVU0VSUyIsImV4cCI6MjE2MzI1NjM0NywiaWF0IjoxNjIzMjU2MzQ0LCJqdGkiOiJmYWEyMjJjNC02YzUyLTQ4M2UtYTJhYi05OTNiNWI3NWVhYTkiLCJsbWUiOiJOQVRJVkUiLCJuYW1lIjoiIiwic3ViIjoiZWM2ODdjMGYtMjkzMy00NTJhLWI5ODYtNzhhNGUzNzA1ZWUyIn0.ZMd5Ls4P0D5KycEiX43keq0b_m9OYO0AS9GVUCl7u64Zp-SL_1mlwzxVL8AVgmT8rXcFEh9DUbU41bghEij6wcaTmTFqlSThxXQEBEQqsH-WbYtpOangQ0z7VT6_sDu8nDxXJ-PijzrF1gLYERjgCbVJynLR4LjEy7mYC9-YrsZMlXt1FgFRVYo0zKctHWtM4syVW0AnAef6BDfANPug8pZ5TzbNreQK5UHa9aRFEBAY0EnvG2apGy2776GXkcoqqKFE_RRw3nV1VMldMHEHI8dzMOm2Zxa17KGirm2RAjw27QAfPwxbAh9-CE6VTGn69zs3iYRBxoott7r99N1iWA");
            client.UserAgent = "Grab Merchant/4.27.0 (android 5.1.1; Build 90)";
            request.AddHeader("MEX-TYPE", "MEXUSERS");
            request.AddHeader("X-Platform-Type", "android");
            request.AddHeader("mex-country", "VN");
            request.AddHeader("x-device-id", "38a43ecf1a4192b184096e80ac0893dd");
            request.AddHeader("DEVICE-id", "89840452045874262251");
            request.AddHeader("x-agent", "mexapp");
            request.AddHeader("x-mts-ssid", "eyJhbGciOiJSUzI1NiIsImtpZCI6Il9kZWZhdWx0IiwidHlwIjoiSldUIn0.eyJhdWQiOiJNRVhVU0VSUyIsImV4cCI6MjE2MzA4NzcyMSwiaWF0IjoxNjIzMDg3NzE4LCJqdGkiOiJjZTljZWMxZC0yZjZiLTQyMDMtYWRmNy0yZTBjNjQxNmMzNzgiLCJsbWUiOiJOQVRJVkUiLCJuYW1lIjoiIiwic3ViIjoiZWM2ODdjMGYtMjkzMy00NTJhLWI5ODYtNzhhNGUzNzA1ZWUyIn0.FvH6ObWClrVrvtSAULqMycL7Wh_4rsUBqBtSVuN8C3iCyRhbSAO7xC6nmcaJnh-RuX1o13rf9TjNYlM4Z1fHK_AwGk48uuicyh3psD-zGUI8DveZ4Bx0tCqp1NajWCJE6FawimNjkjFS4B241l5LrpoXn_p64QeX8zBLcWXSoUYsUufN7cEaKu6wN_NYKathEMBo75TepQtTryquCYXXSO_bBcAr0z3MSxK3JVp_cG-cd7LcPxnUqMJ7DsxuorPciDR8Ju5UncwlrJUwLjvDkFaEGgaNXe_shNcUOBy_YKVeCvKDGFiErlZUHfogOfPnHmj1H4fbsz8sYza7hjLupA");
            request.AddHeader("Host", "api.grab.com");
            request.AddHeader("Connection", "Keep-Alive");
            request.AddHeader("Accept-Encoding", "gzip");
            request.AddHeader("If-Modified-Since", "Mon, 07 Jun 2021 17:42:23 GMT");
            IRestResponse response = client.Execute(request);
            try
            {
                return JsonConvert.DeserializeObject<GrabHistoryStruct>(response.Content);
            }
            catch
            {
                return new GrabHistoryStruct();
            }
        }
    }
}
