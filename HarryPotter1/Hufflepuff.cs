using System;
using System.Windows;
using System.Collections.Generic;
namespace HarryPotter1
{
    public partial class MainWindow
    {
        public class Hufflepuff : House
        {
            public Hufflepuff()
            {
                this.HouseGhost = "Den Tjocke Munkbrodern";
                this.Mascot = "Grävling";
                Members = (Members == null) ? new List<string>() : Members;
                this.Password = "Allt är jämnställt";
            }


        }
    }
}
