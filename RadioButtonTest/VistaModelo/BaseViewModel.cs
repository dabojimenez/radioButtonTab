﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using Xamarin.Essentials;
namespace ConsumirAPIconXamarin.VistaModelo
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        public INavigation Navigation;

        public event PropertyChangedEventHandler PropertyChanged;

        private ImageSource foto;
        public ImageSource Foto
        {
            get { return foto; }
            set
            {
                foto = value;
                OnPropertyChanged();
            }
        }

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            //PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            var handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public async Task DisplayAlert(string title, string message, string cancel)
        {
            await Application.Current.MainPage.DisplayAlert(title, message, cancel);
        }

        public async Task<bool> DisplayAlert(string title, string message, string accept, string cancel)
        {
            return await Application.Current.MainPage.DisplayAlert(title, message, accept, cancel);
        }

        protected bool SetProperty<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
            {
                return false;
            }

            field = value;
            OnPropertyChanged(propertyName);

            return true;
        }

        private string _title;
        public string Title
        {
            get { return _title; }
            set
            {
                SetProperty(ref _title, value);
            }
        }

        private bool _isBusy;
        public bool IsBusy
        {
            get { return _isBusy; }
            set
            {
                SetProperty(ref _isBusy, value);
            }
        }
        protected void SetValue<T>(ref T backingFieled, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(backingFieled, value))

            {

                return;

            }

            backingFieled = value;

            OnPropertyChanged(propertyName);
        }
        #region ValidarInternet
        bool _conectado;
        bool _sinconexion;
        public bool Conectado
        {
            get { return this._conectado; }
            set
            {
                SetValue(ref this._conectado, value);
            }
        }
        public bool Sinconexion
        {
            get { return this._sinconexion; }
            set
            {
                SetValue(ref this._sinconexion, value);
            }
        }
        public void ValidarConexionInternet()
        {
            //se ejecutara cada segundo, sin bajar el rendimiento de la palicaicon
            var tiempo = TimeSpan.FromSeconds(1);
            Device.StartTimer(tiempo, () =>
            {
                //ejecutamso en segundo plano, sin bajar el rendimiento d ela aplicacion
                Device.BeginInvokeOnMainThread(() =>
                {
                    ProbarConexion();
                });
                //devolvmeos tru, para que constantemente se este ejecutando
                return true;
            });
        }
        private void ProbarConexion()
        {
            if (Connectivity.NetworkAccess != NetworkAccess.Internet)
            {
                Conectado = false;
                Sinconexion = true;
            }
            else
            {
                Conectado = true;
                Sinconexion = false;
            }
        }
        #endregion

    }
}