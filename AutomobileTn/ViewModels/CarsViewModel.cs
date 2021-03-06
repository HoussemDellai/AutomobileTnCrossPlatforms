﻿using AutomobileTn.Models;
using AutomobileTn.Services;
using AutomobileTn.UI;
using AutomobileTn.Utils;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace AutomobileTn.ViewModels
{
    /// <summary>
    /// ViewModel used to display cars on the CarsView page and SearchView page.
    /// </summary>
    public class CarsViewModel : INotifyPropertyChanged
    {

        private ObservableCollection<Car> _carsList;
        public ObservableCollection<Car> CarsList
        {
            get
            {
                return _carsList;
            }
            set
            {
                _carsList = value;
                OnPropertyChanged();
            }
        }

        private List<Car> _filteredCarsCollection;
        public List<Car> FilteredCarsCollection
        {
            get
            { return _filteredCarsCollection; }
            set
            {
                _filteredCarsCollection = value;
                OnPropertyChanged();
            }
        }

        private string _searchedKeyword = string.Empty;
        public string SearchedKeyword
        {
            get
            {
                return _searchedKeyword;
            }
            set
            {
                _searchedKeyword = value;
                OnPropertyChanged();
            }
        }

        private ObservableCollection<Grouping<string, Car>> _carsGrouped;
        public ObservableCollection<Grouping<string, Car>> CarsGrouped
        {
            get
            {
                return _carsGrouped;
            }
            set
            {
                _carsGrouped = value;
                OnPropertyChanged();
            }
        }

        private bool _isBusy;
        public bool IsBusy
        {
            get
            {
                return _isBusy;
            }
            set
            {
                _isBusy = value;
                OnPropertyChanged();
            }
        }


        private ICommand _filterCarsByPriceCommand;
        public ICommand FilterCarsByPriceCommand
        {
            get
            {
                if (_filterCarsByPriceCommand == null)
                {
                    _filterCarsByPriceCommand = new RelayCommandGeneric<int>(price =>
                    {

                        if (_carsList == null)
                        {
                            return;
                        }

                        var priceMarge = price / 10;

                        FilteredCarsCollection =
                            _carsList.Where(car => car.Price >= price - priceMarge
                                                   && car.Price <= price + priceMarge).ToList();
                    });
                }
                return _filterCarsByPriceCommand;
            }
        }

        public RelayCommandGeneric<string> FilterCarsCollectionCommand
        {
            get
            {
                return new RelayCommandGeneric<string>(filter =>
                {
                    FilteredCarsCollection = CarsList.Where(car => car.Manifacturer == filter).ToList();
                });
            }
        }

        public ICommand RefreshCommand { get; set; }
        
        public CarsViewModel()
        {
            RefreshCommand = new RelayCommand(async () => await DownloadDataAsync());
            
            DownloadDataAsync();
        }

        private async Task DownloadDataAsync()
        {
            IsBusy = true;

            var dataServices = new CarsServices();

            var carsList = await dataServices.GetCarsCollectionAsync();

            var cars = CarsFormatter.GetFormattedCarsCollection(carsList);

            CarsList = new ObservableCollection<Car>();

            foreach (var car in cars)
            {
                CarsList.Add(car);
            }

            //Use linq to sorty our monkeys by name and then group them by the new name sort property 
            var sortedCarsList = from car
                                 in CarsList
                                 group car
                                 by car.Manifacturer
                                 into carsGroup
                                 select new Grouping<string, Car>(carsGroup.Key, carsGroup);

            //create a new collection of groups 
            CarsGrouped = new ObservableCollection<Grouping<string, Car>>(sortedCarsList.OrderBy(grouping => grouping.Key));

            IsBusy = false;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
