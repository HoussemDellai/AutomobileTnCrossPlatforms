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

		    carsCollection = GetFormattedModelsCarsCollection(carsCollection);

			return carsCollection;
		}

        /// <summary>
        /// Removes the Manufacturer name from the Model name of each car.
        /// </summary>
        /// <param name="cars"></param>
        /// <returns></returns>
	    private static List<Car> GetFormattedModelsCarsCollection(List<Car> cars)
	    {
	        foreach (var car in cars)
	        {
	            if (car.Manifacturer == "Skoda Octavia")
	            {
	                car.Manifacturer = "Skoda";
	                car.Model = "Octavia";
	            }
                if (car.Manifacturer == "Skoda Rapid")
                {
                    car.Manifacturer = "Skoda";
                    car.Model = "Rapid";
                }
                if (car.Manifacturer == "Mercedes")
                {
                    //car.Manifacturer = "Skoda";
                    car.Model = car.Model.Replace("Mercedes-Benz", "");
                }
                //if (car.Model.Contains(car.Manifacturer))
                //{
                //    car.Model = car.Model.Replace(car.Manifacturer, "");
                //}
            }

	        return cars;
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
