﻿using RestSharp;
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
        public void postChallenge(String challengecode, String identifier,  String postchallengeid, List<Value> values)
        {
            var client = new RestClient(url);
            var request = new RestRequest(url + challengecode, Method.POST);
            request.AddHeader("htf-identification", identifier);

            var yourobject = new RequestObject()
            {
                challengeID = postchallengeid,
                values = values
            };
                var json = request.JsonSerializer.Serialize(yourobject);
                Trace.WriteLine(json);
                request.AddParameter("application/json; charset=utf-8", json, ParameterType.RequestBody);
                IRestResponse response = client.Execute(request);
                Trace.WriteLine(response.Content);

            }
        }
    }


