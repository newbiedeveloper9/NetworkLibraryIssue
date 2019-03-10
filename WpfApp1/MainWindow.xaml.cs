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

            //This one throw error.
            //An unhandled exception of type 'System.Threading.Tasks.TaskCanceledException' occurred in mscorlib.dll Additional information: A task was canceled.
            var client = new Client();


            //This one works without any problem for me
            /*Task.Factory.StartNew(() =>
            {
                var client = new Client();
            });*/
        }
    }
}
