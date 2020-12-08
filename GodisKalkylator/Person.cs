using System.Collections.Generic;

namespace GodisKalkylator
{

    public class Person
    {
        public int Age { get; set; }
        public int Candies { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        //public List<Person> People { get; set; }
        public string AboutPerson { get; set; }

        public Person()
        {
        }



        public Person(int age, string firstName, string lastName)
        {

            Age = age;
            FirstName = firstName;
            LastName = lastName;
        }

        public string PersonToString(Person p)
        {
            return AboutPerson = $"{p.FirstName} {p.LastName} ({p.Age} år): {p.Candies} st";
        }
    }
}
