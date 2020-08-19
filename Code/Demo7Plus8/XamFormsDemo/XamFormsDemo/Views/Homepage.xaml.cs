using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamFormsDemo.Models;
using XamFormsDemo.Services;

namespace XamFormsDemo.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Homepage : ContentPage
    {
        Place mock => DependencyService.Get<Place>();

        public Homepage()
        {
            InitializeComponent();
            getData();
        }

        public async void getData()
        {
            List<PlaceModel> newPlace = new List<PlaceModel>();

            newPlace = await mock.getPlaces();

            myPlaces.ItemsSource = newPlace;
        }

        private void MyPlaces_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //caster value som Placemodel
            PlaceModel myValue = e.CurrentSelection.FirstOrDefault() as PlaceModel;

            Application.Current.MainPage.Navigation.PushAsync(new MapPage(myValue));

        }
    }
}