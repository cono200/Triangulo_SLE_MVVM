using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Triangulo_SLE_MVVM.VistaModelo;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Triangulo_SLE_MVVM.Vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class VTriangulo : ContentPage
    {
        public VTriangulo()
        {
            InitializeComponent();
            BindingContext = new VMTriangulo(Navigation);
        }
    }
}