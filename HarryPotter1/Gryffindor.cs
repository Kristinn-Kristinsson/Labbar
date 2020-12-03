namespace HarryPotter1
{
    public class Gryffindor : House 
    {
        public Gryffindor()
        {
            this.HouseGhost = "Nästan Huvudlöse Nick";
            this.Mascot = "Lejon";
            this.Password = "Alltid djärv";                
        }

        public void Gryffindorian(Wizard wiz)
        {
            AddingMembers(wiz);
        }
    }
}
