namespace HarryPotter1
{
    public class Gryffindor : House 
    {
        
        public string NameGrf { get; set; }
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
        public override string ToString()
        {
            return this.GetType().Name;
        }
    }
}
