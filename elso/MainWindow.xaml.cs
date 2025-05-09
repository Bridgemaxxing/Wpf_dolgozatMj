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

namespace elso
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_szamol_Click(object sender, RoutedEventArgs e)
        {
            // int szam1;
            //int szam1 = int.TryParse(tbx_szam1, out szam1);

            if (double.TryParse(tbx_szam1.Text, out double szam1) && double.TryParse(tbx_szam2.Text, out double szam2))
            {
                double megoldas = (szam1 + szam2) / 2;
                tbx_szamtanikoz.Text = megoldas.ToString();
                double megoldas2 = Math.Sqrt(szam1 * szam2);
                tbx_mertanikoz.Text = megoldas2.ToString();
            }
            else
            {
                MessageBox.Show("Hiba! Nem megfelelő bevitel\nSzámnak kell lennie!", "Hiba", MessageBoxButton.OK,MessageBoxImage.Error);
            }

            
        }

       
    }
}
