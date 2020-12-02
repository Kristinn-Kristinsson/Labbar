using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GodisKalkylator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        public class Person
        {
            public int Age { get; set; }
            public int Candies { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public object ThisPerson {;

            

            

            public Person(int age, int candies, string firstName, string lastName)
            {
                object[] person = new object[4];
                Age = age;
                Candies = candies;
                FirstName = firstName;
                LastName = lastName;
                person.Append(age); person.Append(candies); person.Append(firstName); person.Append(lastName);
                ThisPerson = person;
            }

            public string ToString()
            {
                string aboutPerson;
                aboutPerson = $"{}"
            }
        }
    }
}
