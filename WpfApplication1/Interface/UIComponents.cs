using CheckListApp.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace CheckListApp.Interface
{
    /**
     *  UIComponents class for creating each of the question frames as a part of the checklist
     *  Builds: RadioButton, TextBlock, CheckBox, RowDefinition, StackPanel and Borders for the MainWindow Grid
     */
    class UIComponents
    {

        public UIComponents()
        {

        }

        /**
         * create a row definition for the grid layout
         */
        public RowDefinition createRowDefinition()
        {
            RowDefinition RowDefinition = new RowDefinition();
            RowDefinition.Height = GridLength.Auto;

            return RowDefinition;
        }


    }
}
