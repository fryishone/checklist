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

namespace CheckListApp.TestSuite
{
    /// <summary>
    /// Interaction logic for UIWindowTest.xaml
    /// </summary>
    public partial class UIWindowTest : Window
    {
        /**
         * Same xaml as MainWindow - used for adding UIComponents to.
         */
        public UIWindowTest()
        {
            InitializeComponent();
        }

        /**
         * Menu: Exit
         */
        private void filemnu_exit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        /**
         * Menu: About
         */
        private void filemnu_about_Click(object sender, RoutedEventArgs e)
        {
        }

        private void submitInfo(object sender, RoutedEventArgs e)
        {
        }
    }
}
