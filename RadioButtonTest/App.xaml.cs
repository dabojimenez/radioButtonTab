using RadioButtonTest.Vista;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RadioButtonTest
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new RadioButton_V();
            MainPage = new TabPageTrigger_V();
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
