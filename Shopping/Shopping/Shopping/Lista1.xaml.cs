using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Diagnostics;
using Rg.Plugins.Popup;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Rg.Plugins.Popup.Services;
using System.Collections;

namespace Shopping
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Lista1 : ContentPage
    {
        public int idListy { get; set; }
        public Lista1(int id_listy)
        {
            idListy = id_listy;
            Title = "Moje listy";
            InitializeComponent();
            IEnumerable<Product> productID = Data.ProductList.Where(x => x.ID_List == id_listy);
            listView.ItemsSource = productID;
        }

        public void ListView_ItemClick(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                var selection = e.SelectedItem as Product;
                string id = Convert.ToString(selection.ID_List);
                DisplayAlert("You selected", id, "OK");
                ((ListView)sender).SelectedItem = null;
            } 
        }


        private void Button_Clicked(object sender, SelectedItemChangedEventArgs e)
        {
            int id_listy = idListy;
            PopupNavigation.Instance.PushAsync(new Pop(id_listy));
        }
    }
}

