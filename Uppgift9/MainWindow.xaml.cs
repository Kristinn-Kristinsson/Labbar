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

namespace Uppgift9
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
        int x;

        string person7 = "Men om du har vuxen med \nkan du se filmer tillåtna \nbarn 7 och yngre.";
        string person11 = "Men om du har vuxen med \nkan du se filmer tillåtna \nbarn 11 och yngre.";
        string person15 = "Spelar ingen roll med vuxen.";
        string personAdult = "Du är vuxen och kan \nfölja med barn som vill se filmer \nmed åldersgräns.";
        

        private void btnControl_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(txtAge.Text, out x))
            {
                if (x < 7)
                {
                    txbResult.Text = $"Hej {txtName.Text}. Du är {txtAge.Text} och därför \nenbart tillåten att se filmer \nutan åldersgräns. ";
                    txbResult2.Text = $"Hej {txtName.Text}. Du är {txtAge.Text} och därför \nenbart tillåten att se filmer \nutan åldersgräns. " +
                        $"Men om du har vuxen med kan du se filmer tillåtna \nbarn 7 och yngre.";
                }
                else if (x < 11)
                {
                    txbResult.Text = $"Hej {txtName.Text}. Du är {txtAge.Text} och därför \nkan se filmer tillåten för barn \nyngre en 7. ";
                    txbResult2.Text = $"Hej {txtName.Text}. Du är {txtAge.Text} och därför \nkan se filmer tillåten för barn \nyngre en 7. " +
                        $"Men om du har vuxen med kan du se filmer tillåtna barn 11 och yngre.";
                }
                else if (x < 15)
                {
                    txbResult.Text = $"Hej {txtName.Text}. Du är {txtAge.Text} och därför \nkan se filmer tillåten för barn \nyngre en 11. ";
                    txbResult2.Text = $"Hej {txtName.Text}. Du är {txtAge.Text} och därför \nkan se filmer tillåten för barn \nyngre en 11. " +
                        $"Spelar ingen roll med vuxen.";
                    
                }
                else
                {
                    txbResult.Text = $"Hej {txtName.Text}. Du är {txtAge.Text} och därför \nkan se alla filmer. ";
                    txbResult2.Text = $"Hej {txtName.Text}. Du är {txtAge.Text} och därför \nkan se alla filmer. " +
                        $"Du är vuxen och kan följa med barn som vill se filmer med åldersgräns.";
                }
            }
            else
                MessageBox.Show("Skriv din ålder i syffror, tack.");

        }

        private void rdbUtan_Checked(object sender, RoutedEventArgs e)
        {
            txbResult.Visibility = Visibility.Visible;
            txbResult2.Visibility = Visibility.Hidden;
        }

        private void rdbVuxen_Checked(object sender, RoutedEventArgs e)
        {
            txbResult.Visibility = Visibility.Hidden;
            txbResult2.Visibility = Visibility.Visible;
        }
    }
}
