using System;
using System.Linq;

namespace HarryPotter1
{
    public partial class MainWindow
    {
        public class Wizard : Wand
        {
            public string[] BloodGroups { get; set; }
            public string Name { get; set; }
            public bool DeathEater { get; set; }
            public bool DumbledoresArmy { get; set; }
            public string BloodStatus { get; set; }
            public object[] PersonsWand { get; set; }


            public string ArmyNow()
            {
                string status;
                if (DeathEater == true && DumbledoresArmy == true)
                {
                    DeathEater = false;
                    DumbledoresArmy = false;
                    status = "Neither";
                    return status;
                }
                else if (DumbledoresArmy == true)
                {
                    DeathEater = false;
                    status = "in Dumbledores Army";
                    return status;
                }
                else if (DeathEater == true)
                {
                    DumbledoresArmy = false;
                    status = "is a Death Eater";
                    return status;
                }
                else
                {
                    status = "Neither";
                    return status;
                }



            }

            public Wizard(string name, int bloodstatus, bool deathEater, bool dumbledoresArmy, object[] wand, Wand theWand)
            {
                Name = name;
                BloodGroups = new string[4] { "renblod", "halvblod", "mugglarfödd", "okänt" };
                string blood = BloodGroups[bloodstatus];
                BloodStatus = blood;
                DeathEater = deathEater;
                DumbledoresArmy = dumbledoresArmy;
                PersonsWand = wand;
                void PersonalWand(object[] wand)
                {
                    theWand.Wood = PersonsWand[0].ToString();
                    theWand.Core = PersonsWand[1].ToString();
                    theWand.Size = Convert.ToInt32(PersonsWand[2]);
                    PersonsWand = new object[3] { $"{theWand.Wood}", $"{theWand.Core}", $"{theWand.Size}" };
                }
                PersonalWand(wand);
                Core = theWand.Core;
                Wood = theWand.Wood;
                Size = theWand.Size;


            }

            public Wizard()
            {

            }
        }

    }
}