using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreManagementSystem
{
    public class ProductDetailsViewModel
    {
        public ObservableCollection<ProductDetails> AvailableProducts { get; set; }
        public BaseCommand AddProduct { get; set; }
        public ProductDetailsViewModel()
        {
            AddProduct = new BaseCommand(AddProductMethod);
            AvailableProducts = new ObservableCollection<ProductDetails>();
        }
        private AddProduct Addproductpopout;
        public void AddProductMethod(object obj)
        {
            Addproductpopout = new AddProduct();
            Addproductpopout.ShowDialog();
            if(Addproductpopout.Addedproductvalues!=null && Addproductpopout.Addedproductvalues.Count!=0)
            {
                ProductDetails productDetails = new ProductDetails();
                productDetails.Name = Addproductpopout.Addedproductvalues["ProductName"];
                productDetails.Brand = Addproductpopout.Addedproductvalues["BrandName"];
                productDetails.Category = Addproductpopout.Addedproductvalues["Category"];
                productDetails.Code =Convert.ToInt64(Addproductpopout.Addedproductvalues["Code"]);
                productDetails.Price =Convert.ToInt16(Addproductpopout.Addedproductvalues["Code"]);
                productDetails.Quantity =Convert.ToInt16(Addproductpopout.Addedproductvalues["Quantity"]);
                productDetails.AlertQuantity =Convert.ToInt16(Addproductpopout.Addedproductvalues["AlertQuantity"]);
                AvailableProducts.Add(productDetails);
            }
        }
     

    }
}
