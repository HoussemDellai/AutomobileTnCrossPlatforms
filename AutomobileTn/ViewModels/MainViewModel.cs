using AutomobileTn.Models;
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
    public class MainViewModel : INotifyPropertyChanged
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

        private List<Video> _videosList;
        public List<Video> VideosList
        {
            get
            {
                return _videosList;
            }
            set
            {
                _videosList = value;
                OnPropertyChanged();
            }
        }

        private ObservableCollection<Grouping<string, Car>> _carsGrouped;
        private bool _isBusy;

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

        public ICommand RefreshCommand { get; set; }

        public ICommand SendEmployeeMessageCommand { get; set; }

        public MainViewModel()
        {
            RefreshCommand = new RelayCommand(async () => await DownloadDataAsync());

            SendEmployeeMessageCommand = new RelayCommandGeneric<Car>(SendEmployeeMessage);

            DownloadDataAsync();
        }

        private void SendEmployeeMessage(Car employee)
        {
            //Messenger.Default.Send(employee);
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
            CarsGrouped = new ObservableCollection<Grouping<string, Car>>(sortedCarsList);

            var videosService = new VideosService();
         
            VideosList = await videosService.GetYoutubeVideosAsync();

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
