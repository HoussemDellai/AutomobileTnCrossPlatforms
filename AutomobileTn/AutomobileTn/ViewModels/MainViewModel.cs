using AutomobileTn.Models;
using AutomobileTn.Services;
using AutomobileTn.Utils;
using System;
using System.Collections.Generic;
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

		private List<Car> _carsList;

		public List<Car> CarsList
		{
			get { return _carsList; }
			set
			{
				_carsList = value;
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

			CarsList = CarsFormatter.GetFormattedCarsCollection(carsList);
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
