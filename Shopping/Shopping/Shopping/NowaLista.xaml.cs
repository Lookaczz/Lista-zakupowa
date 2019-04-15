using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Collections.ObjectModel;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Shopping
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class NowaLista : ContentPage
	{
		public NowaLista ()
		{
			InitializeComponent ();
            Title = "Nowa lista";
        }
        public static string ListName;
        
        private void Okienko(object sender, EventArgs e)
        {
            ListName = name.Text;
            int i = 1;
            while (i<=10)
            {
                if (Data_Listy.ListOfList.Any(p => p.ID_List == i))
                {
                    ++i;
                }
                else
                {
                    Data_Listy.ListOfList.Add(new List(i, ListName));
                    break;
                }
            }
        }
    }
}