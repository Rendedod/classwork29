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
    /// Логика взаимодействия для Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        string temaFona;
        string shrift;
        public Page1(string temaF, string srft)
        {
            temaFona = temaF;
            shrift = srft;
            InitializeComponent();
            if (temaFona == "white")
            {
                but1.Background = new SolidColorBrush(Colors.Aqua);
                zagolovok.Foreground = new SolidColorBrush(Colors.Black);
                textp1.Foreground = new SolidColorBrush(Colors.Black);
                fon.Background = new SolidColorBrush(Colors.White);
            }
            else
            {
                but1.Background = new SolidColorBrush(Colors.Red);
                zagolovok.Foreground = new SolidColorBrush(Colors.Red);
                textp1.Foreground = new SolidColorBrush(Colors.Red);
                fon.Background = new SolidColorBrush(Colors.Black);
            }
            if(shrift == "normal")
            {
                but1.FontStyle = FontStyles.Normal;
                zagolovok.FontStyle = FontStyles.Normal;
                textp1.FontStyle = FontStyles.Normal;
            }
            else
            {
                but1.FontStyle = FontStyles.Italic;
                zagolovok.FontStyle = FontStyles.Italic;
                textp1.FontStyle = FontStyles.Italic;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Page2(temaFona, shrift));
        }

        private void Button_MouseEnter(object sender, MouseEventArgs e)
        {
            if (temaFona == "white")
            {
                but1.Background = new SolidColorBrush(Colors.AliceBlue);
            }
            else
            {
                but1.Background = new SolidColorBrush(Colors.DarkRed);
            }
        }

        private void Button_MouseLeave(object sender, MouseEventArgs e)
        {
            if (temaFona == "white")
            {
                but1.Background = new SolidColorBrush(Colors.Blue);
            }
            else
            {
                but1.Background = new SolidColorBrush(Colors.Red);
            }
        }
    }
}
