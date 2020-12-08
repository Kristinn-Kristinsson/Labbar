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
            

        }
        public string filename = "YoureAWizard.json";


        Hogwarts hogwarts = new Hogwarts();
        GeneralMethods gm = new GeneralMethods();
        
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
            chkArmy.IsChecked = false;
            chkDeatheater.IsChecked = false;
            Wizard wiz = new Wizard(txtNewWizardName.Text);
            gm.WizardBlood(wiz);
            gm.DeathEater(wiz);
            gm.DumbledoresArmy(wiz);
            hogwarts.SortingHat(wiz);
            txtNewWizardName.Clear();
            txtName.Text = wiz.Name;
            if (wiz.DeathEater == true)
                chkDeatheater.IsChecked = true;
            if (wiz.DumbledoresArmy == true)
                chkArmy.IsChecked = true;
            //int wizardJoin;
            if (hogwarts.Hufflepuff.Members.Contains(wiz) == true)
            {
                //wizardJoin = hogwarts.Hufflepuff.Members.Count() -1;
                lstHufflepuff.Items.Add(wiz.Name);
                MessageBox.Show($"Välkommen {wiz.Name}! Du är nu del av Hufflepuff, nr {hogwarts.Hufflepuff.Members.Count}" +
                    $" i det Huset och nr \n{hogwarts.TotalWizards} i hela Hogwarts! Lösenordet till hemmet är " +
                    $"{hogwarts.Hufflepuff.Password}\n (skriv det när, du får inte se det igen!) och " +
                    $"{hogwarts.Hufflepuff.HouseGhost}\n ser fram emot att träffa dig.");
                
                lblHufflepuffMascot.Content = hogwarts.Hufflepuff.Mascot;
            }
            else if (hogwarts.Ravenclaw.Members.Contains(wiz) == true)
            {
                //wizardJoin = hogwarts.Ravenclaw.Members.Count() -1;
                lstRavenclaw.Items.Add(wiz.Name);
                MessageBox.Show($"Välkommen {wiz.Name}! Du är nu del av Ravenclaw, nr {hogwarts.Ravenclaw.Members.Count}" +
                    $" i det Huset och nr \n{hogwarts.TotalWizards} i hela Hogwarts! Lösenordet till hemmet är " +
                    $"{hogwarts.Ravenclaw.Password}\n (skriv det när, du får inte se det igen!) och " +
                    $"{hogwarts.Ravenclaw.HouseGhost}\n ser fram emot att träffa dig.");
                lblRavenclawMascot.Content = hogwarts.Ravenclaw.Mascot;
            }
            else if (hogwarts.Gryffindor.Members.Contains(wiz) == true)
            {
                //hogwarts.Gryffindor.Members[wizardJoin].Name
                //wizardJoin = hogwarts.Gryffindor.Members.Count() -1;
                lstGryffindor.Items.Add(wiz.Name);
                MessageBox.Show($"Välkommen {wiz.Name}! Du är nu del av Gryffindor, nr {hogwarts.Gryffindor.Members.Count}" +
                    $" i det Huset och nr \n{hogwarts.TotalWizards} i hela Hogwarts! Lösenordet till hemmet är " +
                    $"{hogwarts.Gryffindor.Password}\n (skriv det när, du får inte se det igen!) och " +
                    $"{hogwarts.Gryffindor.HouseGhost}\n ser fram emot att träffa dig.");
                lblGryffindorMascot.Content = hogwarts.Gryffindor.Mascot;
            }
            else if (hogwarts.Slytherin.Members.Contains(wiz) == true)
            {
                //wizardJoin = hogwarts.Slytherin.Members.Count() -1;
                lstSlytherin.Items.Add(wiz.Name);
                MessageBox.Show($"Välkommen {wiz.Name}! Du är nu del av Slytherin, nr {hogwarts.Slytherin.Members.Count}" +
                    $" i det Huset och nr \n{hogwarts.TotalWizards} i hela Hogwarts! Lösenordet till hemmet är " +
                    $"{hogwarts.Slytherin.Password}\n (skriv det när, du får inte se det igen!) och " +
                    $"{hogwarts.Slytherin.HouseGhost}\n ser fram emot att träffa dig.");
                lblSlytherinMascot.Content = hogwarts.Slytherin.Mascot;
            }
            else
                MessageBox.Show("Du, jag kan inte ställa dig i något elevhem! \n Konstigt.");
        }

        private void lstHufflepuff_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            chkArmy.IsChecked = false;
            chkDeatheater.IsChecked = false;
            if (lstHufflepuff.SelectedItem != null)
            {
                txtName.Text =  lstHufflepuff.SelectedItem.ToString();
                for (int i = 0; i < hogwarts.Hufflepuff.Members.Count(); i++)
                    if (hogwarts.Hufflepuff.Members[i].Name == txtName.Text)
                        if (hogwarts.Hufflepuff.Members[i].DeathEater == true)
                        {
                            chkDeatheater.IsChecked = true;
                            if (hogwarts.Hufflepuff.Members[i].DumbledoresArmy == true)
                            {
                                chkArmy.IsChecked = true;
                            }
                            
                        }
                        
            }
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
            hogwarts = YoureAWizard;
            for(int i = 0; i < YoureAWizard.Gryffindor.Members.Count(); i++)
                lstGryffindor.Items.Add(YoureAWizard.Gryffindor.Members[i].Name);
            for (int i = 0; i < YoureAWizard.Hufflepuff.Members.Count(); i++)
                lstHufflepuff.Items.Add(YoureAWizard.Hufflepuff.Members[i].Name);
            for (int i = 0; i < YoureAWizard.Ravenclaw.Members.Count(); i++)
                lstRavenclaw.Items.Add(YoureAWizard.Ravenclaw.Members[i].Name);
            for (int i = 0; i < YoureAWizard.Slytherin.Members.Count(); i++)
                lstSlytherin.Items.Add(YoureAWizard.Slytherin.Members[i].Name);
        }
    }
    

}
