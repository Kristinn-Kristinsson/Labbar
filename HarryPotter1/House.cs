using System.Collections.Generic;
using System.Linq;
using System;

namespace HarryPotter1
{
        public abstract class House
        {
            public string HouseGhost { get; set; }
            public string Mascot { get; set; }
            public string Password { get; set; }
            
            public List<Wizard> Members { get; set; }

            public static readonly char[] Vowels = { 'a', 'A', 'e', 'E', 'y', 'Y', 'u', 'U',
            'i', 'I', 'o', 'O', 'ö', 'Ö', 'ä', 'Ä', 'å', 'Å' };
            public char[] PasswordToArray { get; set; }




        public House()
        {
            Members = new List<Wizard>();
        }
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

        public bool SetPassword(string pass, string shortTimePass)
        {
            if (pass == Password && HasCorrectPasswordFormat(shortTimePass) == true)
            {
                return true;
            }
            else
                return false;
        }

        public virtual bool HasCorrectPasswordFormat(string shortTimePass)

        {
            GettingArray(shortTimePass);
            if (CheckLetter(shortTimePass[0]) == true && shortTimePass.Length > 4
                && CheckLetter(shortTimePass[shortTimePass.Length - 1]) == false)
            {
                Password = "";
                Password = shortTimePass;
                return true;
            }
            else
            {
                return false;
            }
        }

        
        public void AddingMembers(Wizard w)
        {
            Members.Add(w);
        }
    }
}

