using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eProdaja.Mobile.ViewModels;
using eProdaja.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace eProdaja.Mobile.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ProizvodiPage : ContentPage
	{
	    private ProizvodiViewModel model = null;
		public ProizvodiPage ()
		{
			InitializeComponent ();
		    BindingContext = model = new ProizvodiViewModel();
		}

	    protected async override void OnAppearing()
	    {
	        base.OnAppearing();
            await model.Init();
	    }

	    private async void ListView_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
	    {
	        var item = e.SelectedItem as Proizvod;

	        await Navigation.PushAsync( new ProizvodDetailPage(item));
	    }
	}
}