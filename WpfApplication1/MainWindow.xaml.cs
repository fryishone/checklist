using CheckListApp;
using CheckListApp.Util;
using LibCLModel;
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


namespace CheckListApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        CheckList checkListGrid;

        public MainWindow()
        {
            InitializeComponent();
            CLEntities dbEntity = new CLEntities();
            checkListGrid = new CheckList(dbEntity);
            dynamicContent.Children.Add(checkListGrid);
        }

        /**
        * Create a datasubmission object and submit list of values
        * If return true, datasubmitted successful otherwise not (empty checklist).
        */
        private void submitInfo(object sender, RoutedEventArgs e)
        {

            DataSubmission ds = new DataSubmission(checkListGrid.checkListValues);

            try
            {
                if (ds.submitData())
                {
                    MessageBox.Show(("Submitted Successfully for checklist id " + checkListGrid.checkListID));
                    System.Windows.Application.Current.Shutdown();
                }
                else
                    MessageBox.Show("Error submitting checklist, try again");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unknown error in Data Submission, Shutting down" + ex.Message);
                System.Windows.Application.Current.Shutdown();
            }
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
    }
}
