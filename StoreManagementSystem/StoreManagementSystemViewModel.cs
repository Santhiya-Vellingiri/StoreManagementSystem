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
                ExpanderWidth = isExpand ? 150 : 25;
                OnPropertyChanged(nameof(IsExpanded));
            }
        }
         private int expanderWidth=25;
        public int ExpanderWidth
        {
            get
            {
                return expanderWidth;
            }
            set
            {
                expanderWidth = value;
                OnPropertyChanged(nameof(ExpanderWidth));
            }
        }
        public BaseCommand CollapsedTheMenuItems { get; set; }
        public StoreManagementSystemViewModel()
        {
            CollapsedTheMenuItems = new BaseCommand(CollapsetheExpanderMethod);
        }
        public void CollapsetheExpanderMethod(object obj)
        {
            IsExpanded = false;
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
