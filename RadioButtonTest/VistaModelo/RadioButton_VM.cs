using ConsumirAPIconXamarin.VistaModelo;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace RadioButtonTest.VistaModelo
{
    //https://stackoverflow.com/questions/66309567/binding-ischecked-property-with-a-radio-button-group-in-xamarin-mvvm
    public class RadioButton_VM: BaseViewModel
    {
        private string total;
        public string Total
        {
            get { return total; }
            set
            {
                total = value;
                OnPropertyChanged();
            }
        }

        private bool yearChecked;
        public bool YearChecked
        {
            get { return yearChecked; }
            set
            {
                yearChecked = value;
                OnPropertyChanged();
            }
        }
        private bool monthChecked;
        public bool MonthChecked
        {
            get { return monthChecked; }
            set
            {
                monthChecked = value;
                OnPropertyChanged();
            }
        }
        private bool weekChecked;
        public bool WeekChecked
        {
            get { return weekChecked; }
            set
            {
                weekChecked = value;
                OnPropertyChanged();
            }
        }
        public void Calcular()
        {
            if (YearChecked == true) {
                Total = "$10"; 
            }
            if (monthChecked == true) { Total = "$20"; }
            if (weekChecked == true) { Total = "30"; }
            else { total = "$50"; }
        }
        public RadioButton_VM(INavigation navigation)
        {
            Navigation = navigation;
        }

        public ICommand CalcularCommand => new Command(Calcular);
    }
}
