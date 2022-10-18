using RadioButtonTest.VistaModelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RadioButtonTest.Vista
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TabPageTrigger_V : ContentPage
    {
        public TabPageTrigger_V()
        {
            InitializeComponent();
            BindingContext = new TabPageTrigger_VM(Navigation);
        }
    }
}