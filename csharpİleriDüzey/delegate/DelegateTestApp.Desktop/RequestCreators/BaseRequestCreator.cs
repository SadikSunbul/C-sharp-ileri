using DelegateTestApp.Desktop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace DelegateTestApp.Desktop.RequestCreators
{
    public abstract class BaseRequestCreator
    {

        public BaseRequestCreator()
        {
            makeRequestDelageMethod = MakeGETRequest;
        }

        // [Return Type] [MethodName]([parameters]);

        protected delegate string GetBaseAddressDelegate();
        GetBaseAddressDelegate getBaseAddressDelegateMethod;

        private delegate string MakeRequestDelage();
        MakeRequestDelage makeRequestDelageMethod;

        public delegate void RequesStartedDelegate();
        RequesStartedDelegate requesStartedMethod;

        Func<int> requestCountFunc;

        

        private HttpMethod httpMethod;

        protected void SetRequestCount(int count)
        {
            requestCountFunc = () => count;
        }

        protected void SetBaseAddressMethod(GetBaseAddressDelegate paramDelegateMethod)
        {
            getBaseAddressDelegateMethod = paramDelegateMethod;
        }

        public void SetRequestStartedMethod(RequesStartedDelegate requesStartedMethod)
        {
            this.requesStartedMethod = requesStartedMethod;
        }

        private string MakeGETRequest()
        {
            HttpClient client = new HttpClient();

            var baseAddress = getBaseAddressDelegateMethod.Invoke();

            var msg = new HttpRequestMessage
            {
                Method = httpMethod,
                RequestUri = new Uri(baseAddress + GetUrlPath())
            };

            var httpRes = client.Send(msg);

            httpRes.EnsureSuccessStatusCode();

            var resultContent = httpRes.Content.ReadAsStringAsync().GetAwaiter().GetResult();

            return resultContent;
        }

        private string MakePOSRequest()
        {
            HttpClient client = new HttpClient();

            var baseAddress = getBaseAddressDelegateMethod.Invoke();

            var msg = new HttpRequestMessage
            {
                Method = httpMethod,
                RequestUri = new Uri(baseAddress + GetUrlPath())
            };

            var bodyContent = GetBodyObject();
            if (bodyContent != null)
                msg.Content = new StringContent(JsonSerializer.Serialize(bodyContent));

            var httpRes = client.Send(msg);

            httpRes.EnsureSuccessStatusCode();

            var resultContent = httpRes.Content.ReadAsStringAsync().GetAwaiter().GetResult();



            return resultContent;
        }

        protected string MakeRequest()
        {
            var requestCount = Math.Max(requestCountFunc.Invoke(), 1);

            while ((requestCount--) > 0)
            {
                requesStartedMethod.Invoke();
            }

            return makeRequestDelageMethod.Invoke();
        }


        protected virtual string GetUrlPath()
        {
            return "";
        }

        protected HttpMethod SetHttpMethod(HttpMethod method)
        {
            if (method == HttpMethod.Post)
                makeRequestDelageMethod = MakePOSRequest;

            return httpMethod = method;
        }

        protected virtual object GetBodyObject()
        {
            return default;
        }

    }
}
