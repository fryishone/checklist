using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckListApp.Interface
{
    /**
     *  UIComponents class for creating each of the question frames as a part of the checklist
     *  Builds: RadioButton, TextBlock, CheckBox, RowDefinition, StackPanel and Borders for the MainWindow Grid
     */
    class UIComponents
    {
        /**
         *  static constants used for checklist question types and responses
         *  Also used in the CheckList class.
         */
        public const string GROUP_PREFIX = "taskID";
        public const string YES = "Yes";
        public const string NO = "No";
        public const string Y = "Y";
        public const string N = "N";
        public const string LIST_BOX = "LISTBOX";
        public const string CHECK_BOX = "CHECKBOX";

    }
}
