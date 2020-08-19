using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Maps;
using Xamarin.Forms.Xaml;
using XamFormsDemo.Models;

namespace XamFormsDemo.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MapPage : ContentPage
    {
        PlaceModel myValue = new PlaceModel();

        public MapPage(PlaceModel place)
        {
            InitializeComponent();
            myValue = place;

            Position pos = new Position(myValue.Latitude, myValue.Longitude);
            MapSpan mapSpan = new MapSpan(pos, 0.1, 0.1);
            Map MyMap = new Map(mapSpan);

            //MapContainer = new StackLayout();

            Pin pin = new Pin
            {
                Position = new Position(myValue.Latitude, myValue.Longitude),
                Label = myValue.NickName,
                Address = myValue.Streetname + myValue.Streetnumber + myValue.Houseletter,

            };

            MyMap.IsShowingUser = true;

            MyMap.Pins.Add(pin);

            MapContainer.Children.Add(MyMap);
        }
    }
}