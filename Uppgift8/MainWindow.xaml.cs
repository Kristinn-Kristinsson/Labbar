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

namespace Uppgift8
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
        double x = 0, y = 0, z = 0, conversToK = 0, conversToSEK = 0;

        private void txtAmountK_LostKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            if (double.TryParse(txtAmountK.Text, out z))
            {
                txtAmountK.Text = Convert.ToString(z);
            }
        }

        private void txtAmountS_LostKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            if (double.TryParse(txtAmountS.Text, out y))
            {
                txtAmountS.Text = Convert.ToString(y);
            }
            else
                MessageBox.Show("Fel. Inte syffra. Försök igen.");
        }

        private void txtAmountG_LostKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            if (double.TryParse(txtAmountG.Text, out x))
            {
                txtAmountG.Text = Convert.ToString(x);
            }
            else
                MessageBox.Show("Fel. Inte syffra. Försök igen.");
        }

        private void btnCalc_Click(object sender, RoutedEventArgs e)
        {
            if (txtAmountG.Text != "")
            {
                x = double.Parse(txtAmountG.Text);
            }
            else
                x = 0;
            if (txtAmountS.Text != "")
            {
                y = double.Parse(txtAmountS.Text);
            }
            else
                y = 0;
            if (txtAmountK.Text != "")
            {
                z = double.Parse(txtAmountK.Text);
            }
            else
                z = 0;
            conversToK = x * 493 + y * 29 + z;
            conversToSEK = (conversToK / (double)493) * 62.02;
            lblAmountFinal.Content =$" {(int)conversToSEK} SEK";
        }

    }
}
