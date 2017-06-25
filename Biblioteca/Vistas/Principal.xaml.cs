using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Biblioteca
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
        }

        private void OnPersonasClick(object sender, RoutedEventArgs e)
        {
            this.MostrarMensaje("Carreras");
        }

        private void OnClasesClick(object sender, RoutedEventArgs e)
        {
            this.MostrarMensaje("Carreras");
        }

        private void OnCarrerasClick(object sender, RoutedEventArgs e)
        {
            this.MostrarMensaje("Carreras");
        }

        private async void MostrarMensaje(String nombre)
        {
            ContentDialog dialogo = new ContentDialog
            {
                Title = "Mostrar " + nombre,
                Content = "Se debería de mostrar el menú de " + nombre,
                CloseButtonText = "Está bien"
            };

            ContentDialogResult result = await dialogo.ShowAsync();
        }
    }
}
