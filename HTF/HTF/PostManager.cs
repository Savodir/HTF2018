using RestSharp;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace HTF
{
    class PostManager
    {
            String url;
            public PostManager(String url)
            {
                this.url = url + "/challenges/";
            }
            public void postChallenge(String challengecode, String identifier, String postname, String postanswer, String postchallengeid)
            {
                challengeID = postchallengeid,
                values = new List<Values>
                {
                    new Values { name = postname, data = postanswer },
                },
            };
            var json = request.JsonSerializer.Serialize(yourobject);
            Trace.WriteLine(json);
            request.AddParameter("application/json; charset=utf-8", json, ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);
            Trace.WriteLine(response.Content);

        }
    }
}


