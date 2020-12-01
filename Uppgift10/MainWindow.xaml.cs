using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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

namespace Uppgift10
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
        int x = 0, randomNr, howManyGuesses = 0;
        Random random;


        private void txtGuess_LostKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            if (int.TryParse(txtGuess.Text, out x))
            {
                txtGuess.Text = Convert.ToString(x);
            }
            else
            {
                MessageBox.Show("Fel. Inte syffra. Försök igen.");
                txtGuess.Clear();
                txtGuess.Focus();
            }
        }

        private void btnRndNr_Click(object sender, RoutedEventArgs e)
        {
            random = new Random();
            randomNr = random.Next(1, 1001);
            btnRndNr.Visibility = Visibility.Hidden;
            btnGuess.IsEnabled = true;
            lblInstructions.Content = "Gissa syffra mellan \n 1-1000";
        }

        private void btnGuess_Click(object sender, RoutedEventArgs e)
        {

            if (btnGuess.Background == Brushes.Gray)
            {
                btnGuess.Background = Brushes.Red;
            }
            else
                btnGuess.Background = Brushes.Gray;
            howManyGuesses++;

            x = int.Parse(txtGuess.Text);

            if (x > 1000 || x < 0)
                txbResult.Text = "Det här är inte tillämpad syffra.\n Enbart mellan 1 - 1000";

            if (x == randomNr)
            {
                txbResult.Text = $"Full träff! Bra jobbad! Du gissade {howManyGuesses} gånger.";
                btnRndNr.Visibility = Visibility.Visible;
                btnGuess.IsEnabled = false;
            }
            else if (x < randomNr && x + 100 < randomNr)
            {
                txbResult.Text = "Nah, det var ganska långt ifrån rätt svar. \nFör lågt helt enkelt. Pröva igen!";
            }
            else if (x < randomNr)
            {
                txbResult.Text = "Närmer sig. För lågt dock. \nFörsök igen!";
            }
            else if (x > randomNr && x - 100 > randomNr)
            {
                txbResult.Text = "Nah, det var ganska långt ifrån rätt svar. \nFör högt helt enkelt. Pröva igen!";
            }
            else
                txbResult.Text = "Närmer sig. För högt dock. \nFörsök igen!";
                

        }
    }
}
