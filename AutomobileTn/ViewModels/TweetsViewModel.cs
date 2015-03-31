using AutomobileTn.Models;
using AutomobileTn.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AutomobileTn.ViewModels
{
	public class TweetsViewModel : INotifyPropertyChanged
	{

		private List<Tweet> _tweetsList;

		public List<Tweet> TweetsList
		{
			get
			{
				return _tweetsList;
			}
			set
			{
				_tweetsList = value;
				OnPropertyChanged();
			}
		}

		public TweetsViewModel()
		{
			DowloadDataAsync();
		}

		private async Task DowloadDataAsync()
		{
			var tweetsSrvice = new TweetsService();

			TweetsList = await tweetsSrvice.GetTweetsAsync();
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
