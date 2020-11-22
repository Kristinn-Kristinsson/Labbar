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
namespace Uppgift15
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

        StringBuilder jibber = new StringBuilder();
        StringBuilder pirateSpeak = new StringBuilder();
        int nrOfVowels = 0;
        char checkVowel, giveBack, extraVow = 'o', extraChar;
        bool pirateVow;
        string newText, pirateText;
        char[] originalText;
        char[] Lvowels = new char[9] { 'a', 'ä', 'e', 'i', 'o', 'u', 'å', 'ö', 'y' };
        char[] Uvowels = new char[9] { 'A', 'Ä', 'E', 'I', 'O', 'U', 'Å', 'Ö', 'Y' };

        

        private int NumberOfVowels(char nrVow)
        {
            if(Char.IsUpper(nrVow))
                foreach (char vow in Uvowels)
                {
                    if (nrVow == vow)
                    {
                        nrOfVowels++;
                    }
                }
            else
            {
                foreach (char vow in Lvowels)
                {
                    if (nrVow == vow)
                    {
                        nrOfVowels++;
                    }
                }
            }
            return nrOfVowels;
        }
        private char IsVowel(char textChar)
        {
            if(Char.IsUpper(textChar))
                foreach (char vow in Uvowels)
                {
                    if (textChar == vow)
                    {
                        textChar =  'Ö';
                    }
                }
            else
            {
                foreach (char vow in Lvowels)
                {
                    if (textChar == vow)
                    {
                        textChar = 'ö';
                    }
                }

            }
            return giveBack = textChar;
        }
        private string PirateseCon(char textChar)
        {
            if (char.IsWhiteSpace(textChar))
            {
                pirateText = textChar.ToString();
                return pirateText;
            }
            if (Char.IsUpper(textChar))
                 foreach(char vow in Uvowels)
                {
                    if (textChar == vow)
                    {
                    pirateVow = true;
                    }
                }
            else
            {
                foreach (char vow in Lvowels)
                {
                    if (textChar == vow)
                    {
                        pirateVow = true;
                    }
                }

            }
            if (pirateVow == true)
            {
                pirateSpeak.Append(textChar);
                pirateVow = false;
            }
            else
            {
                extraChar = textChar;
                pirateSpeak.Append(textChar);
                pirateSpeak.Append(extraVow);
                pirateSpeak.Append(extraChar);
                pirateVow = false;
            }
            pirateText = pirateSpeak.ToString();
            pirateSpeak.Clear();
            return pirateText;
        }
        private string Jibberish()
        {
            originalText = txtOriginalText.Text.ToCharArray();

            for (int i = 0; i < originalText.Length; i++)
            {
                checkVowel = Convert.ToChar(originalText.GetValue(i));
                IsVowel(checkVowel);
                jibber.Append(giveBack);
                NumberOfVowels(checkVowel);
            }

            return newText = jibber.ToString();
        }
        private string Piratese()
        {
            originalText = txtOriginalText.Text.ToCharArray();

            for (int i = 0; i < originalText.Length; i++)
            {
                checkVowel = Convert.ToChar(originalText.GetValue(i));
                PirateseCon(checkVowel);
                jibber.Append(pirateText);
                NumberOfVowels(checkVowel);
            }

            return newText = jibber.ToString();
        }
        private void btnConvertText_Click(object sender, RoutedEventArgs e)
        {
            Jibberish();
            txbJibberishText.Text = newText;
            newText = "";
            pirateSpeak.Clear();
            jibber.Clear();
            txbNrOfVowels.Text = $"Antal vokaler: {nrOfVowels}";
            nrOfVowels = 0;
        }

        private void btnPiratese_Click(object sender, RoutedEventArgs e)
        {
            Piratese();
            txbJibberishText.Text = newText;
            newText = "";
            txbNrOfVowels.Text = $"Antal vokaler: {nrOfVowels}";
            nrOfVowels = 0;
            pirateSpeak.Clear();
            jibber.Clear();
        }

        private void txtOriginalText_GotKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            txtOriginalText.Clear();
            nrOfVowels = 0;
            newText = "";
            txbJibberishText.Clear();
            pirateSpeak.Clear();
            jibber.Clear();
            
        }
    }
}
