using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Media.Imaging;

namespace PRACTICAL.Models
{
    class Product
    {
        public string name { set; get; }
        public string content { set; get; }
        public string img { set; get; }
        public List<Product> list = new List<Product>();
        public BitmapImage image
        {
            get => new BitmapImage(new Uri(img));
        }
       
    }
   
}
