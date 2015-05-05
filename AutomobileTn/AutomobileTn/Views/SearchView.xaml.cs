using AutomobileTn.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace AutomobileTn.Views
{
    public partial class SearchView : ContentPage
    {

        private CarsViewModel _carsViewModel = new CarsViewModel();

        public SearchView()
        {
            InitializeComponent();

            BindingContext = _carsViewModel;

            PriceSlider.ValueChanged += PriceSliderOnValueChanged;
        }

        private void PriceSliderOnValueChanged(object sender, ValueChangedEventArgs e)
        {
            var value = e.NewValue;

            var price = (int)value * 34000;

            PriceLabel.Text = price + " DT";

            _carsViewModel.FilterCarsByPriceCommand.Execute(price);
        }
    }
}
