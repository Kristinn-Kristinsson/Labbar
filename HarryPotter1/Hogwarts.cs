using System.Windows.Controls;

namespace HarryPotter1
{

    public class Hogwarts
    {
        public Gryffindor Gryffindor { get; set; }
        public Hufflepuff Hufflepuff { get; set; }
        public Ravenclaw Ravenclaw { get; set; }
        public Slytherin Slytherin { get; set; }
        public int TotalWizards = 0;

        public Hogwarts()
        {
            this.Gryffindor = new Gryffindor();
            this.Hufflepuff = new Hufflepuff();
            this.Ravenclaw = new Ravenclaw();
            this.Slytherin = new Slytherin();
        }
        public House SortingHat(Wizard wiz)
        {
            if (TotalWizards % 4 == 0)
            {
                Hufflepuff.AddingMembers(wiz);
                TotalWizards++;
                return Hufflepuff;
            }
            else if (TotalWizards % 4 == 1)
            {
                Ravenclaw.AddingMembers(wiz);
                TotalWizards++;
                return Ravenclaw;
            }
            else if (TotalWizards % 4 == 2)
            {
                Gryffindor.AddingMembers(wiz);
                TotalWizards++;
                return Gryffindor;
            }
            else
            {
                Slytherin.AddingMembers(wiz);
                TotalWizards++;
                return Slytherin;
            }

        }

        public override string ToString()
        {
            return this.GetType().Name;
        }

        

        

    }




}
