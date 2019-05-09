using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eProdaja.Mobile.ViewModels;
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
    }
}