using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace StoreManagementSystem
{
    /// <summary>
    /// Interaction logic for AddProduct.xaml
    /// </summary>
    public partial class AddProduct : Window
    {
        public Dictionary<string, string> Addedproductvalues;

        public AddProduct()
        {
            InitializeComponent();
            Addedproductvalues = new Dictionary<string, string>();

        }

        private void Close_Window(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Add_Product(object sender, RoutedEventArgs e)
        {
            Addedproductvalues.Add("ProductName", ProductName.Text);
            Addedproductvalues.Add("BrandName", BrandName.Text);
            Addedproductvalues.Add("Category", Category.Text);
            Addedproductvalues.Add("Code", Code.Text);
            Addedproductvalues.Add("Price", Price.Text);
            Addedproductvalues.Add("Quantity", Quantity.Text);
            Addedproductvalues.Add("AlertQuantity", AlertQuantity.Text);
            this.Close();
        }
    }
}
