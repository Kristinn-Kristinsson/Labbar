namespace HarryPotter1
{
    public class Ravenclaw : House
    {
        public Ravenclaw()
        {
            this.HouseGhost = "Filius Flitwick";
            this.Mascot = "Örn";
            this.Password = "Intellekt framför allt";
        }

        public void Ravenclawer(Wizard wiz)
        {
            AddingMembers(wiz);
        }
        public override string ToString()
        {
            return this.GetType().Name;
        }
    }
}
