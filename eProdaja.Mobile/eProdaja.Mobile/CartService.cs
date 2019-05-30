using System;
using System.Collections.Generic;
using System.Text;
using eProdaja.Mobile.ViewModels;

namespace eProdaja.Mobile
{
    public static class CartService
    {
        public static Dictionary<int, ProizvodDetailViewModel> Cart { get; set; } = new Dictionary<int, ProizvodDetailViewModel>();
    }
}
