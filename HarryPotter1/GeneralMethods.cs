using System.Linq;
using System;

namespace HarryPotter1
{

    public class GeneralMethods
    {
        Random random = new Random();
        int randomThrow;
        public static readonly char[] Vowels = { 'a', 'A', 'e', 'E', 'y', 'Y', 'u', 'U', 
            'i', 'I', 'o', 'O', 'ö', 'Ö', 'ä', 'Ä', 'å', 'Å' };
        public char[] PasswordToArray { get; set; }

        public char[] GettingArray(string pass)
        {
            PasswordToArray = pass.ToArray();
            return PasswordToArray;
        }

        public bool CheckLetter(char vow)
        {
            foreach (char letter in Vowels)
                if (vow == letter)
                {
                    return true;
                }
            return false;
        }

        public GeneralMethods()
        {

        }

        public void WizardBlood(Wizard wiz)
        {
            randomThrow = random.Next(0, 101);
            if (randomThrow <= 60)
            {
                wiz.BloodStatus = wiz.BloodGroups[0];
                
            }
            else if (randomThrow <= 85)
            {
                wiz.BloodStatus = wiz.BloodGroups[1];
                
            }
            else if (randomThrow <= 95)
            {
                wiz.BloodStatus = wiz.BloodGroups[2];
            }
            else
            {
                wiz.BloodStatus = wiz.BloodGroups[3];
            }
        }

        public bool DeathEater(Wizard wiz)
        {
            randomThrow = random.Next(0, 101);
            {

                if (randomThrow <= 25 && ("Halvblod" == wiz.BloodStatus || "Mugglarfödd" == wiz.BloodStatus))
                {
                    return wiz.DeathEater = true;
                }
                else if (randomThrow <= 15 && "Okänt" == wiz.BloodStatus)
                    return wiz.DeathEater = true;
                else if (randomThrow <= 60 && "Fullblod" == wiz.BloodStatus)
                    return wiz.DeathEater = true;
                else
                    wiz.DeathEater = false;

            }
            return true;
        }

        public bool DumbledoresArmy(Wizard wiz)
        {
            randomThrow = random.Next(0, 101);
            {
                if (randomThrow <= 45 && ("Halvblod" == wiz.BloodStatus || 
                    "Mugglarfödd" == wiz.BloodStatus || "Okänt" == wiz.BloodStatus))
                {
                    return wiz.DumbledoresArmy = true;
                }
                else if (randomThrow <= 15 && "Fullblod" == wiz.BloodStatus)
                    return wiz.DumbledoresArmy = true;
                else
                    wiz.DumbledoresArmy = false;
            }
            return true;
        }
        
        
    }

}

