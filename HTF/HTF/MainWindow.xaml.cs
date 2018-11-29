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

namespace HTF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private String identifier = "MjAzMzQ5ZTAtYzY2MC00ZjI3LThmYzItMDY1MjY3MTE0ODYx";
        List<String> challengeCodes;
        public MainWindow()
        {
            InitializeComponent();
            GetManager getManager = new GetManager();
          getManager.Get("www.htf2018.azurewebsites.net", "593bc0a2e0dfdc53b239bc2a96ab0fd5", identifier);
          //  Console.WriteLine(response);
        }
    }
}
