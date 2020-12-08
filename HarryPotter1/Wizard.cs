namespace HarryPotter1
{

    public class Wizard
    {
        public string[] BloodGroups { get; set; }
        public string Name { get; set; }
        public bool DeathEater { get; set; }
        public bool DumbledoresArmy { get; set; }
        public string BloodStatus { get; set; }
        Wand Wand { get; set; }

        GeneralMethods gm = new GeneralMethods();


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

        public Wizard(string name)
        {
            Name = name;   
            BloodGroups = new string[4] {  "Halvblod", "Mugglarfödd", "Fullblod", "Okänt" };
        }

        public Wizard()
        {

        }
        public override string ToString()
        {
            return this.GetType().Name;
        }
    }
}

