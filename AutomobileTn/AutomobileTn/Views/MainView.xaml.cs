using AutomobileTn.ViewModels;

using Xamarin.Forms;

namespace AutomobileTn.Views
{
	public partial class MainView : ContentPage
	{
		public MainView()
		{
			InitializeComponent();

			BindingContext = new MainViewModel();
		}
	}
}
