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
     * @Param: dbConnection, CLEntities connection used for retrieving checklists
     */ 
    class CheckList : Grid
    {
        public List<Binding> checkListValues { get; private set; }
        public int checkListID { get; private set; }

        public CheckList(CLEntities dbEntity) 
        {
            try 
            {
                dbEntity.Database.Connection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error opening database connection\n" + ex.Message);
            }

            if ( !this.buildGrid() )
            {
                MessageBox.Show("Error building grid");
            }
        }

        /** 
         * Attempt to build the actual grid
         */
        private Boolean buildGrid() 
        {
            return false;
        }
    }
}
