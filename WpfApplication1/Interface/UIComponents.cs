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

        public UIComponents()
        {

        }

        /**
         * Create a radio button (either yes or no)
         * May have this return a grid row containing 2 radio buttons?
         */
        public RadioButton createRadioButton(QuestionENUMS.questionValue msg, Boolean value) 
        { 
            RadioButton rb = new RadioButton() { };
            rb.Content = msg;
            rb.IsChecked = value;
            rb.Margin = new Thickness(5, 25, 0, 0);
            return rb;
        }

        public TextBlock createQuestionNums(int row)
        {
            TextBlock questionNums = new TextBlock() { };
            questionNums.Text = (row).ToString() + ".";
            questionNums.Margin = new Thickness(-5, 20, 0, 20);
            questionNums.FontSize = 14;

            Grid.SetColumn(questionNums, 0);
            Grid.SetRow(questionNums, row);

            return questionNums;
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

        /**
         * Create the title box for the top of the page
         */
        public TextBlock createTitleBox(String msg)
        {
            TextBlock tb = new TextBlock();
            tb.Text = msg;
            tb.TextWrapping = TextWrapping.Wrap;
            tb.Margin = new Thickness(20, 0, 0, 20);
            tb.FontSize = 22;

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
            TextBlock tb = new TextBlock() {};
            tb.Text = msg;
            tb.TextWrapping = TextWrapping.Wrap;
            tb.Margin = new Thickness(20, 20, 0, 20);
            tb.FontSize = 16;

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
        public StackPanel yesNo(int row, string value)
        {

            StackPanel sp = new StackPanel();
            sp.Orientation = Orientation.Horizontal;

            if (value != null)
            {
                if (value == QuestionENUMS.questionValue.YES.ToString())
                {
                    sp.Children.Add(createRadioButton(QuestionENUMS.questionValue.YES, true));
                    sp.Children.Add(createRadioButton(QuestionENUMS.questionValue.NO, false));

                }
                else
                {
                    sp.Children.Add(createRadioButton(QuestionENUMS.questionValue.YES, false));
                    sp.Children.Add(createRadioButton(QuestionENUMS.questionValue.NO, true));
                }
            }
            else
            {
                sp.Children.Add(createRadioButton(QuestionENUMS.questionValue.YES, false));
                sp.Children.Add(createRadioButton(QuestionENUMS.questionValue.NO, false));
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
            Border border = new Border();

            border.BorderBrush = Brushes.Black;
            border.BorderThickness = new Thickness(0, .5, 0, 0);
            border.Margin = new Thickness(20, 0, 20, 0);
            border.Child = child;

            Grid.SetColumnSpan(border, 3);
            Grid.SetRow(border, row);
            
            return border;
        }

        /**
         * Same thing is questionborder - but for the top (title) textbox
         */
        public Border titleBorder(int row, UIElement child)
        {
            Border border = new Border();

            border.BorderBrush = Brushes.Black;
            border.BorderThickness = new Thickness(0, 0, 0, 1);
            border.Margin = new Thickness(20, 0, 20, 0);
            border.Child = child;

            Grid.SetColumnSpan(border, 3);
            Grid.SetRow(border, row);

            return border;
        }




    }
}
