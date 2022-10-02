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
    /// Logika interakcji dla klasy Kwadrat.xaml
    /// </summary>
    public partial class Kwadrat : Window
    {
        public Kwadrat()
        {
            InitializeComponent();
        }

        

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow w = new MainWindow();
            this.Visibility = Visibility.Hidden;
            w.Show();
        }
    }
}
