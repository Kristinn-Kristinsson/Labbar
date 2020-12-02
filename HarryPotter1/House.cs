using System;
using System.Collections.Generic;

namespace HarryPotter1
{
    public partial class MainWindow
    {
        public abstract class House : Wizard
        {
            public string HouseGhost { get; set; }
            public string Mascot { get; set; }
            private string _Password;
            
            public List<string> Members { get; set; }
            
            public int TotalMembers { get; set; }
            


            public House()
            {

            }

            public string Password
            {
                get
                { return _Password; }
                set
                { _Password = value; }
            }

            public virtual string ChangePassword(string pass)
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
            public void AddingMembers(Wizard w)
            {
                this.Members.Add(w.Name);
            }
        }
    }
}

