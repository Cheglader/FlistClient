using System;
using System.Collections.Generic;
using System.Linq;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace FlistClient.Droid
{
	[Activity (Label = "FlistClient.Droid", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : ListActivity
	{
        Category selected;
        List<Category> categories;
        string[] items;

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

            Console.WriteLine("GGGGGG");
            categories = FlistApi.GetCategoryList().Result;
            Console.WriteLine("YYYYYY");
            // Set our view from the "main" layout resource
            // SetContentView (Resource.Layout.Main);
            /*
            categories = new List<Category>();
            categories.Add(new Category(1, "Pizza"));
            categories.Add(new Category(2, "Burgers"));
            categories.Add(new Category(2, "Italian"));
            categories.Add(new Category(4, "Mexican"));*/

            ListAdapter = new ArrayAdapter<String>(this, Android.Resource.Layout.SimpleListItem1, categories.Select(x => x.name).ToArray());
            // items = new string[] { "Vegetables", "Fruits", "Flower Buds", "Legumes", "Bulbs", "Tubers" };
            // ListAdapter = new ArrayAdapter<String>(this, Android.Resource.Layout.SimpleListItem1, items);

            // Get our button from the layout resource,
            // and attach an event to it
            //Button button = FindViewById<Button> (Resource.Id.myButton);
            /*
			button.Click += delegate {
				button.Text = string.Format ("{0} clicks!", count++);
			};*/
        }
	}
}


