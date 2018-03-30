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

namespace Hercules.TrenerView
{
    /// <summary>
    /// Logika interakcji dla klasy Ustawienia_TrenerPage.xaml
    /// </summary>
    public partial class Ustawienia_TrenerPage : Page
    {
        Trener trener = new Trener();
        Metody metody = new Metody();

        public Ustawienia_TrenerPage()
        {
            InitializeComponent();
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                BazaDAO baza = new BazaDAO();

                trener = metody.Pobierz_Trener_Login(ObecnyUzytkownik.Default.Login);
                imieTB.Text = trener.Imie;
                nazwiskoTB.Text = trener.Nazwisko;
                loginTB.Text = trener.Login;
                hasloTB.Password = trener.Haslo;

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
                trener.Imie = imieTB.Text;
                trener.Nazwisko = nazwiskoTB.Text;
                trener.Login = loginTB.Text;
                trener.Haslo = hasloTB.Password;
                metody.Modyfikuj_Trener(trener, trener.IdTrener);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
    }
}
