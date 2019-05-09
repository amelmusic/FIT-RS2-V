using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using eProdaja.Model;
using Xamarin.Forms;

namespace eProdaja.Mobile.ViewModels
{
    public class ProizvodiViewModel
    {
        private readonly APIService _proizvodiService = new APIService("Proizvod");

        public ProizvodiViewModel()
        {
            InitCommand = new Command(async () => await Init());
        }
        public ObservableCollection<Proizvod> ProizvodiList { get; set; } = new ObservableCollection<Proizvod>();

        public ICommand InitCommand { get; set; }

        public async Task Init()
        {
            var list = await _proizvodiService.Get<IEnumerable<Proizvod>>(null);

            ProizvodiList.Clear();
            foreach (var proizvod in list)
            {
                ProizvodiList.Add(proizvod);
            }
        }
    }
}
