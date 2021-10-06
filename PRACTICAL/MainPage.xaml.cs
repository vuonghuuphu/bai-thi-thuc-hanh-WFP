using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using PRACTICAL.Models;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace PRACTICAL
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            adapter.DBhelper DB = adapter.DBhelper.GetInstance();
            service products = new service();
            var list = products.GetProduct();
            foreach (Product p in list) { 
            gridview_product.Items.Add(new Product()
            {
                name = p.name,
                content = p.content,
                img = p.img
            });
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            service products = new service();
            Product p = new Product
            {
                name = name.Text,
                content = content.Text,
                img = img.Text
            };
            products.AddProduct(p);
        }

    }
}
