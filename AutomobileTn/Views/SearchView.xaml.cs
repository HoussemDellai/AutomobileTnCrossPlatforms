using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomobileTn.ViewModels;
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

        private void PriceSliderOnValueChanged(object sender, ValueChangedEventArgs valueChangedEventArgs)
        {
            //PriceSlider.BackgroundColor = Color.Maroon;
            _carsViewModel.FilterCarsCollectionCommand.Execute("BMW");//valueChangedEventArgs.NewValue);
        }
    }
}
