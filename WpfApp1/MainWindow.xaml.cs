using System;
using System.Threading.Tasks;
using System.Windows;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var client = new Client(); //there is code from last issue, simple connection but now it's unsecure
            //this WriteLine method will never be reached and still have to use below solution 

            /*Task.Factory.StartNew(() =>
            {
                var client = new Client();
            });*/
        }
    }
}
