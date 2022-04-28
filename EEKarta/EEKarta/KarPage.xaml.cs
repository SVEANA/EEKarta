using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EEKarta
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class KarPage : ContentPage
    {
        public KarPage()
        {
            InitializeComponent();
        }

        //private async void Button_Clicked(object sender, EventArgs e)
       // {
           // var options = new KarLaunchOptions { Name = "Я тут" };
           // try
           // {


               // var Location = await Xamarin.Essentials.Geolocation.GetLastKnownLocationAsync();
               // if (Location == null)
               // {
                  //  Location = await Xamarin.Essentials.Geolocation.GetLocationAsync(new Xamarin.Essentials.GeolocationRequest
                   // {
                       // DesiredAccuracy = Xamarin.Essentials.GeolocationAccuracy.Medium,
                       // Timeout = TimeSpan.FromSeconds(30)
                  //  });
               // }
               // await Xamarin.Essentials.Map.OpenAsync(Location);
           // }
           // catch (Exception)
           // {

           // }
       // }

    }
}