using System;
using System.Collections.Generic;
using Flurl;
using System.Threading.Tasks;
using Flurl.Http;
using System.Diagnostics;

namespace FlistClient
{
    public class Category
    {
        public uint id;
        public string name;

        public Category(uint id, string name)
        {
            this.id = id;
            this.name = name;
        }
    }
    public class FlistApi
    {
        private const string API_URL = "https://api.flistapp.com";
        private const string RESTAURANTS = "restaurants";
        private const string CATEGORY = "categories";
        private const string RATE = "restaurants/rate/";

        /*
        private class ApiRestaurant
        {
            public uint id;
            public string name;
        }*/
        
        public FlistApi()
        {
        }

        public static async Task<List<Restaurant>> GetRestaurantList(Category cat)
        {
            Debug.WriteLine("DRAKKKKK");
            string gg = API_URL
                .AppendPathSegment(RESTAURANTS)
                .SetQueryParams(new
                {
                    category_id = cat.id
                });
            Debug.WriteLine("FNDIODFNIOSD");
            Debug.WriteLine(gg);
            var result = await gg.GetJsonAsync();
            List<Restaurant> ret_val = new List<Restaurant>();
            var restaurants_api_objects = result.results;
            foreach (dynamic item in restaurants_api_objects)
            {
                ret_val.Add(item);
            }
            return ret_val;
        }
        public static async Task<List<Category>> GetCategoryList()
        {
            Debug.WriteLine("DRAKKKKK");
            string gg = API_URL
                .AppendPathSegment(CATEGORY);
            Debug.WriteLine("FNDIODFNIOSD");
            Debug.WriteLine(gg);
            var result = await gg.GetJsonAsync();
            Debug.WriteLine("GGGDI");
            Debug.WriteLine(result);
            List<Category> ret_val = new List<Category>();
            var category_api_objects = result.results;
            foreach(dynamic item in category_api_objects)
            {
                ret_val.Add(item);
            }
            return ret_val;
        }
    }
}

