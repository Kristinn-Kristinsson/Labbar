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

namespace Uppgift11
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            lblMax.Content = "Mer \n otur";
            lblMin.Content = "Mindre \n otur";
            btnLess.Content = "Mindre \n otur";
            btnMore.Content = "Mer \n otur";
        }

        int i;
        int tries = 0, randomThrow, sumGood = 0, sumBad = 0;
        double percentage = 0;
        Random random;

        private void btnLess_Click(object sender, RoutedEventArgs e)
        {
            
            pgbChance.Value = pgbChance.Value-5;
            txbPercentage.Text = pgbChance.Value.ToString() + "%";
        }

        private void btnMore_Click(object sender, RoutedEventArgs e)
        {
            pgbChance.Value = pgbChance.Value+5;
            txbPercentage.Text = pgbChance.Value.ToString() + "%";
        }

        private void txtTries_LostKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            if (int.TryParse(txtTries.Text, out tries))
            {
                txtTries.Text = Convert.ToString(tries);
            }
            else
            {
                MessageBox.Show("Fel. Inte syffra.");
                txtTries.Clear();
                txtTries.Focus();
            }
        }

        private void btnStart_Click(object sender, RoutedEventArgs e)
        {
            sumGood = 0;
            sumBad = 0;
            lblSuccess.Content = "";
            lblFails.Content = "";

            for(i = 0; i < int.Parse(txtTries.Text); i++)
            {
                random = new Random();
                randomThrow = random.Next(0, 101);
                if (randomThrow <= int.Parse(pgbChance.Value.ToString()))
                {
                    sumBad++;
                }
                else
                    sumGood++;
            }
            lblSuccess.Content = $"Antal i rätt håll {sumGood}";
            lblFails.Content = $"Antal i fel håll {sumBad}";
            percentage = ((double)sumBad/int.Parse(txtTries.Text)) * 100;
            Math.Round(percentage, 2);
            pgbRightPercentage.Value = percentage;
            txbRightPercentage.Text = pgbRightPercentage.Value.ToString() + "%";
        }
    }
}
