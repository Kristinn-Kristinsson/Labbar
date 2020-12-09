using System;

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

        Random random = new Random();
        int randomThrow;


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
            BloodStatus = WizardBlood(); // smidigt satt att fixa
            DeathEater = IsDeathEater();
            DumbledoresArmy = IsDumbledoresArmy();
        }


        public override string ToString()
        {
            return this.GetType().Name;
        }
        public string WizardBlood()
        {
            randomThrow = random.Next(0, 101);
            if (randomThrow <= 60)
            {
                return BloodGroups[0];
            }
            else if (randomThrow <= 85)
            {
                return BloodGroups[1];

            }
            else if (randomThrow <= 95)
            {
                return BloodGroups[2];
            }
            else
            {
                return BloodGroups[3];
            }
        }

        public bool IsDeathEater()
        {
            randomThrow = random.Next(0, 101);
            {

                if (randomThrow <= 25 && ("Halvblod" == BloodStatus || "Mugglarfödd" == BloodStatus))
                {
                    return true;
                }
                else if (randomThrow <= 15 && "Okänt" == BloodStatus)
                    return true;
                else if (randomThrow <= 60 && "Fullblod" == BloodStatus)
                    return DeathEater = true;
                else
                    return false;

            }
            
        }

        public bool IsDumbledoresArmy()
        {
            randomThrow = random.Next(0, 101);
            {
                if (randomThrow <= 45 && ("Halvblod" == BloodStatus ||
                    "Mugglarfödd" == BloodStatus || "Okänt" == BloodStatus))
                {
                    return true;
                }
                else if (randomThrow <= 15 && "Fullblod" == BloodStatus)
                    return true;
                else
                    return false;
            }
            
        }
    }
}

