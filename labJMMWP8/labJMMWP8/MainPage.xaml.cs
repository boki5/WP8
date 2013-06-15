﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using labJMMWP8.Resources;

namespace labJMMWP8
{
    public partial class MainPage : PhoneApplicationPage
    {
        public int selektirano;
        // Constructor
        public MainPage()
        {
            using (PicerijaDataContext db = new PicerijaDataContext("isostore:/Picerija.sdf"))
            {
                if (db.DatabaseExists() == false)
                {
                    // Create the database.
                    db.CreateDatabase();
                }
            }


            InitializeComponent();

            // Set the data context of the listbox control to the sample data
            DataContext = App.ViewModel;

            // Sample code to localize the ApplicationBar
            //BuildLocalizedApplicationBar();
        }

        // Load data for the ViewModel Items
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            if (!App.ViewModel.IsDataLoaded)
            {
                App.ViewModel.LoadData();
            }
        }

        private void LongListSelector_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {

        }


               private void dodadi(object sender, EventArgs e)
        {
            NavigationService.Navigate(new Uri("/dodavanjeStavka.xaml", UriKind.Relative));
        }

               private void selektiranaPicerija(object sender, SelectionChangedEventArgs e)
               {
                   //selektirano = ((PicerijaItem)(((LongListSelector)sender).SelectedItem)).PicerijaItemId;
                   NavigationService.Navigate(new Uri("/PrikaziPicerija.xaml", UriKind.Relative));
                   
               }


         // Sample code for building a localized ApplicationBar
        //private void BuildLocalizedApplicationBar()
        //{
        //    // Set the page's ApplicationBar to a new instance of ApplicationBar.
        //    ApplicationBar = new ApplicationBar();

        //    // Create a new button and set the text value to the localized string from AppResources.
        //    ApplicationBarIconButton appBarButton = new ApplicationBarIconButton(new Uri("/Assets/AppBar/appbar.add.rest.png", UriKind.Relative));
        //    appBarButton.Text = AppResources.AppBarButtonText;
        //    ApplicationBar.Buttons.Add(appBarButton);

        //    // Create a new menu item with the localized string from AppResources.
        //    ApplicationBarMenuItem appBarMenuItem = new ApplicationBarMenuItem(AppResources.AppBarMenuItemText);
        //    ApplicationBar.MenuItems.Add(appBarMenuItem);
        //}
    }
}