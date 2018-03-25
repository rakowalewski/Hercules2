using ClassLibrary;
using ClassLibrary.Basic;
using ClassLibrary.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Hercules.RecepcjaView
{
    /// <summary>
    /// Logika interakcji dla klasy Ustawienia_RecepcjaPage.xaml
    /// </summary>
    public partial class Ustawienia_RecepcjaPage : Page
    {
        Recepcja recepcja = new Recepcja();
        Metody metody = new Metody();

        public Ustawienia_RecepcjaPage()
        {
            InitializeComponent();
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                BazaDAO baza = new BazaDAO();

                recepcja = metody.Pobierz_Recepcja_Login(ObecnyUzytkownik.Default.Login);
                imieTB.Text = recepcja.Imie;
                nazwiskoTB.Text = recepcja.Nazwisko;
                loginTB.Text = recepcja.Login;
                hasloTB.Text = recepcja.Haslo;

            }
            catch (Exception a)
            {

                MessageBox.Show(a.ToString());
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                BazaDAO baza = new BazaDAO();
                recepcja.Imie = imieTB.Text;
                recepcja.Nazwisko = nazwiskoTB.Text;
                recepcja.Login = loginTB.Text;
                recepcja.Haslo = hasloTB.Text;
                metody.Modyfikuj_Recepcja(recepcja, recepcja.IdRecepcja);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
    }
}
