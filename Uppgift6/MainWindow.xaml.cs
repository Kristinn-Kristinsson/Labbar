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

namespace Uppgift6
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double x = 0, y = 0, z = 0;

        private void txtNr1_LostKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            if (double.TryParse(txtNr1.Text, out x))
            {
                txtNr1.Text = Convert.ToString(x);
            }
            else
                MessageBox.Show("Fel. Inte syffra. Försök igen.");
        }

        private void txtNr2_LostKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            if (double.TryParse(txtNr2.Text, out y))
            {
                txtNr2.Text = Convert.ToString(y);
            }
            else
                MessageBox.Show("Fel. Inte syffra. Försök igen.");
        }

        private void btnPlus_Click(object sender, RoutedEventArgs e)
        {
            lblOperation.Content = "Plus";
            lblNr1.Content = "Term 1";
            lblNr2.Content = "Term 2";
            x = double.Parse(txtNr1.Text);
            y = double.Parse(txtNr2.Text);
            z = x + y;
            txtResult.Text = Convert.ToString(z);
        }

        private void btnMinus_Click(object sender, RoutedEventArgs e)
        {
            lblOperation.Content = "Minus";
            lblNr1.Content = "Term 1";
            lblNr2.Content = "Term 2";
            x = double.Parse(txtNr1.Text);
            y = double.Parse(txtNr2.Text);
            z = x - y;
            txtResult.Text = Convert.ToString(z);
        }

        private void btnMultiple_Click(object sender, RoutedEventArgs e)
        {
            lblOperation.Content = "Multiplikation";
            lblNr1.Content = "Faktor 1";
            lblNr2.Content = "Faktor 2";
            x = double.Parse(txtNr1.Text);
            y = double.Parse(txtNr2.Text);
            z = x * y;
            txtResult.Text = Convert.ToString(z);
        }

        private void btnDivision_Click(object sender, RoutedEventArgs e)
        {
            lblOperation.Content = "Divition";
            lblNr1.Content = "Täljare";
            lblNr2.Content = "Nämnare";
            //txtNr2.Text = txtNr2.Text;
            x = double.Parse(txtNr1.Text);
            y = double.Parse(txtNr2.Text);
            z = x / y;
            z = Math.Round(z, 2);
            txtResult.Text = Convert.ToString(z);
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            txtNr1.Text = "";
            txtNr2.Text = "";
            txtResult.Text = "";
        }

        public MainWindow()
        {
            InitializeComponent();
        }
    }
}
