using AutomobileTn.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AutomobileTn.ViewModels;
using Xamarin.Forms;

namespace AutomobileTn
{
    public class App : Application
    {
        public App()
        {
            // The root page of your application

            //var tabbedPage = new CarouselPage
            var tabbedPage = new TabbedPage
            {
                Title = "Automobile.Tn",
                BackgroundColor = Color.White,
            };

            tabbedPage.Children.Add(new SearchCarsView());
            tabbedPage.Children.Add(new TweetsView());
            tabbedPage.Children.Add(new VideosView());
            //tabbedPage.Children.Add(new SearchView());

            var navigationPage = new NavigationPage(tabbedPage);

            MainPage = navigationPage;
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
