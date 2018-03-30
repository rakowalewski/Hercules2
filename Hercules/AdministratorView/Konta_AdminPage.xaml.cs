using ClassLibrary;
using ClassLibrary.DAO;
using Hercules.Klasy;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows;
using System.Windows.Controls;
using ClassLibrary.Basic;
using System.Collections.ObjectModel;

namespace Hercules
{
    /// <summary>
    /// Logika interakcji dla klasy Konta_AdminPage.xaml
    /// </summary>
    public partial class Konta_AdminPage : Page
    {
        public Konta_AdminPage()
        {
            InitializeComponent();
        }

        private void ComboBoxItem_Selected(object sender, RoutedEventArgs e)
        {

        }

        private void addUserBtn_Click(object sender, RoutedEventArgs e)
        {
           
            try
            {
                Metody metody = new Metody();

                BazaDAO baza = new BazaDAO();
                if (stanowiskoCB.Text == "Administrator")
                {
                    Administrator administrator = new Administrator();
                    administrator.Imie = imieTB.Text;
                    administrator.Nazwisko = nazwiskoTB.Text;
                    administrator.Login = loginTB.Text;
                    administrator.Haslo = hasloTB.Text;
                    metody.Dodaj_Administratora(administrator);
                    MessageBox.Show("Dodano użytkownika");
                }
                else if (stanowiskoCB.Text == "Trener")
                {
                    
                    Trener trener = new Trener();
                    trener.Imie = imieTB.Text;
                    trener.Nazwisko = nazwiskoTB.Text;
                    trener.Login = loginTB.Text;
                    trener.Haslo = hasloTB.Text;
                    metody.Dodaj_Trener(trener);
                    MessageBox.Show("Dodano użytkownika");
                }
                else if (stanowiskoCB.Text == "Recepcja")
                {
                    Recepcja recepcja = new Recepcja();
                    recepcja.Imie = imieTB.Text;
                    recepcja.Nazwisko = nazwiskoTB.Text;
                    recepcja.Login = loginTB.Text;
                    recepcja.Haslo = hasloTB.Text;
                    metody.Dodaj_Recepcja(recepcja);
                    MessageBox.Show("Dodano użytkownika");
                }
            }
            catch (Exception)
            {

                
            }
           


        }

        private void LoadDataBtn_Click(object sender, RoutedEventArgs e)
        {
            Metody metody = new Metody();
            BazaDAO baza = new BazaDAO();
            try
            {
                if (adminRB.IsChecked == true)
                {
                    
                    modyfikujDG.ItemsSource = metody.Pobierz_Wsz_Administratorow();

                } else if (trenerRB.IsChecked == true)
                {
                    modyfikujDG.ItemsSource = metody.Pobierz_Wsz_Trenerow();
                }
                else if (recepcjaRB.IsChecked == true)
                {
                    modyfikujDG.ItemsSource = metody.Pobierz_Wsz_Recepcja();
                }
            }
            catch (Exception)
            {

                throw;
            }

                
            
        }

        private void changeDataBTN_Click(object sender, RoutedEventArgs e)
        {
            Metody metody = new Metody();
            BazaDAO baza = new BazaDAO();
            
            
            try
            {
                if (adminRB.IsChecked == true)
                {
                    var modyfikowanyRekord = modyfikujDG.SelectedItem as Administrator;
                    metody.Modyfikuj_Administrator(modyfikowanyRekord, modyfikowanyRekord.IdAdministrator);
                    

                }
                else if (trenerRB.IsChecked == true)
                {
                    var modyfikowanyRekord = modyfikujDG.SelectedItem as Trener;
                    metody.Modyfikuj_Trener(modyfikowanyRekord, modyfikowanyRekord.IdTrener);
                }
                else if (recepcjaRB.IsChecked == true)
                {
                    var modyfikowanyRekord = modyfikujDG.SelectedItem as Recepcja;
                    metody.Modyfikuj_Recepcja(modyfikowanyRekord, modyfikowanyRekord.IdRecepcja);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
