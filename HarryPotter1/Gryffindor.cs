using System;
using System.Windows;
using System.Collections.Generic;
namespace HarryPotter1
{
    public partial class MainWindow
    {
        public class Gryffindor : House 
        {
            //readonly Wizard member = new Wizard();
            public Gryffindor()
            {
                this.HouseGhost = "Nästan Huvudlöse Nick";
                this.Mascot = "Lejon";
                this.Password = "Alltid djärv";
                Members = (Members == null) ? new List<string>() : Members;
                
            }

            
            public void Gryffindorian(Wizard wiz)
            {
                AddingMembers(wiz);
            }




        }
    }
}
