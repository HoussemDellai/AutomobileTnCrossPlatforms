using AutomobileTn.ViewModels;
using Xamarin.Forms;

namespace AutomobileTn.Views
{
    public partial class SearchCarsView : ContentPage
    {
        public SearchCarsView()
        {
            InitializeComponent();

            var mainViewModel = new CarsViewModel();

            BindingContext = mainViewModel;

            var refresh = new ToolbarItem
            {
                Icon = "refresh.png",
                Text = "Refresh",
                Command = new Command(() =>
                {
                    mainViewModel.RefreshCommand.Execute(null);
                })
            };

            ToolbarItems.Add(refresh);
        }
    }
}
