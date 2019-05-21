using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using eProdaja.Mobile.Services;
using eProdaja.Model;
using Xamarin.Forms;

namespace eProdaja.Mobile.ViewModels
{
    public class NarudzbaViewModel
    {
        public NarudzbaViewModel()
        {
            ZakljuciNarudzbuCommand = new Command(async () => await ZakljuciNarudzbu());
        }

        public ObservableCollection<ProizvodDetailViewModel> ItemList { get; set; } = new ObservableCollection<ProizvodDetailViewModel>();

        public void Init()
        {
            ItemList.Clear();
            var items = CartService.Cart.Values.ToList();
            foreach (var item in items)
            {
                ItemList.Add(item);
            }
        }

        public ICommand ZakljuciNarudzbuCommand { get; set; }

        async Task ZakljuciNarudzbu()
        {
            //TODO: Pozvad servis

        }
    }
}
