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

namespace HelloGit
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

        private void buttonLee_Click(object sender, RoutedEventArgs e)
        {
            labelOutput.Content = "Lee was here";
        }

        private void buttonLaurie_Click(object sender, RoutedEventArgs e)
        {
            labelOutput.Content = "Laurie was here";
        }

        private void buttonChris_Click(object sender, RoutedEventArgs e)
        {
            labelOutput.Content = "Chris was here";
        }

        private void buttonLiz_Click(object sender, RoutedEventArgs e)
        {
            labelOutput.Content = "Liz was here";
        }
    }
}
