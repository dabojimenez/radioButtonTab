using ConsumirAPIconXamarin.VistaModelo;
using RadioButtonTest.Datos;
using RadioButtonTest.Modelos;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace RadioButtonTest.VistaModelo
{
    public class TabPageTrigger_VM: BaseViewModel
    {
        //https://stackoverflow.com/questions/47397858/xamarin-dynamic-tabbed-page
        //https://learn.microsoft.com/en-us/xamarin/xamarin-forms/app-fundamentals/triggers
        //https://learn.microsoft.com/en-us/xamarin/xamarin-forms/app-fundamentals/navigation/tabbed-page
        #region VARIABLES
        ObservableCollection<Categoria> _ListaCategorias;
        ObservableCollection<Plato> _ListaPlatos;
        #endregion
        #region CONSTRUCTOR
        public TabPageTrigger_VM(INavigation navigation)
        {
            Navigation = navigation;
            MostrarCategorias();
        }
        #endregion
        #region OBJETOS
        public ObservableCollection<Categoria> ListaCategorias
        {
            get { return _ListaCategorias; }
            set { SetValue(ref _ListaCategorias, value); }
        }
        public ObservableCollection<Plato> ListaPlatos
        {
            get { return _ListaPlatos; }
            set { SetValue(ref _ListaPlatos, value); }
        }
        #endregion

        #region PROCESOS
        public async Task ProcesoAsyncrono()
        {

        }
        public void MostrarCategorias()
        {
            ListaCategorias = new ObservableCollection<Categoria>(CategoriaDataBase.SelectCategoria());
        }
        public void Seleccionar(Categoria categoria)
        {
            int index = ListaCategorias.ToList().FindIndex(
                    c => c.IdCategoria == categoria.IdCategoria
                );
            if (index > -1)
            {
                //ListaCategorias[index].
                ListaPlatos = new ObservableCollection<Plato>(CategoriaDataBase.SelectPlatos().ToList().Where(
                        p => p.IdCategoria == categoria.IdCategoria
                    ));
            }
        }
        #endregion
        #region COMANDOS
        public ICommand ProcesoAsyncommand => new Command(async () => await ProcesoAsyncrono());
        public ICommand ProcesoSimpcommand => new Command(MostrarCategorias);
        public ICommand SeleccionarCommand => new Command<Categoria>((c) => Seleccionar(c));
        //public ICommand AgregarCodigoBarrasCommand => new Command(AgregarCodigoBarras);

        #endregion
    }
}
