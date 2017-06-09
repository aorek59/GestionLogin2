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

// Pour plus d'informations sur le modèle d'élément Page vierge, consultez la page http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace GestionLogin2
{
    /// <summary>
    /// Une page vide peut être utilisée seule ou constituer une page de destination au sein d'un frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private string Username = "florian";
        private string Password = "Roberto";

        public MainPage()
        {
            this.InitializeComponent();
        }

        private void Connexion_Click(object sender, RoutedEventArgs e)
        {
            if (LoginTextBlock.Text == Username && PasswordTextBlock.Text == Password)
            {
                Frame.Navigate(typeof(Shell));
            }
            else
            {
                ErrorTextBlock.Text = "Identifiant ou mot de passe introuvable";
            }
        }
    }
}
