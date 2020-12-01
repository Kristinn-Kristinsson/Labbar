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

namespace Uppgift14
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

        int age;

        private int CheckAge(int age)
        {
            age = DateTime.Now.Year - age;
            return age;
        }
        

        private string CheckIfNumber(string writing)
        {
            foreach(char letter in writing)
            {
                if (char.IsLetter(letter))
                {
                    MessageBox.Show("Fel. Inte syffra.");
                    txtBirthYear.Clear();
                    txtBirthYear.Focus();
                    return writing;
                }
                else
                {
                    continue;
                }
            }
            return writing;
        }

        private void txtBirthYear_LostKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            CheckIfNumber(txtBirthYear.Text);
        }

        private void btnBirthYear_Click(object sender, RoutedEventArgs e)
        {
            age = CheckAge(int.Parse(txtBirthYear.Text));
            if (age < 0)
            {
                MessageBox.Show($"Du föddes året {txtBirthYear.Text} och är därför {age} år gammal." +
                    $"\nAlltså du är inte född!");
            }
            else if (age >= 100)
            {
                MessageBox.Show($"Du föddes året {txtBirthYear.Text} och är därför {age} år gammal. " +
                    $"\nÄr det möjligt du gjorde fel?");
            }
            else if (age <= 100)
                MessageBox.Show($"Du föddes året {txtBirthYear.Text} och är därför {age} år gammal.");
        }
    }
}
