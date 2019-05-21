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
	public partial class ProizvodDetailPage : ContentPage
	{
        ProizvodDetailViewModel viewModel = null;
		public ProizvodDetailPage (Proizvod proizvod)
		{
			InitializeComponent ();
		    BindingContext = viewModel = new ProizvodDetailViewModel()
		    {
		        Proizvod = proizvod
		    };
		}
	}
}