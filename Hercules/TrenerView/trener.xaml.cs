using Microsoft.Win32;
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
using System.Windows.Shapes;
using System.Data.SqlClient;
using Hercules.TrenerView;

namespace Hercules
{
    /// <summary>
    /// Logika interakcji dla klasy trener.xaml
    /// </summary>
    public partial class trener : Window
    {
        public trener()
        {
            InitializeComponent();
            
            
        }

        

      

        private void BtnTrening_Click(object sender, RoutedEventArgs e)
        {
            TrenerFrame.Content = new Trening_TrenerPage();
        }

        private void BtnKlient_Click(object sender, RoutedEventArgs e)
        {
            TrenerFrame.Content = new Klient_TrenerPage();
        }

        private void btnStatystyki_Click(object sender, RoutedEventArgs e)
        {
            TrenerFrame.Content = new Statystyki_TrenerPage();
        }

        private void btnHarmonogram_Click(object sender, RoutedEventArgs e)
        {
            TrenerFrame.Content = new Harmonogram_TrenerPage();
        }

        private void btnUstawienia_Click(object sender, RoutedEventArgs e)
        {
            TrenerFrame.Content = new Ustawienia_TrenerPage();
        }
    }
}
