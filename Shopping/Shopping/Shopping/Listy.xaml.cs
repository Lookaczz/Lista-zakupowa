using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Shopping
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Listy : ContentPage
	{
        public ObservableCollection<string> Items { get; set; }
		public Listy ()
		{
            Title = "Moje listy";
            InitializeComponent();
            listView.ItemsSource = Data_Listy.ListOfList;          
        }


        public void ListView_ItemClick(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                var selection = e.SelectedItem as List;
                int id = selection.ID_List;
                ((ListView)sender).SelectedItem = null;
                Navigation.PushAsync(new Lista1(id));
            }        
        }
    }
}