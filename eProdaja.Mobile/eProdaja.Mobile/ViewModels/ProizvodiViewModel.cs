using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using eProdaja.Model;
using eProdaja.Model.Requests;
using Xamarin.Forms;

namespace eProdaja.Mobile.ViewModels
{
    public class ProizvodiViewModel : BaseViewModel
    {
        private readonly APIService _proizvodiService = new APIService("Proizvod");
        private readonly APIService _vrsteProizvodaService = new APIService("VrsteProizvoda");

        public ProizvodiViewModel()
        {
            InitCommand = new Command(async () => await Init());
        }
        public ObservableCollection<Proizvod> ProizvodiList { get; set; } = new ObservableCollection<Proizvod>();
        public ObservableCollection<VrsteProizvoda> VrsteProizvodaList { get; set; } = new ObservableCollection<VrsteProizvoda>();
        VrsteProizvoda _selectedVrstaProizvoda = null;

        public  VrsteProizvoda SelectedVrstaProizvoda
        {
            get { return _selectedVrstaProizvoda; }
            set
            {
                SetProperty(ref _selectedVrstaProizvoda, value);
                if (value != null)
                {
                    InitCommand.Execute(null);
                }
                
            }
        }


        public ICommand InitCommand { get; set; }

        public async Task Init()
        {
            if (VrsteProizvodaList.Count == 0)
            {
                var vrsteProizvodaList = await _vrsteProizvodaService.Get<List<VrsteProizvoda>>(null);

                foreach (var vrsteProizvoda in vrsteProizvodaList)
                {
                    VrsteProizvodaList.Add(vrsteProizvoda);
                }
            }

            if (SelectedVrstaProizvoda != null)
            {
                ProizvodSearchRequest search = new ProizvodSearchRequest();
                search.VrstaId = SelectedVrstaProizvoda.VrstaId;

                var list = await _proizvodiService.Get<IEnumerable<Proizvod>>(search);

                ProizvodiList.Clear();
                foreach (var proizvod in list)
                {
                    ProizvodiList.Add(proizvod);
                }
            }

            
        }
    }
}
