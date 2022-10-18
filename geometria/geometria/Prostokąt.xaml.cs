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
using System.Windows.Shapes;

namespace geometria
{
    /// <summary>
    /// Logika interakcji dla klasy Prostokąt.xaml
    /// </summary>
    public partial class Prostokąt : Window
    {
        private enum Option
        {
            Pole,
            Obwod,
            Przekatna
        }
        private Option option;
        public Prostokąt()
        {
            InitializeComponent();
            A.Text = String.Empty;
            B.Text=String.Empty;
            operacja.Text = "operacja";
            wynik.Text = String.Empty;
        }
        

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow w = new MainWindow();
            this.Visibility = Visibility.Hidden;
            w.Show();
        }

        

        

        private void Pole_Click(object sender, RoutedEventArgs e)
        {
            option = Option.Pole;
            operacja.Text = Option.Pole.ToString();
        }

        private void OBWOD_Click(object sender, RoutedEventArgs e)
        {
            option = Option.Obwod;
            operacja.Text=Option.Obwod.ToString();
        }

        private void Przekatna_Click(object sender, RoutedEventArgs e)
        {
            option=Option.Przekatna;
            operacja.Text = Option.Przekatna.ToString();

        }
        private void Wynik_Click(object sender, RoutedEventArgs e)
        {
            double first, secound ,result;
            bool valid = double.TryParse(A.Text , out first);
            valid = double.TryParse(A.Text , out secound);
            if (!valid)
            {
                wynik.Text = "podaj a i b";
                return;
            }
            if (A.Text == B.Text)
            {
                wynik.Text = "To nie jest prostokat!!";
                return;
            }

            switch (option)
            {
                case Option.Pole:
                    result = first * secound;
                    wynik.Text = $" P = {result}";
                    break;

                case Option.Obwod:
                    result = 2*first + 2*secound;
                    wynik.Text = $" OB = {result}";
                    break;

                case Option.Przekatna:
                    result = Math.Sqrt(first*first + secound*secound);
                    wynik.Text = $" D = {result}";
                    break;

            }

        }

    }
}
