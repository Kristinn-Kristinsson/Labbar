namespace HarryPotter1
{

    public class Slytherin : House
    {
        public Slytherin()
        {
            this.HouseGhost = "Blodige Baronen";
            this.Mascot = "Orm";
            this.Password = "Slinka igenom";
        }
        

        public override bool HasCorrectPasswordFormat(string shortTimePass)
        {
            GeneralMethods gm = new GeneralMethods();
            gm.GettingArray(shortTimePass);
            if (gm.CheckLetter(shortTimePass[0]) == false && shortTimePass.Length > 7
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
        public override string ToString()
        {
            return this.GetType().Name;
        }

    }
}