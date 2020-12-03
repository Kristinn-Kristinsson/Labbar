namespace HarryPotter1
{
    public class Hufflepuff : House
    {
        public Hufflepuff()
        {
            this.HouseGhost = "Den Tjocke Munkbrodern";
            this.Mascot = "Grävling";
            this.Password = "Allt är jämnställt";
        }

        public void HufflePuffer(Wizard wiz)
        {
            AddingMembers(wiz);
        }
    }
}
