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

            BindingContext = new TweetsViewModel();
        }
    }
}
