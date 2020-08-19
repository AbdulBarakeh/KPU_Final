using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamFormsDemo.Services;
using XamFormsDemo.Views;

namespace XamFormsDemo
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<Place>();
            MainPage = new AppShell();
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
