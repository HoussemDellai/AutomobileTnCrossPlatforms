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
			get { return _carsList; }
			set
			{
				_carsList = value;
				OnPropertyChanged();
			}
		}

		private ObservableCollection<Grouping<string, Car>> _carsGrouped;

		public ObservableCollection<Grouping<string, Car>> CarsGrouped
		{
			get { return _carsGrouped; }
			set
			{
				_carsGrouped = value;
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
			var dataServices = new CarsServices();
			var carsList = await dataServices.GetCarsCollectionAsync();

			var cars = CarsFormatter.GetFormattedCarsCollection(carsList);

			CarsList = new ObservableCollection<Car>();

			foreach (var car in cars)
			{
				CarsList.Add(car);
			}

			//Use linq to sorty our monkeys by name and then group them by the new name sort property 
			var sorted = from car
						 in CarsList
						 orderby car.Manifacturer
						 group car
						 by car.Manifacturer
						 into carsGroup
						 select new Grouping<string, Car>(carsGroup.Key, carsGroup);

			//create a new collection of groups 
			CarsGrouped = new ObservableCollection<Grouping<string, Car>>(sorted);
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
