using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using eProdaja.Mobile.Views;
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
            NavigateToNarudzbaCommand = new Command(async () => await NavigateToNarudzba());
        }
        public ObservableCollection<Proizvod> ProizvodiList { get; set; } = new ObservableCollection<Proizvod>();
        public ObservableCollection<VrsteProizvoda> VrsteProizvodaList { get; set; } = new ObservableCollection<VrsteProizvoda>();

        VrsteProizvoda _selctedVrstaProizvoda = null;
        public VrsteProizvoda SelectedVrstaProizvoda
        {
            get { return _selctedVrstaProizvoda; }
            set
            {
                SetProperty(ref _selctedVrstaProizvoda, value);
                InitCommand.Execute(null);
            }
        }

        Proizvod _selectedProizvod = null;
        public Proizvod SelectedProizvod
        {
            get { return _selectedProizvod; }
            set
            {
                SetProperty(ref _selectedProizvod, value);
                if (_selectedProizvod != null)
                {
                    NavigateToNarudzbaCommand.Execute(null);
                }
            }
        }


        public ICommand NavigateToNarudzbaCommand { get; set; }

        public ICommand InitCommand { get; set; }

        public async Task Init()
        {
            if (VrsteProizvodaList.Count == 0)
            {
                var vrste = await _vrsteProizvodaService.Get<List<VrsteProizvoda>>(null);
                foreach (var vrsta in vrste)
                {
                    VrsteProizvodaList.Add(vrsta);
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

        public async Task NavigateToNarudzba()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new NarudzbaPage());
        }
    }
}
