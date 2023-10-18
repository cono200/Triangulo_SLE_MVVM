using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Triangulo_SLE_MVVM.VistaModelo
{
    public  class VMTriangulo : BaseViewModel
    {

        #region VARIABLES
        string  _TipoTriangulo;
        string _DudandoTriangulo;
        double _Altura;
        double _Base;
        double _Resultado;
        double _PrimerLado;
        double _SegundoLado;
        string _tipoTrianguloImagen;

        #endregion
        #region CONTRUCTOR
        public VMTriangulo(INavigation navigation)
        {
            Navigation = navigation;
        }
        #endregion
        #region OBJETOS

        public string TipoTriangulo
        {
            get { return _TipoTriangulo; }
            set { SetValue(ref _TipoTriangulo, value); }
        }

        public string DudandoTriangulo
        {
            get { return _DudandoTriangulo; }
            set { SetValue(ref _DudandoTriangulo, value); }
        }

        public double Altura
        {
            get { return _Altura; }
            set { SetValue(ref _Altura, value); }
        }

        public double PrimerLado
        {
            get { return _PrimerLado; }
            set { SetValue(ref _PrimerLado, value); }
        }

        public double SegundoLado
        {
            get { return _SegundoLado; }
            set { SetValue(ref _SegundoLado, value); }
        }

        public double Base
        {
            get { return _Base; }
            set { SetValue(ref _Base, value); }
        }

        public double Resultado
        {
            get { return _Resultado; }
            set { SetValue(ref _Resultado, value); }
        }

        public string TipoTrianguloImagen
        {
            get { return _tipoTrianguloImagen; }
            set { SetValue(ref _tipoTrianguloImagen, value); }
        }

        #endregion
        #region PROCESOS

        public async Task ProcesoAsyncrono()
        {

        }

        public void  TrianguloCalculo(double b, double a)
        {
            Resultado = (a * b / 2);
        }

        public void  BtnTrianguloCalculo()
        {
            TrianguloCalculo(Base,Altura);
            if (((PrimerLado + SegundoLado) < Base || (Base + PrimerLado) < SegundoLado || (Base + SegundoLado) < PrimerLado))
            {
                TipoTriangulo = "No es un triangulo karnal";
                //DisplayAlert("Su respuesta es", tipoTriangulo, "Cerrar");
            }
            else
            {
                if (Base == PrimerLado && Base == SegundoLado)

                {
                    TipoTriangulo = "El triangulo es Equilatero";
                    TipoTrianguloImagen = "Equilatero.jpg";

                    /*imgEquilatero.IsVisible = true;
                    imgEscaleno.IsVisible = false;
                    imgIsoseles.IsVisible = false;*/


                }
                else if (Base != PrimerLado && PrimerLado != SegundoLado)

                {
                    TipoTriangulo = "El triangulo  es Escaleno";
                    TipoTrianguloImagen = "Equilatero.jpg";

                    /*imgEscaleno.IsVisible = true;
                    imgIsoseles.IsVisible = false;
                    imgEquilatero.IsVisible = false;
                    */


                }
                else

                {
                    TipoTriangulo = "El triangulo  es Isoceles";
                    TipoTrianguloImagen = "isoseles.jpg";

                    /*imgIsoseles.IsVisible = true;
                    imgEquilatero.IsVisible = false;
                    imgEscaleno.IsVisible = false;
                    */


                }
            }

            DisplayAlert("", TipoTriangulo, "Salir");



        }

        #endregion

        #region COMANDOS
        public ICommand ProcesoAsyncommand => new Command(async () => await ProcesoAsyncrono());
        public ICommand Triangulocommand => new Command(BtnTrianguloCalculo);
        #endregion








    }
}
