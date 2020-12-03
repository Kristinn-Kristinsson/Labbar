using System.Collections.Generic;

namespace HarryPotter1
{
        public abstract class House
        {
            public string HouseGhost { get; set; }
            public string Mascot { get; set; }
            public string Password { get; set; }
            
            public List<Wizard> Members { get; set; }
            
            public int TotalMembers { get; set; }
            


        public House()
        {
            Members = new List<Wizard>();
        }

        public bool SetPassword(string pass, string shortTimePass)
        {
            if (pass == Password && HasCorrectPasswordFormat(shortTimePass) == true)
            {
                return true;

            }
            else
                return false;
        }

        public virtual bool HasCorrectPasswordFormat(string shortTimePass)

        {
            GeneralMethods gm = new GeneralMethods();
            gm.GettingArray(shortTimePass);
            if (gm.CheckLetter(shortTimePass[0]) == true && shortTimePass.Length > 4
                && gm.CheckLetter(shortTimePass[shortTimePass.Length - 1]) == false)
            {
                Password = "";
                Password = shortTimePass;
                return true;
            }
            else
            {
                return false;
            }
        }

        
        public void AddingMembers(Wizard w)
        {
            Members.Add(w);
        }
    }
}

