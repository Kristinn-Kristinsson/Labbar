using System;
using System.Windows;
using System.Collections.Generic;
namespace HarryPotter1
{
    public partial class MainWindow
    {
        public class Slytherin : House
        {
            public Slytherin()
            {
                this.HouseGhost = "Blodige Baronen";
                this.Mascot = "Orm";
                Members = (Members == null) ? new List<string>() : Members;
                this.Password = "Slinka igenom";
            }

            public override string ChangePassword(string pass)
            {   
                GeneralMethods gm = new GeneralMethods();
                string shortTimePass;
                if (pass == Password)
                {
                    shortTimePass = " ";
                    gm.GettingArray(shortTimePass);
                    if (gm.CheckLetter(shortTimePass[0]) == false && shortTimePass.Length > 7
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