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
using System.Windows.Threading;

namespace Customer_Relationship_Management_Application
{
    /// <summary>
    /// Interaction logic for SplashScreen.xaml
    /// </summary>
    public partial class SplashScreen : Window
    {
        new DispatcherTimer Dispatcher = new DispatcherTimer();

        //Splash screen displays for 4 seconds to immulate application loading
        public SplashScreen()
        {            
            InitializeComponent();

            Dispatcher.Tick += new EventHandler(Dispatcher_Tick);
            Dispatcher.Interval = new TimeSpan(0, 0, 4);
            Dispatcher.Start();
        }

        private void Dispatcher_Tick(object sender, EventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();

            Dispatcher.Stop();
            this.Close();
        }
    }
}
