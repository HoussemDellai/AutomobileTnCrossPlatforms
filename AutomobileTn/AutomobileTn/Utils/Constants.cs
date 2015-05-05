using System;
using System.Collections.Generic;
using System.Text;

namespace AutomobileTn.Utils
{
	public class Constants
	{
		public static List<string> CarsManifacturers
		{
			get
			{
				return new List<string>
			   {
				   "Alfa Romeo",
				   "Audi",
				   "BMW",
				   "Chevrolet",
				   "Citroën",
				   "Dacia",
				   "Fiat",
				   "Ford",
				   "Hyundai",
				   "Jaguar",
				   "KIA",
				   "Lancia",
				   "Land Rover",
				   "Mahindra",
				   "Mazda",
				   "Mercedes",
				   "Mini",
				   "Mitsubishi",
				   "Nissan",
				   "Opel",
				   "Peugeot",
				   "Renault",
				   "Seat",
				   "Ssangyong",
				   "Toyota",
				   "Volkswagen",
				   "Volvo",
			   };
			}
		}

		public static string VideosLink
		{
			get
			{
				return "http://houssemdellai-services.azurewebsites.net/api/youtube/AutomobileTn/20";
			}
		}
		public static string TweetsLink
		{
			get
			{
				return "http://houssemdellai-services.azurewebsites.net/api/tweets/AutomobileTN/AutomobileTN/20";
			}
		}
	}
}
