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

namespace Uppgift13
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        char c, x;
        int count;
        public MainWindow()
        {
            InitializeComponent();
        }
        private void txtInputText_GotKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            txtInputText.Clear();
        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            c = char.Parse(txtSearch.Text);
            //char[] ch = new char [txtInputText.Text.Length];
            char[] ch = ( txtInputText.Text.ToCharArray());

            for (int i = 0; i <ch.Length; i++)
            {
                x = char.ToLower(ch[i]);
                if (x == c)
                {
                    count += 1;
                }
                
            }
            txbResults.Text = $"Hittade bokstaven {c} {count} gånger.";
            count = 0;
        }


        //private void txtInputText_LostKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        //{
        //    txtInputText.
        //}


    }
}
