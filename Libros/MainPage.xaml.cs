using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Libros.Resources;
using Libros.Models;


namespace Libros
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();

            // Código de ejemplo para traducir ApplicationBar
            //BuildLocalizedApplicationBar();
        }

        private void goToPage(object sender, SelectionChangedEventArgs e)
        {
            var selectedItem = list.SelectedItem as ItemMenu;
            if (selectedItem.Titulo == "Cien Años de Soledad")
            {
                NavigationService.Navigate(new Uri("/Soledad.xaml", UriKind.Relative));
            }
            if (selectedItem.Titulo == "El Principito")
            {
                NavigationService.Navigate(new Uri("/Principito.xaml", UriKind.Relative));
            }
            if (selectedItem.Titulo == "Crimen y Castigo")
            {
                NavigationService.Navigate(new Uri("/Crimen.xaml", UriKind.Relative));
            }
            else
            {
                NavigationService.Navigate(new Uri("/Orgullo.xaml", UriKind.Relative));
            }

        }
        // Código de ejemplo para compilar una ApplicationBar traducida
        //private void BuildLocalizedApplicationBar()
        //{
        //    // Establecer ApplicationBar de la página en una nueva instancia de ApplicationBar.
        //    ApplicationBar = new ApplicationBar();

        //    // Crear un nuevo botón y establecer el valor de texto en la cadena traducida de AppResources.
        //    ApplicationBarIconButton appBarButton = new ApplicationBarIconButton(new Uri("/Assets/AppBar/appbar.add.rest.png", UriKind.Relative));
        //    appBarButton.Text = AppResources.AppBarButtonText;
        //    ApplicationBar.Buttons.Add(appBarButton);

        //    // Crear un nuevo elemento de menú con la cadena traducida de AppResources.
        //    ApplicationBarMenuItem appBarMenuItem = new ApplicationBarMenuItem(AppResources.AppBarMenuItemText);
        //    ApplicationBar.MenuItems.Add(appBarMenuItem);
        //}
    }
}