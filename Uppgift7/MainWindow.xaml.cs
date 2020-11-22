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

namespace Uppgift7
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
        int x = 0, y = 0, z = 0;

        private void txtNr2_LostKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            if (int.TryParse(txtNr2.Text, out y))
            {
                txtNr2.Text = Convert.ToString(y);
            }
            else
                MessageBox.Show("Fel. Inte syffra. Försök igen.");
        }

        private void txtNr1_LostKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            if (int.TryParse(txtNr1.Text, out x))
            {
                txtNr1.Text = Convert.ToString(x);
            }
            else
                MessageBox.Show("Fel. Inte syffra. Försök igen.");
        }
        private void btnCalc_Click(object sender, RoutedEventArgs e)
        {
            x = int.Parse(txtNr1.Text);
            y = int.Parse(txtNr2.Text);
            z = x / y;
            txtWhole.Text = Convert.ToString(z);
            z = x % y;
            txtModulus.Text = Convert.ToString(z);
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
                txtModulus.Text = "";
                txtNr1.Text = "";
                txtNr2.Text = "";
                txtWhole.Text = "";
        }
        


    }
}
