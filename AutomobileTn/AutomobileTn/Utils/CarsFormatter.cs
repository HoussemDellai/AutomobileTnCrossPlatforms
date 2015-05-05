using System;
using System.Collections.Generic;
using System.Text;
using AutomobileTn.Models;

namespace AutomobileTn.Utils
{
	public class CarsFormatter
	{

		public static List<Car> GetFormattedCarsCollection(List<Car> carsCollection)
		{

			foreach (var car in carsCollection)
			{
				car.Manifacturer = GetManifacturerFromTitle(car.Title);
				car.Model = GetModelFromTitle(car.Title);
				car.Price = GetPriceFromDescription(car.Description);
			}

			return carsCollection;
		}

		private static int GetPriceFromDescription(string carDescription)
		{
			var priceString = carDescription.Replace("Prix : A partir de ", "").Replace(" DT<br>", "").Replace(" ", "");

			return Convert.ToInt32(priceString);
		}

		private static string GetModelFromTitle(string carTitle)
		{
			foreach (var carsManifacturer in Constants.CarsManifacturers)
			{
				if (carTitle.Contains(carsManifacturer))
				{
					return carTitle.Replace(carsManifacturer + " ", "");
				}
			}

			return carTitle;
		}

		private static string GetManifacturerFromTitle(string carTitle)
		{
			foreach (var carsManifacturer in Constants.CarsManifacturers)
			{
				if (carTitle.Contains(carsManifacturer))
				{
					return carsManifacturer;
				}
			}

			return carTitle;
		}
	}
}
