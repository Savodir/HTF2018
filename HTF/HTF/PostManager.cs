using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace HTF
{
    class PostManager
    {
        private static readonly HttpClient client = new HttpClient();
        public PostManager()
        {

        }
        public async void post()
        {
            var values = new Dictionary<string, string>
{
   { "thing1", "hello" },
   { "thing2", "world" }
};

            var content = new FormUrlEncodedContent(values);

            var response = await client.PostAsync("http://www.example.com/recepticle.aspx", content);

            var responseString = await response.Content.ReadAsStringAsync();

        }


    }
}

