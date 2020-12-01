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

namespace Uppgift5
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
        int firstNr = 0, secondNr = 0, results = 0;

        private void btnClear_Click(object sender, RoutedEventArgs e) //Clear away in all boxes
        {
            txtSum.Clear();
            txtSyf1.Clear();
            txtSyf2.Clear();
        }

        private void lblSum_MouseDown(object sender, MouseButtonEventArgs e) //press the Sum button
        {
            if (int.TryParse(txtSyf1.Text, out firstNr)) //Check if first box is an int
            {
                if (int.TryParse(txtSyf2.Text, out secondNr)) //Checks if second box is an int
                {
                    results = firstNr + secondNr; // Sums up the two numbers
                }
                else
                    MessageBox.Show("Fel. Inte syffra. Försök igen."); //second box is not an int
            }
            else
                MessageBox.Show("Fel. Inte syffra. Försök igen."); //first box is not an int
            txtSum.Text = Convert.ToString(results);

        }
        //int txtSyf1 = 0, txtSyf2 = 0, txtSum = 0;

        //private void lblSum_MouseDown(object sender, MouseButtonEventArgs e)
        //{
        //    txtSyf1 + txtSyf2.Content = txtSum;
        //}
    }
}
