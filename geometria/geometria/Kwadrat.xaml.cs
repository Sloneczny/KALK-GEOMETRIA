using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Logika interakcji dla klasy Kwadrat.xaml
    /// </summary>
    public partial class Kwadrat : Window
    {
        private enum OperationK
        { 
            Obwód,
            Pole1,
            Pole2,
            Przyprostokatna
        
        
        }
        private OperationK operationK;

        public Kwadrat()
        {
            InitializeComponent();
            a.Text=String.Empty;
            d.Text = String.Empty;
            wynik.Text = String.Empty;
            operacja.Text = "operacja";

                
        }

        

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow w = new MainWindow();
            this.Visibility = Visibility.Hidden;
            w.Show();
        }

        private void ob_Click(object sender, RoutedEventArgs e)
        {
            operationK = OperationK.Obwód;
            operacja.Text = "Liczenie obwodu kwadratu";

        }

        private void pole1_Click(object sender, RoutedEventArgs e)
        {
            operationK = OperationK.Pole1;
            operacja.Text = "Licznie pola ze wzoru";
        }

        private void pole2_Click(object sender, RoutedEventArgs e)
        {
            operationK = OperationK.Pole2;
            operacja.Text = "Licznie pola ze wzoru2";
        }

        private void przyprostokatna_Click(object sender, RoutedEventArgs e)
        {
            operationK = OperationK.Przyprostokatna;
            operacja.Text = "Liczenie długości przekątnej kwadratu:";
        }

        private void result_Click(object sender, RoutedEventArgs e)
        {
            double first, secound, result;
            bool valid1 = double.TryParse(a.Text, out first);
           
            bool valid2 = double.TryParse(d.Text, out secound);
            
            switch (operationK)
            { 
                case OperationK.Pole1:
                    result = first * first;
                    wynik.Text =  $" P = {result}";
                    if(!valid1)
                    {
                        wynik.Text = "podaj A";
                    }
                    operacja.Text = $" {first} * {first} = {result}" ;
                    
                    break;

                case OperationK.Pole2:
                    result = secound * secound / 2;
                    
                    wynik.Text = $"P={result}";
                    if (!valid2)
                    {
                        wynik.Text = "podaj D";
                    }


                    break;

                case OperationK.Obwód:
                    result = 4 * first;
                    
                    wynik.Text = $"OB= {result}";
                    if (!valid1)
                    {
                        wynik.Text = "podaj A";
                    }


                    break;

                case OperationK.Przyprostokatna:
                    result = first * Math.Sqrt(2);
                    
                    wynik.Text =   $"D= {result}";
                    if (!valid1)
                    {
                        wynik.Text = "podaj A";
                    }


                    break;  
                    


            }


        }
    }
}
