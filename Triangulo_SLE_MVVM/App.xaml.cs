using System;
using Triangulo_SLE_MVVM.Vistas;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Triangulo_SLE_MVVM
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new VTriangulo();
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
