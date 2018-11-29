using RestSharp;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace HTF
{
    class GetManager
    {
        IRestResponse response;
        public GetManager() { }
        public void get(String url, String challengecode, String identifier)
        {
            RestClient client = new RestClient(url);


            IRestRequest request = new RestRequest("/challenges/" + challengecode, Method.GET);
            request.AddHeader("Content-Type", "application/json; charset=utf-8");
            request.OnBeforeDeserialization = resp => { resp.ContentType = "application/json"; };
            request.AddHeader("htf-identification", identifier);
            //request.RequestFormat = RestSharp.DataFormat.Json;

            var queryResult = client.Execute(request);
            Trace.WriteLine(queryResult.Content);
            Trace.WriteLine(url + "/challenges/" + challengecode);
        }
    }

}
