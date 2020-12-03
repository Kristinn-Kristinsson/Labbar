namespace HarryPotter1
{

    public class Wizard
    {
        private string[] BloodGroups { get; set; }
        public string Name { get; set; }
        public bool DeathEater { get; set; }
        public bool DumbledoresArmy { get; set; }
        public string BloodStatus { get; set; }
        Wand Wand { get; set; }



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

        public Wizard(string name, int bloodstatus, bool deathEater, bool dumbledoresArmy, Wand personalWand)
        {
            Name = name;
            BloodGroups = new string[4] { "renblod", "halvblod", "mugglarfödd", "okänt" };
            string blood = BloodGroups[bloodstatus];
            BloodStatus = blood;
            DeathEater = deathEater;
            DumbledoresArmy = dumbledoresArmy;
            Wand = personalWand;


        }

        public Wizard()
        {

        }
    }
}

