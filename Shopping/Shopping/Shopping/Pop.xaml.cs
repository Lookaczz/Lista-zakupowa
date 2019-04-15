using Android.Views;
using Rg.Plugins.Popup.Pages;
using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Shopping
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Pop : PopupPage
    {
        public int idListy { get; set; }
        public static string productName;
        public static string productQuantity;

        public Pop(int id_listy)
        {
            InitializeComponent();
            idListy = id_listy;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            int id_listy = idListy;
            productName = Product_Name.Text;
            productQuantity = Product_Quantity.Text;

            int id_produktu = 1;
            while (id_produktu <= 100)
            {
                if (Data.ProductList.Any(p => p.ID_Product == id_produktu))
                {
                    ++id_produktu;
                }
                else
                {
                    Data.ProductList.Add(new Product(id_listy,id_produktu,productName,productQuantity,true,false));
                    PopupNavigation.Instance.PopAsync();
                    break;
                }
            }
            Navigation.PushAsync(new Lista1(idListy));
        }
    }		
}
