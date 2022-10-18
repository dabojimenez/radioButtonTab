using RadioButtonTest.VistaModelo;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RadioButtonTest.Vista
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RadioButton_V : ContentPage
    {
        public RadioButton_V()
        {
            InitializeComponent();
            BindingContext = new RadioButton_VM(Navigation);
        }
    }
}