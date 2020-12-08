using System.Collections.Generic;
using System.Linq;
using System;
using System.Windows.Input;
using System.Windows.Controls;


namespace GodisKalkylator
{

    public class CandyCalculator
    {
        public List<Person> ThePeople { get; set; }
        public char[] FirstChar { get; set; }
        public int[] FirstCharArray { get; set; }
        public string TopName { get; set; }
        public CandyCalculator()
        {
            ThePeople = new List<Person>();
        }
        
        public void CalculateCandy(int candy, int counter)
        {
            int divide = candy / counter;
            int rem = candy % counter;
            foreach (Person p in ThePeople)
            {

                p.Candies = divide;
                if (rem > 0)
                {
                    p.Candies++;
                    rem--;
                }
            }
        }

        public void CalculateByAge()
        {
            ThePeople = ThePeople.OrderBy(x => x.Age).ToList();
        }

        public void CalculateByFirstName()
        {
            ThePeople = ThePeople.OrderBy(x => x.FirstName).ToList();
        }
        public void CalculateByLastName()
        {
            ThePeople = ThePeople.OrderBy(x => x.LastName).ToList();
        }

        
        
    }
    

}
