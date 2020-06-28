using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyUnoFromXF
{
    public partial class App : Application
    {
        public App()
        {
            //Xamarin.Forms.Forms.SetFlags("CarouselView_Experimental");
            Xamarin.Forms.Device.SetFlags(new String[] { "CarouselView_Experimental" });

            InitializeComponent();

            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
