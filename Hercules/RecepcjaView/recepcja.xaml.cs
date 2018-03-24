using Hercules.RecepcjaView;
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

namespace Hercules
{
    /// <summary>
    /// Logika interakcji dla klasy recepcja.xaml
    /// </summary>
    public partial class recepcja : Window
    {
        public recepcja()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            RecepcjaFrame.Content = new Klient_RecepcjaPage();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            RecepcjaFrame.Content = new Harmonogram_RecepcjaPage();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            RecepcjaFrame.Content = new Ustawienia_RecepcjaPage();
        }
    }
}
