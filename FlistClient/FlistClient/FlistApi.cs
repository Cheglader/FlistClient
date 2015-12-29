using System;
using System.Collections.Generic;
using Flurl;
using Newtonsoft.Json.Linq;

namespace FlistClient
{
    public class FlistApi
    {
        private const string API_URL = "https://api.flistapp.com";
        private const string RESTAURANTS = "restaurants/";
        private const string CATEGORY = "categories/";
        private const string RATE = "restaurants/rate/";

        private class ApiRestaurant
        {
            public uint id;
            public string name;
        }
        private class ApiCategory
        {
            public uint id;
            public string name;
        }
        public FlistApi()
        {
        }

        public List<Restaurant> get_restaurant_list() { return new List<Restaurant>(); }
        public List<dynamic> get_category_list()
        {
            var result = await "https://api.mmm.com"
                .AppendPathSegment("person")
                .SetQueryParam(new string { a = 1, b = 2 })
                .ReceiveJson<string>();
            List<dynamic> ret_val = new List<dynamic>();
            string api_json = "Finish";
            JObject api_response = JObject.Parse(api_json);
            JArray category_api_objects = (JArray)api_response["results"];
            foreach(JObject item in category_api_objects.Children<JObject>())
            {
                ret_val.Add(item);
            }
            return ret_val;
        }
    }
}

