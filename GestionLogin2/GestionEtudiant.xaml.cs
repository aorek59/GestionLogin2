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



// Pour plus d'informations sur le modèle d'élément Page vierge, voir la page http://go.microsoft.com/fwlink/?LinkId=234238

namespace GestionLogin2
{
    /// <summary>
    /// Une page vide peut être utilisée seule ou constituer une page de destination au sein d'un frame.
    /// </summary>
    public sealed partial class GestionEtudiant : Page
    {

        public GestionEtudiant()
        {
            this.InitializeComponent();


        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ComboBoxResultTextBlock == null) return;

            var combo = (ComboBox)sender;
            var item = (ComboBoxItem)combo.SelectedItem;
            ComboBoxResultTextBlock.Text = item.Content.ToString();

        }
        private void SelectionClasse_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var classe = e.AddedItems[0] as ClasseModel;
            EleveListView.ItemsSource = classe.Eleves;
        }
        private void ValiderButton_Click(object sender, RoutedEventArgs e)
        {

        }
        private void ajouterlogo_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Ajouteretudiant));
        }

        private void AnnulerButton_Click(object sender, RoutedEventArgs e)
        {
            if (Frame.CanGoBack)
            {
                Frame.GoBack();
            }
        }
    }
}


