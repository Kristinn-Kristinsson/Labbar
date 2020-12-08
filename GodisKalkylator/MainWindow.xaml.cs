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


namespace GodisKalkylator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string filename = "Populate.json";
        public MainWindow()
        {
            InitializeComponent();
        }
        public int simpleCheck = 0;
        public int x = 0;
        
        public class LBPeople
        {
            public string Info { get; set; }
            public int HowManyCandy { get; set; }
        }
        CandyCalculator candyCalculator = new CandyCalculator();
        

        private void btnAddPerson_Click(object sender, RoutedEventArgs e)
        {
            if (txtAge.Text == "")
            {
                MessageBox.Show("Hur gammal är du egentligen då?");
                return;
            }
            else if (txtFirstName.Text == "")
            {
                MessageBox.Show("Vill inte ge upp ditt namn?");
                return;
            }

            else if (txtLastName.Text == "")
            {
                MessageBox.Show("Men efternamn?");
                return;
            }
            var p = new Person(int.Parse(txtAge.Text), txtFirstName.Text, txtLastName.Text);
            p.PersonToString(p);
            candyCalculator.ThePeople.Add(p);
            lbPersons.Items.Add(p);

            txtAge.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
        }
        
        private void txtAge_LostKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            if (int.TryParse(txtAge.Text, out simpleCheck))
            {
                txtAge.Text = Convert.ToString(txtAge.Text);
            }
            else
            {
                MessageBox.Show("Fel. Inte syffra.");
                txtAge.Clear();
                txtAge.Focus();
            }
        }

        private void txtCandies_LostKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            if (int.TryParse(txtCandies.Text, out simpleCheck))
            {
                txtCandies.Text = Convert.ToString(txtCandies.Text);
            }
            else
            {
                MessageBox.Show("Fel. Inte syffra.");
                txtCandies.Clear();
                txtCandies.Focus();
            }
        }

        private void btnDealCandy_Click(object sender, RoutedEventArgs e)
        {
            if (txtCandies.Text == "")
            {
                MessageBox.Show("Du måste ha något godis till att dela!");
                return;
            }
            candyCalculator.CalculateCandy(int.Parse(txtCandies.Text), candyCalculator.ThePeople.Count());

            lbPersons.Items.Clear();
            for (int i = 0; i < candyCalculator.ThePeople.Count(); i++)
            {
                lbPersons.Items.Add(candyCalculator.ThePeople[i]);
            }
            txtCandies.Clear();
            
        }

        

        private void rbFirstName_Checked(object sender, RoutedEventArgs e)
        {
            candyCalculator.CalculateByFirstName();
            lbPersons.Items.Clear();
            for (int i = 0; i < candyCalculator.ThePeople.Count(); i++)
            {
                lbPersons.Items.Add(candyCalculator.ThePeople[i]);
            }
        }

        private void rbLastName_Checked(object sender, RoutedEventArgs e)
        {
            candyCalculator.CalculateByLastName();
            lbPersons.Items.Clear();
            for (int i = 0; i < candyCalculator.ThePeople.Count(); i++)
            {
                lbPersons.Items.Add(candyCalculator.ThePeople[i]);
            }

        }

        private void rbAge_Checked(object sender, RoutedEventArgs e)
        {
            candyCalculator.CalculateByAge();
            lbPersons.Items.Clear();
            for (int i = 0; i < candyCalculator.ThePeople.Count(); i++)
            {
                lbPersons.Items.Add(candyCalculator.ThePeople[i]);
            }
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            FileHandler.Save(candyCalculator.ThePeople, filename);
        }

        private void btnLoad_Click(object sender, RoutedEventArgs e)
        {
            List<Person> Populate = FileHandler.Open<List<Person>>(filename);
            //lbPersons.Items.Refresh();
            lbPersons.Items.Clear();
            for (int i = 0; i < Populate.Count(); i++)
            {
                lbPersons.Items.Add(Populate[i]);
            }
        }
    }
}
