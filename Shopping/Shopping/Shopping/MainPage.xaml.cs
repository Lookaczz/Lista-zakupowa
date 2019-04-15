using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Shopping
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        async void MojeListy_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Listy());
        }

        async void NowaLista_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NowaLista());
        }

        private void Przepisy_Clicked(object sender, EventArgs e)
        {

        }
    }
}
