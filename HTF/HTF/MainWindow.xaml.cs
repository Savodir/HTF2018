﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace HTF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public static String identifier = "MjAzMzQ5ZTAtYzY2MC00ZjI3LThmYzItMDY1MjY3MTE0ODYx";
        List<String> challengeCodes;
        bool flag;

        public MainWindow()
        {
            InitializeComponent();
            //   getManager.get("http://htf2018.azurewebsites.net", "593bc0a2e0dfdc53b239bc2a96ab0fd5", identifier);
            //     Thread.Sleep(11000); //ms

            //   postManager.postChallenge("593bc0a2e0dfdc53b239bc2a96ab0fd5", identifier, "18274857-ff06-4535-8352-fa9d67e122e0", value);
            //  Console.WriteLine(response);
            //  Challenge04 challenge04 = new Challenge04(500, 20000);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int sleepTime = 11000;
            cha01.Text = "Completed";
            cha01.Foreground = Brushes.Green;
            Challenge02 challenge02 = new Challenge02();
            Thread.Sleep(sleepTime);
            challenge02.get();
            challenge02.crack();
            Thread.Sleep(sleepTime);
            challenge02.post();
            cha02.Text = "Completed";
            cha02.Foreground = Brushes.Green;
            Challenge03 challenge03 = new Challenge03();
            Thread.Sleep(sleepTime);
            challenge03.get();
            challenge03.crack();
            Thread.Sleep(sleepTime);
            challenge03.post();
            cha03.Text = "Completed";
            cha03.Foreground = Brushes.Green;
            Challenge08 challenge08 = new Challenge08();
            Thread.Sleep(sleepTime);
            challenge08.get();
            challenge08.crack();
            Thread.Sleep(sleepTime);
            challenge08.post();
            cha08.Text = "Completed";
            cha08.Foreground = Brushes.Green;
            Challenge09 challenge09 = new Challenge09();
            Thread.Sleep(sleepTime);
            challenge09.get();
            challenge09.crack();
            Thread.Sleep(sleepTime);
            challenge09.post();
            cha09.Text = "R I P";
            cha09.Foreground = Brushes.Black;
            Challenge04 challenge04 = new Challenge04();
            Challenge05 challenge05 = new Challenge05();
            Challenge06 challenge06 = new Challenge06();

            cha04.Text = "Completed";

            cha05.Text = "Completed";
            cha06.Foreground = Brushes.Green;

            cha04.Text = "Completed";
            cha05.Foreground = Brushes.Green;
            cha06.Foreground = Brushes.Green;
        }
    }
}
