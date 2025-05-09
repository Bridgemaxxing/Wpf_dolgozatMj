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

namespace masodik
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
            double eredmeny = 0;
            if (double.TryParse(tbx_szam1.Text, out double szam1) && double.TryParse(tbx_szam2.Text, out double szam2))
            {
                switch (tbx_muveletiJel.Text)
                {
                    case "+":
                        eredmeny = szam1 + szam2;
                        tbx_eredmeny.Text = eredmeny.ToString();
                        break;
                    case "-":
                        eredmeny = szam1 - szam2;
                        tbx_eredmeny.Text = eredmeny.ToString();
                        break;
                    case "*":
                        eredmeny = szam1 * szam2;
                        tbx_eredmeny.Text = eredmeny.ToString();
                        break;
                    case "/":
                        if (szam1 <= 0)
                        {
                            MessageBox.Show("Hiba! Az első számnak nagyobbnak kell lennie mint 0", "Hiba", MessageBoxButton.OK, MessageBoxImage.Error);
                            tbx_szam1.Clear();
                            tbx_szam2.Clear();
                        }
                        else
                        {
                            eredmeny = szam1 / szam2;
                            tbx_eredmeny.Text = eredmeny.ToString();
                            break;
                        }
                        
                        break ;
                    default:
                        MessageBox.Show("Hiba! Nem megfelelő műveleti jel!", "Hiba", MessageBoxButton.OK, MessageBoxImage.Error);
                        tbx_muveletiJel.Text = "";
                        break;

                }
            }
            else
            {
                MessageBox.Show("Hiba! Nem számot attál meg!", "Hiba", MessageBoxButton.OK, MessageBoxImage.Error);
                tbx_szam1.Clear();
                tbx_szam2.Clear();
                tbx_muveletiJel.Clear();
            }
        }
    }
}
