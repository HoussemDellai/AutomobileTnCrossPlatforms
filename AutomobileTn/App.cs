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

            //var mainViewModel = new MainViewModel();

            //var refresh = new ToolbarItem
            //{
            //    Icon = "ic_share.png",
            //    Text = "Refresh",
            //    Command = new Command(() =>
            //    {
            //        mainViewModel.RefreshCommand.Execute(null);
            //    })
            //};
            //ToolbarItems.Add(refresh);

            //var tabbedPage = new CarouselPage
            var tabbedPage = new TabbedPage
            {
                Title = "Automobile.Tn",
                BackgroundColor = Color.White,
            };

            //tabbedPage.Children.Add(new Page1());
            tabbedPage.Children.Add(new CarsView());
            tabbedPage.Children.Add(new TweetsView());
            tabbedPage.Children.Add(new VideosView());

            var np = new NavigationPage(tabbedPage);

            MainPage = np;

            //MainPage = new MainView();

            //MainPage = new ContentPage
            //{
            //	Content = new StackLayout
            //	{
            //		VerticalOptions = LayoutOptions.Center,
            //		Children = {
            //			new Label {
            //				XAlign = TextAlignment.Center,
            //				Text = "Welcome to Xamarin Forms!"
            //			}
            //		}
            //	}
            //};
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
