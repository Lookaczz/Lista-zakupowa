using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Shopping
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            var nevPage = new NavigationPage(new MainPage() { Title = "Moje zakupy" });
            MainPage = nevPage;
            nevPage.BarBackgroundColor = Color.FromRgb(46,47,48);
            nevPage.BarTextColor = Color.White;
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
