using CheckListApp.TestSuite;
using LibCLModel;
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
     * CheckList Class to build the grid in the main window.
     * Checks the DB connection entity to ensure open/valid then proceeds with
     * the logic of adding each UI component to the grid based on the order the list is recieved for
     * a given checklist ID.
     * @Param: dbEntity, CLEntities connection used for retrieving checklists
     */ 
    class CheckList : Grid
    {
        public List<Binding> checkListBindings { get; private set; }
        public int checkListID { get; private set; }

        private List<TASKVALUEFULLV_CL> checklistValues;

        private List<TASKFULLORDEREDV_CL> checklist;

        private DatabaseEntity dbEntity;

        public CheckList(DatabaseEntity dbEntity) 
        {
            try 
            {
                this.dbEntity = dbEntity;
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
            int ROW = 1;
            int QUESTIONNUM = 1;

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
                checklist = dbEntity.getQuestionList();

                    foreach (TASKFULLORDEREDV_CL question in checklist)
                    {
                        checklistValues = dbEntity.getQuestionValues();

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
