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
    public class GetPostRequestCreator : BaseRequestCreator
    {
        public event EventHandler<int> OnRequestFinished;

        public GetPostRequestCreator()
        {
            base.SetBaseAddressMethod(() =>
            {
                return "https://jsonplaceholder.typicode.com/";
            });

            SetHttpMethod(HttpMethod.Get);

            SetRequestCount(2);
        }

        public List<PostModel> GetPosts()
        {
            var responseContent = MakeRequest();

            OnRequestFinished?.Invoke(this, responseContent.Length);

            return JsonSerializer.Deserialize<List<PostModel>>(responseContent);
        }



        protected override string GetUrlPath()
        {
            return "posts";
        }
    }
}
