using System;
using System.Collections.Generic;
using System.DirectoryServices.ActiveDirectory;
using System.Linq;
using System.Runtime.CompilerServices;
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
    /// Logika interakcji dla klasy Window1.xaml
    /// </summary>

    public partial class Window1 : Window
    {
        private enum OperationType
        {
            Pole,
            OBWOD
            


        }
        private OperationType operationType;
        public Window1()
        {
            
            InitializeComponent();
            A.Text = String.Empty;
            B.Text = String.Empty;
            Wynik.Text = String.Empty;
            siny.Text = String.Empty;




        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            var wcisniety = ((Button)sender).Content;

            Wynik.Text += wcisniety;

        }
      
      
       
     

        private void C_Click(object sender, RoutedEventArgs e)
        {
            Wynik.Text = String.Empty;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow w = new MainWindow();
            this.Visibility = Visibility.Hidden;
            w.Show();
        }
        private void _2(object sender, RoutedEventArgs e)
        {
            operationType = OperationType.Pole;
            operacja.Text = OperationType.Pole.ToString();
        }

        private void _1(object sender, RoutedEventArgs e)
        {
            operationType = OperationType.OBWOD;
            operacja.Text = OperationType.OBWOD.ToString();

        }

        private void Wynik1_Click(object sender, RoutedEventArgs e)
        {
            double first, secund,  result;
            double tre;
            bool valid = double.TryParse(A.Text, out first);
            if (!valid)
            {
                Wynik.Text = "bład podaj a";
                return;
            }
            valid = double.TryParse(B.Text, out secund);
            if(!valid)
            {
                Wynik.Text = "bład podaj h";
                return;
            }
            valid = double.TryParse(siny.Text, out tre);
            
            switch (operationType)
            {
                case OperationType.Pole:
                    result = first * secund / 2;
                    Wynik.Text =$"{result}";
                    break;
                case OperationType.OBWOD:
                    result = first * secund * tre.CompareTo(Math.Sin(tre))/2;
                    Wynik.Text = $"{result}";
                    if (!valid)
                    {
                        Wynik.Text = "bład podaj sinusa";
                        return;
                    }
                    break;

                



            }
        }

       
    }

      
}
