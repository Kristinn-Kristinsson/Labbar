using System;
using System.Windows;
using System.Collections.Generic;
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
                Members = (Members == null) ? new List<string>() : Members;
                this.Password = "Intellekt framför allt";
            }


        }
    }
}
