using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlistClient
{
    public class ImageManager
    {
        private List<string> image_list = null; // FINISH
        public List<string> get_image_strings()
        {
            return image_list;
        }

    }
    public class Restaurant
    {
        private string name;
        private uint id;
        private ImageManager image_manager;
        private string thumbnail;
        public Restaurant ()
        {
            
        }
        public Restaurant (dynamic json_object)
        {

        }
    }
}
