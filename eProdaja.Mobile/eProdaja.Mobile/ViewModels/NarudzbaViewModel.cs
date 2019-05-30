using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace eProdaja.Mobile.ViewModels
{
    public class NarudzbaViewModel
    {
        public ObservableCollection<ProizvodDetailViewModel> NarudzbaList { get; set; } = new ObservableCollection<ProizvodDetailViewModel>();

        public void Init()
        {
            NarudzbaList.Clear();

            foreach (var cartValue in CartService.Cart.Values)
            {
                NarudzbaList.Add(cartValue);
            }
        }
    }
}
