using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomobileTn.ViewModels;

using Xamarin.Forms;

namespace AutomobileTn.Views
{
    public partial class CarsView : ContentPage
    {
        public CarsView()
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
