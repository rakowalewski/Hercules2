using ClassLibrary.DAO;
using ClassLibrary.Basic;
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
using ClassLibrary;

namespace Hercules
{
    /// <summary>
    /// Logika interakcji dla klasy Ustawienia_AdminPage.xaml
    /// </summary>
    public partial class Ustawienia_AdminPage : Page
    {
       private Administrator admin = new Administrator();
        Metody metody = new Metody();

        public Ustawienia_AdminPage()
        {
            InitializeComponent();
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            

            try
            {
                BazaDAO baza = new BazaDAO();
               
                admin = metody.Pobierz_Administrator_Login(ObecnyUzytkownik.Default.Login);
                imieTB.Text = admin.Imie;
                nazwiskoTB.Text = admin.Nazwisko;
                loginTB.Text = admin.Login;
                hasloTB.Text = admin.Haslo;
                
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
                admin.Imie = imieTB.Text;
                admin.Nazwisko = nazwiskoTB.Text;
                admin.Login = loginTB.Text;
                admin.Haslo = hasloTB.Text;
                metody.Modyfikuj_Administrator(admin, admin.IdAdministrator);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
    }
}
