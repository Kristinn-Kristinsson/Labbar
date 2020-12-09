using System;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Linq;
using System.Drawing;

namespace HarryPotter1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //public override string ToString()
        //{
        //    return this.GetType().Name;
        //}
        public MainWindow()
        {           
            InitializeComponent();

            cboHouses.Items.Add(hogwarts.Hufflepuff);
            cboHouses.Items.Add(hogwarts.Ravenclaw);
            cboHouses.Items.Add(hogwarts.Gryffindor);
            cboHouses.Items.Add(hogwarts.Slytherin);
            lblHufflepuffMascot.Content = hogwarts.Hufflepuff.Mascot;
            lblRavenclawMascot.Content = hogwarts.Ravenclaw.Mascot;
            lblGryffindorMascot.Content = hogwarts.Gryffindor.Mascot;
            lblSlytherinMascot.Content = hogwarts.Slytherin.Mascot;
        }
        public string filename = "YoureAWizard.json";

        Wizard wiz;
        Hogwarts hogwarts = new Hogwarts();
        
        private void btnChangePassword_Click(object sender, RoutedEventArgs e)
        {
            if (cboHouses.Items[0] == cboHouses.SelectedItem)
            {
                if (hogwarts.Hufflepuff.SetPassword(txtOldPassword.Text, txtNewPassword.Text) == true)
                {
                    MessageBox.Show($"{hogwarts.Hufflepuff.Password} är nu det nyja lösenordet. Kom ihåg det!");
                }
                else
                    MessageBox.Show($"Något blev fel, gamla eller det nyja lösenordet inte rätt.");
            }
            else if (cboHouses.Items[1] == cboHouses.SelectedItem)
            {
                if (hogwarts.Ravenclaw.SetPassword(txtOldPassword.Text, txtNewPassword.Text) == true)
                {
                    MessageBox.Show($"{hogwarts.Ravenclaw.Password} är nu det nyja lösenordet. Kom ihåg det!");
                }
                else
                    MessageBox.Show($"Något blev fel, gamla eller det nyja lösenordet inte rätt.");
            }
            else if (cboHouses.Items[2] == cboHouses.SelectedItem)
            {
                if (hogwarts.Gryffindor.SetPassword(txtOldPassword.Text, txtNewPassword.Text) == true)
                {
                    MessageBox.Show($"{hogwarts.Gryffindor.Password} är nu det nyja lösenordet. Kom ihåg det!");
                }
                else
                    MessageBox.Show($"Något blev fel, gamla eller det nyja lösenordet inte rätt.");
            }
            else
            {
                if (hogwarts.Slytherin.SetPassword(txtOldPassword.Text, txtNewPassword.Text) == true)
                {
                    MessageBox.Show($"{hogwarts.Slytherin.Password} är nu det nyja lösenordet. Kom ihåg det!");
                }
                else
                    MessageBox.Show($"Något blev fel, gamla eller det nyja lösenordet inte rätt.");
            }
        }

        private void btnSortingHat_Click(object sender, RoutedEventArgs e)
        {
            if (txtNewWizardName.Text == "")
            {
                MessageBox.Show("Trollkarl utan namn. Konstigt. Ge honom något namn!");
                return;
            }

            chkArmy.IsChecked = false;
            chkDeatheater.IsChecked = false;
            wiz = new Wizard(txtNewWizardName.Text);
            House house = hogwarts.SortingHat(wiz);
            txtNewWizardName.Clear();
            txtName.Text = wiz.Name;
            chkDeatheater.IsChecked = wiz.DeathEater;
            chkArmy.IsChecked = wiz.DumbledoresArmy;
            int grf_TotalMembers = hogwarts.Gryffindor.Members.Count();
            int hfp_TotalMembers = hogwarts.Hufflepuff.Members.Count();
            int rvc_TotalMembers = hogwarts.Ravenclaw.Members.Count();
            int slt_TotalMembers = hogwarts.Slytherin.Members.Count();


            lstGryffindor.ItemsSource = hogwarts.Gryffindor.Members; //alla raden nedan for.
            lstHufflepuff.ItemsSource = hogwarts.Hufflepuff.Members;
            lstRavenclaw.ItemsSource = hogwarts.Ravenclaw.Members;
            lstSlytherin.ItemsSource = hogwarts.Slytherin.Members; 
                MessageBox.Show($"Välkommen {wiz.Name}! Du är nu del av {house}, nr {house.Members.Count}" +
                    $" i det Huset och nr \n{hogwarts.TotalWizards} i hela Hogwarts! Lösenordet till hemmet är " +
                    $"{house.Password}\n (skriv det när, du får inte se det igen!) och " +
                    $"{house.HouseGhost}\n ser fram emot att träffa dig.");
        }

        private void lstHufflepuff_MouseDoubleClick(object sender, MouseButtonEventArgs e) // tilldela 
        {
            wiz = (Wizard)cboHouses.SelectedItem;
            chkArmy.IsChecked = wiz.DumbledoresArmy;
            chkDeatheater.IsChecked = wiz.DeathEater;
            txtName.Text = wiz.Name;
        }

        private void lstRavenclaw_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            chkArmy.IsChecked = false;
            chkDeatheater.IsChecked = false;
            if (lstRavenclaw.SelectedItem != null)
            {
                txtName.Text = lstRavenclaw.SelectedItem.ToString();
                for (int i = 0; i < hogwarts.Ravenclaw.Members.Count(); i++)
                    if (hogwarts.Ravenclaw.Members[i].Name == txtName.Text)
                        if (hogwarts.Ravenclaw.Members[i].DeathEater == true)
                        {
                            chkDeatheater.IsChecked = true;
                            if (hogwarts.Ravenclaw.Members[i].DumbledoresArmy == true)
                            {
                                chkArmy.IsChecked = true;
                            }
                        }
            }
        }

        private void lstGryffindor_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            chkArmy.IsChecked = false;
            chkDeatheater.IsChecked = false;
            if (lstGryffindor.SelectedItem != null)
            {
                txtName.Text = lstGryffindor.SelectedItem.ToString();
                for (int i = 0; i < hogwarts.Gryffindor.Members.Count(); i++)
                    if (hogwarts.Gryffindor.Members[i].Name == txtName.Text)
                        if (hogwarts.Gryffindor.Members[i].DeathEater == true)
                        {
                            chkDeatheater.IsChecked = true;
                            if (hogwarts.Gryffindor.Members[i].DumbledoresArmy == true)
                            {
                                chkArmy.IsChecked = true;
                            }
                        }
            }

        }

        private void lstSlytherin_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            chkArmy.IsChecked = false;
            chkDeatheater.IsChecked = false;
            if (lstSlytherin.SelectedItem != null)
            {
                txtName.Text = lstSlytherin.SelectedItem.ToString();
                for (int i = 0; i < hogwarts.Slytherin.Members.Count(); i++)
                    if (hogwarts.Slytherin.Members[i].Name == txtName.Text)
                        if (hogwarts.Slytherin.Members[i].DeathEater == true)
                        {
                            chkDeatheater.IsChecked = true;
                            if (hogwarts.Slytherin.Members[i].DumbledoresArmy == true)
                            {
                                chkArmy.IsChecked = true;
                            }
                        }
            }
        }

        private void btnSaveFile_Click(object sender, RoutedEventArgs e)
        {
            FileHandler.Save(hogwarts, filename);
        }

        private void btnLoadFile_Click(object sender, RoutedEventArgs e)
        {
            Hogwarts YoureAWizard = FileHandler.Open<Hogwarts>(filename);                  
            lstGryffindor.ItemsSource = (YoureAWizard.Gryffindor.Members);
            lstHufflepuff.ItemsSource = (YoureAWizard.Hufflepuff.Members);
            lstRavenclaw.ItemsSource = (YoureAWizard.Ravenclaw.Members);
            lstSlytherin.ItemsSource = (YoureAWizard.Slytherin.Members);
        }
    }
    

}
