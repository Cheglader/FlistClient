using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlistClient
{
    public interface ImageManager
    {
        List<string> get_image_strings();

    }
    public class Restaurant
    {
        private string name;
        private uint id;
        private ImageManager image_manager;
        public Restaurant ()
        {
            
        }
    }
}
