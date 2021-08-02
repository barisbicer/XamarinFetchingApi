using App1.Helper;
using App1.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App1.ViewModel
{
    public class OrdersViewModel : INotifyPropertyChanged
    {
        #region Fields

        WebAPIService webAPIService;
        public event PropertyChangedEventHandler PropertyChanged;
        private ObservableCollection<FlyList> items;

        #endregion

        #region Properties
        public ObservableCollection<FlyList> Items
        {
            get
            {
                return items;
            }
            set
            {
                items = value;
                RaisepropertyChanged("Items");
            }
        }
        #endregion

        #region Constructor
        public OrdersViewModel()
        {
            webAPIService = new WebAPIService();
            //Item source which needs to be displayed on the list view.
            Items = new ObservableCollection<FlyList>();
            GetDataFromWebAPI();
        }
        #endregion

        #region Methods 
        async void GetDataFromWebAPI()
        {
            Items = await webAPIService.RefreshDataAsync();
            if(Items != null)
            {
                items = Items;
            }
            Console.Out.WriteLine("Display filenames to a file:");
        }
        void RaisepropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
