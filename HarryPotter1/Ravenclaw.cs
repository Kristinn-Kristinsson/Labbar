using System;
using System.Windows;
namespace HarryPotter1
{
    public partial class MainWindow
    {
        public class Ravenclaw : House
        {
            public Ravenclaw()
            {
                this.HouseGhost = "Filius Flitwick";
                this.Mascot = "Örn";
                this.Members = 0;
                this.Password = "Intellekt framför allt";
            }

            public string ChangePassword(string pass)
            {
                GeneralMethods gm = new GeneralMethods();
                string shortTimePass;
                if (pass == Password)
                {
                    shortTimePass = "Not gonna work";
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
