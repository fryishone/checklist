using CheckListApp.TestSuite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace CheckListApp.Util
{
    /**
     * Responsible for building the dynamic grid for the main window
     */
    class ChecklistDriver : Grid
    {
        public List<Binding> checkListBindings { get; private set; }
        public int checkListID { get; private set; }

        private List<QuestionResponse> checklistValues;

        private List<Question> checklist;


        public ChecklistDriver() 
        {
            try 
            {
                if (!this.buildGrid())
                {
                    MessageBox.Show("Error building grid");
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        /** 
         * Attempt to build the actual grid
         */
        private Boolean buildGrid() 
        {

            this.VerticalAlignment = VerticalAlignment.Stretch;
            this.HorizontalAlignment = HorizontalAlignment.Stretch;
            this.ColumnDefinitions.Add(
                                new ColumnDefinition() { Width = new GridLength(35.0) });
            this.ColumnDefinitions.Add(
                                new ColumnDefinition() { Width = new GridLength(1, GridUnitType.Star) });
            this.ColumnDefinitions.Add(
                                new ColumnDefinition() { Width = new GridLength(115.0) });


            try
            {

                    /*
                     * For each question in the checklist, call the appropriate type
                     * and put the gui componenet into the grid
                     */
                    foreach (Question question in checklist)
                    {

                    }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            
            return false;
        }
    }
}
