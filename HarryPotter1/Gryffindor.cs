using System;
using System.Windows;
namespace HarryPotter1
{
    public partial class MainWindow
    {
        public class Gryffindor : House
        {
            public Gryffindor()
            {
                this.HouseGhost = "Nästan Huvudlöse Nick";
                this.Mascot = "Lejon";
                this.Members = 0;
                this.Password = "Alltid djärv";
            }

            public string ChangePassword(string pass)
            {
                GeneralMethods gm = new GeneralMethods();
                string shortTimePass;
                if (pass == Password)
                {
                    shortTimePass = " ";
                    gm.GettingArray(shortTimePass);
                    if (gm.CheckLetter(shortTimePass[0]) == true && shortTimePass.Length > 4
                        && gm.CheckLetter(shortTimePass[shortTimePass.Length - 1]) == false)
                    {
                        Password = "";
                        Password = shortTimePass;
                        return Password;
                    }
                    else
                    {
                        return Password;
                    }

                }
                return Password;


            }
        }
    }
}
