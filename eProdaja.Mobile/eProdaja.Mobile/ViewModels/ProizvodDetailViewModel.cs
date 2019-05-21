using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;
using eProdaja.Mobile.Services;
using eProdaja.Model;
using Xamarin.Forms;

namespace eProdaja.Mobile.ViewModels
{
    public class ProizvodDetailViewModel : BaseViewModel
    {
        public ProizvodDetailViewModel()
        {
            KolicinaIncrementCommand = new Command(() => Kolicina += 1);
            KupiCommand = new Command(Kupi);
        }
        public Proizvod Proizvod { get; set; }

        decimal _kolicina = 0;
        public decimal Kolicina
        {
            get { return _kolicina; }
            set { SetProperty(ref _kolicina, value); }
        }

        public ICommand KolicinaIncrementCommand { get; set; }

        public ICommand KupiCommand { get; set; }

        private void Kupi()
        {
            if (CartService.Cart.ContainsKey(Proizvod.ProizvodId))
            {
                CartService.Cart.Remove(Proizvod.ProizvodId);
            }

            CartService.Cart.Add(Proizvod.ProizvodId, this);
        }

    }
}
