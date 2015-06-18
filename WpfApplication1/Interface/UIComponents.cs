using CheckListApp.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Media;

namespace CheckListApp.Interface
{
    /**
     *  UIComponents class for creating each of the question frames as a part of the checklist
     *  Builds: RadioButton, TextBlock, CheckBox, RowDefinition, StackPanel and Borders for the MainWindow Grid
     */
    class UIComponents
    {
        /**
         * Create a radio button (either yes or no)
         * May have this return a grid row containing 2 radio buttons?
         */
        public RadioButton createRadioButton(QuestionValue msg, Boolean value) 
        {
            return new RadioButton() { 
                Content = msg, 
                IsChecked = value, 
                Margin = new Thickness(5, 25, 0, 0) };

        }

        public TextBlock createQuestionNums(int row)
        {
            TextBlock questionNums = new TextBlock() { 
                Text = String.Format("{0}.",row), 
                Margin = new Thickness(-5, 20, 0, 20), 
                FontSize = 14 };

            Grid.SetColumn(questionNums, 0);
            Grid.SetRow(questionNums, row);

            return questionNums;
        }

        /**
         * create a row definition for the grid layout
         */
        public RowDefinition createRowDefinition()
        {
            return new RowDefinition() { Height = GridLength.Auto };
        }

        /**
         * Create the title box for the top of the page
         */
        public TextBlock createTitleBox(String msg)
        {
            TextBlock tb = new TextBlock() { 
                Text = msg, 
                TextWrapping = TextWrapping.Wrap, 
                Margin = new Thickness(20, 0, 0, 20), 
                FontSize = 22 };

            Grid.SetColumn(tb, 0);
            Grid.SetColumnSpan(tb, 3);

            return tb;
        }

        /**
         * Create a textbox using the provided string
         */
        public TextBlock createTextBox(String msg, int row, int col)
        {
            // setting a test string
            TextBlock tb = new TextBlock() { 
                Text = msg, 
                TextWrapping = TextWrapping.Wrap, 
                Margin = new Thickness(20, 20, 0, 20), 
                FontSize = 16 };

            BrushConverter bc = new BrushConverter(); 
            tb.Foreground = (Brush) bc.ConvertFrom("#FF2D72BC");

            Grid.SetColumn(tb, col);
            Grid.SetRow(tb, row);

            return tb;
        }

        /**
         * Create a yes no radio box to be used in the form
         * The group names of checkboxes will be based on their TASKVALUEID
         */
        public StackPanel yesNo(int row, QuestionValue value)
        {

            StackPanel sp = new StackPanel() { 
                Orientation = Orientation.Horizontal };

            if (value != QuestionValue.NOVALUE)
            {
                if (value == QuestionValue.YES)
                {
                    sp.Children.Add(createRadioButton(QuestionValue.YES, true));
                    sp.Children.Add(createRadioButton(QuestionValue.NO, false));

                }
                else
                {
                    sp.Children.Add(createRadioButton(QuestionValue.YES, false));
                    sp.Children.Add(createRadioButton(QuestionValue.NO, true));
                }
            }
            else
            {
                sp.Children.Add(createRadioButton(QuestionValue.YES, false));
                sp.Children.Add(createRadioButton(QuestionValue.NO, false));
            }

            Grid.SetColumn(sp, 2);
            Grid.SetRow(sp, row);

            return sp;
        }

        /**
         * Draw a line between questions
         */
        public Border questionBorder(int row, UIElement child)
        {
            Border border = new Border() { 
                BorderBrush = Brushes.Black, 
                BorderThickness = new Thickness(0, .5, 0, 0), 
                Margin = new Thickness(20, 0, 20, 0), 
                Child = child };

            Grid.SetColumnSpan(border, 3);
            Grid.SetRow(border, row);
            
            return border;
        }

        /**
         * Same thing is questionborder - but for the top (title) textbox
         */
        public Border titleBorder(int row, UIElement child)
        {
            Border border = new Border() { 
                BorderBrush = Brushes.Black, 
                BorderThickness = new Thickness(0, 0, 0, 1), 
                Margin = new Thickness(20, 0, 20, 0), 
                Child = child };

            Grid.SetColumnSpan(border, 3);
            Grid.SetRow(border, row);

            return border;
        }




    }
}
