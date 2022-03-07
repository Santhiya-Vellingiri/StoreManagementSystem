using LumenWorks.Framework.IO.Csv;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreManagementSystem
{
    class StoreManagementSystemViewModel : INotifyPropertyChanged
    {

        private bool isExpand;
        public bool IsExpanded
        {
            get
            {
                return isExpand;
            }
            set
            {
                isExpand = value;
                OnPropertyChanged(nameof(IsExpanded));
            }
        }
        private object selectedPage;
        public object SelectedPage
        {
            get
            {
                return selectedPage;
            }
            set
            {
                selectedPage = value;
                OnPropertyChanged(nameof(SelectedPage));
            }
        }
        private ProductDetails productDetails = new ProductDetails();
        public ProductDetails AvailableProducts
        {
            get
            {
                return productDetails;
            }
            set
            {
                productDetails = value;
                OnPropertyChanged(nameof(AvailableProducts));
            }
        }
        public ProductView Productdetails { get; set; }
        public BaseCommand CollapsedTheMenuItems { get; set; }
        public BaseCommand ExpandTheMenuItems { get; set; }
        public BaseCommand NavigateToProductPage { get; set; }
        public StoreManagementSystemViewModel()
        {
            CollapsedTheMenuItems = new BaseCommand(CollapsetheExpanderMethod);
            ExpandTheMenuItems = new BaseCommand(ExpandTheMenuItemsMethod);
            NavigateToProductPage = new BaseCommand(NavigateToProductPageMethod);
            Productdetails = new ProductView();
            GetProdutDetais();
        }
        public void NavigateToProductPageMethod(object obj)
        {
            SelectedPage = Productdetails;
        }
        public void GetProdutDetais()
        {
            try
            {
            var csvTable = new DataTable();
            using (var csvReader = new CsvReader(new StreamReader(System.IO.File.OpenRead(@"D:\CSVFolder\CSVFile.csv")), true))
            {
                csvTable.Load(csvReader);
            }
            for (int i = 0; i < csvTable.Rows.Count; i++)
            {
                //searchParameters.Add(new SearchParameters { FirstName = csvTable.Rows[i][0].ToString(), LastName = csvTable.Rows[i][1].ToString(), Email = csvTable.Rows[i][2].ToString() });
            }
            }
            catch (Exception e) { }
        }
        public void CollapsetheExpanderMethod(object obj)
        {
            IsExpanded = false;
        }
        public void ExpandTheMenuItemsMethod(object obj)
        {
            IsExpanded = true;
        }


        #region PropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        #endregion
    }
}
