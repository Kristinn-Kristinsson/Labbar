using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Uppgift12
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int nrArray, sum = 0;
        int howManyInArray = 0;
        int[] numbers = new int[5];
        public MainWindow()
        {
            InitializeComponent();
        }
        private void ClearArray()
        {
            Array.Clear(numbers, 0, numbers.Length);
            txtArray.Clear();
            howManyInArray = 0;
            sum = 0;
        }

        private void txtNrInsert_LostKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            if (int.TryParse(txtNrInsert.Text, out nrArray))
            {
                txtNrInsert.Text = Convert.ToString(txtNrInsert.Text);
            }
            else
            {
                MessageBox.Show("Fel. Inte syffra.");
                txtNrInsert.Clear();
                txtNrInsert.Focus();
            }
        }

        private void btnOK_Click(object sender, RoutedEventArgs e)
        {
            nrArray = int.Parse(txtNrInsert.Text);
            if (howManyInArray >= 5)
            {
                btnOK.IsEnabled = false;   
            }
            else
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    numbers[i] = nrArray;
                    txtNrInsert.Clear();

                }
            howManyInArray++;
            txtArray.AppendText($"{nrArray} \n");
            sum += nrArray;
            double divide = sum / (double)howManyInArray;
            txtMedianValue.Text = Convert.ToString(Math.Round(divide, 2));
            }
        }

        private void btnZero_Click(object sender, RoutedEventArgs e)
        {
            ClearArray();
            btnOK.IsEnabled = true;
        }

        private void txtMedianValue_TextInput(object sender, TextCompositionEventArgs e)
        {

        }
    }
}
