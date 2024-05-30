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

namespace WPF29._1
{
    /// <summary>
    /// Логика взаимодействия для Page2.xaml
    /// </summary>
    public partial class Page2 : Page
    {
        string shrift = "normal";
        string temaFona = "white";
        public Page2(string temaF, string stht)
        {
            InitializeComponent();
            temaFona = temaF;
            shrift = stht;
            if(temaFona == "white")
            {
                fon.Background = new SolidColorBrush(Colors.White);
                but1.Background = new SolidColorBrush(Colors.Aqua);
                white.Background = new SolidColorBrush(Colors.Aqua);
                dark.Background = new SolidColorBrush(Colors.Aqua);
            }
            else
            {
                fon.Background = new SolidColorBrush(Colors.Black);
                but1.Background = new SolidColorBrush(Colors.Orange);
                white.Background = new SolidColorBrush(Colors.Orange);
                dark.Background = new SolidColorBrush(Colors.Orange);
                normal.Background = new SolidColorBrush(Colors.Orange);
                kursive.Background = new SolidColorBrush(Colors.Orange);
            }
            if(shrift == "normal")
            {
                but1.FontStyle = FontStyles.Normal;
                white.FontStyle = FontStyles.Normal;
                dark.FontStyle = FontStyles.Normal;
                normal.FontStyle = FontStyles.Normal;
                kursive.FontStyle = FontStyles.Normal;
                if(temaFona == "white")
                {
                    normal.Background = new SolidColorBrush(Colors.Aqua);
                    kursive.Background = new SolidColorBrush(Colors.Aqua);
                }
                else
                {
                    normal.Background = new SolidColorBrush(Colors.Orange);
                    kursive.Background = new SolidColorBrush(Colors.Orange);
                }
            }
            else
            {
                but1.FontStyle = FontStyles.Italic;
                white.FontStyle = FontStyles.Italic;
                dark.FontStyle = FontStyles.Italic;
                normal.FontStyle = FontStyles.Italic;
                kursive.FontStyle = FontStyles.Italic;
                if (temaFona == "white")
                {
                    normal.Background = new SolidColorBrush(Colors.Aqua);
                    kursive.Background = new SolidColorBrush(Colors.Aqua);
                }
                else
                {
                    normal.Background = new SolidColorBrush(Colors.Orange);
                    kursive.Background = new SolidColorBrush(Colors.Orange);
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Page1(temaFona, shrift));
        }

        private void but1_MouseEnter(object sender, MouseEventArgs e)
        {
            if (temaFona == "white")
            {
                but1.Background = new SolidColorBrush(Colors.Aqua);
            }
            else
            {
                but1.Background = new SolidColorBrush(Colors.Orange);
            }
        }

        private void but1_MouseLeave(object sender, MouseEventArgs e)
        {
            if (temaFona == "white")
            {
                but1.Background = new SolidColorBrush(Colors.Aqua);
            }
            else
            {
                but1.Background = new SolidColorBrush(Colors.Orange);
            }
        }

        private void white_Click(object sender, RoutedEventArgs e)
        {
            white.Background = new SolidColorBrush(Colors.Aqua);
            fon.Background = new SolidColorBrush(Colors.White);
            dark.Background = new SolidColorBrush(Colors.Aqua);
            but1.Background = new SolidColorBrush(Colors.Aqua);
            kursive.Background = new SolidColorBrush(Colors.Aqua);
            normal.Background = new SolidColorBrush(Colors.Aqua);
            temaFona = "white";
        }

        private void dark_Click(object sender, RoutedEventArgs e)
        {
            dark.Background = new SolidColorBrush(Colors.Orange);
            white.Background = new SolidColorBrush(Colors.Orange);
            fon.Background = new SolidColorBrush(Colors.Black);
            but1.Background = new SolidColorBrush(Colors.Orange);
            kursive.Background = new SolidColorBrush(Colors.Orange);
            normal.Background = new SolidColorBrush(Colors.Orange);
            temaFona = "dark";
        }

        private void white_MouseEnter(object sender, MouseEventArgs e)
        {
            if (temaFona == "white")
            {
                white.Background = new SolidColorBrush(Colors.Aqua);
            }
            else
            {
                white.Background = new SolidColorBrush(Colors.Orange);
            }
        }

        private void white_MouseLeave(object sender, MouseEventArgs e)
        {
            if (temaFona == "white")
            {
                white.Background = new SolidColorBrush(Colors.Aqua);
            }
            else
            {
                white.Background = new SolidColorBrush(Colors.Orange);
            }
        }

        private void dark_MouseEnter(object sender, MouseEventArgs e)
        {
            if (temaFona == "white")
            {
                dark.Background = new SolidColorBrush(Colors.Aqua);
            }
            else
            {
                dark.Background = new SolidColorBrush(Colors.Orange);
            }
        }

        private void dark_MouseLeave(object sender, MouseEventArgs e)
        {
            if (temaFona == "white")
            {
                dark.Background = new SolidColorBrush(Colors.Aqua);
            }
            else
            {
                dark.Background = new SolidColorBrush(Colors.Orange);
            }
        }

        private void kursive_Click(object sender, RoutedEventArgs e)
        {
            but1.FontStyle = FontStyles.Italic;
            white.FontStyle = FontStyles.Italic;
            dark.FontStyle = FontStyles.Italic;
            normal.FontStyle = FontStyles.Italic;
            kursive.FontStyle = FontStyles.Italic;
            shrift = "kursive";
            if(temaFona == "white")
            {
                kursive.Background = new SolidColorBrush(Colors.Aqua);
                normal.Background = new SolidColorBrush(Colors.Aqua);
            }
            else
            {
                kursive.Background = new SolidColorBrush(Colors.Orange);
                normal.Background = new SolidColorBrush(Colors.Orange);
            }
        }

        private void normal_Click(object sender, RoutedEventArgs e)
        {
            but1.FontStyle = FontStyles.Normal;
            white.FontStyle = FontStyles.Normal;
            dark.FontStyle = FontStyles.Normal;
            normal.FontStyle = FontStyles.Normal;
            kursive.FontStyle = FontStyles.Normal;
            shrift = "normal";
            if (temaFona == "white")
            {
                normal.Background = new SolidColorBrush(Colors.Aqua);
                kursive.Background = new SolidColorBrush(Colors.Aqua);
            }
            else
            {
                normal.Background = new SolidColorBrush(Colors.Orange);
                kursive.Background = new SolidColorBrush(Colors.Orange);
            }
        }

        private void kursive_MouseEnter(object sender, MouseEventArgs e)
        {
            if (temaFona == "white")
            {
                kursive.Background = new SolidColorBrush(Colors.AliceBlue);
            }
            else
            {
                kursive.Background = new SolidColorBrush(Colors.Orange);
            }
        }

        private void kursive_MouseLeave(object sender, MouseEventArgs e)
        {
            if (temaFona == "white")
            {
                kursive.Background = new SolidColorBrush(Colors.Aqua);
            }
            else
            {
                kursive.Background = new SolidColorBrush(Colors.Orange);
            }
        }

        private void normal_MouseEnter(object sender, MouseEventArgs e)
        {
            if (temaFona == "white")
            {
                if (shrift == "normal")
                {
                    normal.Background = new SolidColorBrush(Colors.Aqua);
                }
                else
                {
                    normal.Background = new SolidColorBrush(Colors.Aqua);
                }
            }
            else
            {
                if (shrift == "normal")
                {
                    normal.Background = new SolidColorBrush(Colors.Orange);
                }
                else
                {
                    normal.Background = new SolidColorBrush(Colors.Orange);
                }
            }
        }

        private void normal_MouseLeave(object sender, MouseEventArgs e)
        {
            if (temaFona == "white")
            {
                if (shrift == "normal")
                {
                    normal.Background = new SolidColorBrush(Colors.Aqua);
                }
                else
                {
                    normal.Background = new SolidColorBrush(Colors.Aqua);
                }
            }
            else
            {
                if (shrift == "normal")
                {
                    normal.Background = new SolidColorBrush(Colors.Orange);
                }
                else
                {
                    normal.Background = new SolidColorBrush(Colors.Orange);
                }
            }
        }
    }
}
