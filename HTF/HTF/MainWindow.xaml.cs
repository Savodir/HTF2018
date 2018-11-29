using System;
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
        
        private String identifier = "MjAzMzQ5ZTAtYzY2MC00ZjI3LThmYzItMDY1MjY3MTE0ODYx";
        List<String> challengeCodes;
        bool flag;

        public MainWindow()
        {
            InitializeComponent();
            GetManager getManager = new GetManager();
            PostManager postManager = new PostManager("http://htf2018.azurewebsites.net");
            //   getManager.get("http://htf2018.azurewebsites.net", "593bc0a2e0dfdc53b239bc2a96ab0fd5", identifier);
            //     Thread.Sleep(11000); //ms

         //   postManager.postChallenge("593bc0a2e0dfdc53b239bc2a96ab0fd5", identifier, "18274857-ff06-4535-8352-fa9d67e122e0", value);
            //  Console.WriteLine(response);
          //  Challenge04 challenge04 = new Challenge04(500, 20000);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int sleepTime = 11000;
            Challenge02 challenge02 = new Challenge02();
            Thread.Sleep(sleepTime);
            challenge02.get();
            challenge02.crack();
            Thread.Sleep(sleepTime);
            challenge02.post();
        }
    }
}
