﻿using GestionLogin2.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
       
        public List<Salle> Salles;
        public List<ClasseModel> Classes;

        public GestionEtudiant()
        {
            this.InitializeComponent();
            Salles = SalleManager.GetSalles();
            Classes = ClasseManager.GetClasses();
            

        }
  
        private void SelectionClasse_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            var classe = e.AddedItems[0] as ClasseModel;
            Debug.WriteLine(classe);
            Debug.WriteLine(classe.Eleves);
            EleveListView.ItemsSource = classe.Eleves;
        }

        


        private void EleveListView_ItemClick(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(infoetudiant));
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

        private void EleveListView_ItemClick(object sender, ItemClickEventArgs e)
        {

        }
    }
}


