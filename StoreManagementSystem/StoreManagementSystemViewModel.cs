using System;
using System.Collections.Generic;
using System.ComponentModel;
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
     
        public BaseCommand CollapsedTheMenuItems { get; set; }
        public BaseCommand ExpandTheMenuItems { get; set; }
        public StoreManagementSystemViewModel()
        {
            CollapsedTheMenuItems = new BaseCommand(CollapsetheExpanderMethod);
            ExpandTheMenuItems = new BaseCommand(ExpandTheMenuItemsMethod);
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
