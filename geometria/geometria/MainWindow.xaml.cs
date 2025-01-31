﻿using System;
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

namespace geometria
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

        private void Trojkat(object sender, RoutedEventArgs e)
        {
            Window1 window1 = new Window1();
            this.Visibility = Visibility.Hidden;
            window1.Show();
        }

        private void Prostokat(object sender, RoutedEventArgs e)
        {
            Prostokąt w2 = new Prostokąt();
            this.Visibility = Visibility.Hidden;
            w2.Show();
        }

        private void Kwadrat(object sender, RoutedEventArgs e)
        {
            Kwadrat w3 = new Kwadrat();
            this.Visibility = Visibility.Hidden;
            w3.Show();
        }
    }
}
