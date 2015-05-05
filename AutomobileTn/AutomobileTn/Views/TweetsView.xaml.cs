using AutomobileTn.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace AutomobileTn.Views
{
    public partial class TweetsView : ContentPage
    {
        public TweetsView()
        {
            InitializeComponent();

            var tweetsViewModel = new TweetsViewModel();

            BindingContext = tweetsViewModel;

            var refresh = new ToolbarItem
            {
                Icon = "refresh.png",
                Text = "Refresh",
                Command = new Command(() =>
                {
                    tweetsViewModel.RefreshCommand.Execute(null);
                })
            };

            ToolbarItems.Add(refresh);
        }
    }
}
