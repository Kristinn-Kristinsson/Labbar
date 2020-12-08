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
        public void SortingHat(Wizard wiz)
        {
            if (TotalWizards % 4 == 0)
            {
                Hufflepuff.AddingMembers(wiz);
                TotalWizards++;
                return;
            }
            else if (TotalWizards % 4 == 1)
            {
                Ravenclaw.AddingMembers(wiz);
                TotalWizards++;
                return;
            }
            else if (TotalWizards % 4 == 2)
            {
                Gryffindor.AddingMembers(wiz);
                TotalWizards++;
                return;
            }
            else
            {
                Slytherin.AddingMembers(wiz);
                TotalWizards++;
                return;
            }

        }

        public override string ToString()
        {
            return this.GetType().Name;
        }

        public static ComboBox cbHouses = new ComboBox();

        

    }




}
