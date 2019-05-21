using System;
using System.Collections.Generic;
using System.Text;
using eProdaja.Mobile.ViewModels;
using eProdaja.Model;

namespace eProdaja.Mobile.Services
{
    public static class CartService
    {
        public static Dictionary<int, ProizvodDetailViewModel> Cart = new Dictionary<int, ProizvodDetailViewModel>();
    }
}
