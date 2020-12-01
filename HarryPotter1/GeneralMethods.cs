using System.Linq;

namespace HarryPotter1
{
    public partial class MainWindow
    {
        public class GeneralMethods
        {
            public static readonly char[] Vowels = { 'a', 'A', 'e', 'E', 'y', 'Y', 'u', 'U', 'i', 'I', 'o', 'O', 'ö', 'Ö', 'ä', 'Ä', 'å', 'Å' };
            public char[] PasswordToArray { get; set; }

            public char[] GettingArray(string pass)
            {
                PasswordToArray = pass.ToArray();
                return PasswordToArray;
            }

            public bool CheckLetter(char vow)
            {
                foreach (char letter in Vowels)
                    if (vow == letter)
                    {
                        return true;
                    }
                return false;
            }

            public GeneralMethods()
            {

            }
        }
    }
}

