using CheckListApp.Interface;
using CheckListApp.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace CheckListApp.TestSuite
{
    /**
     * Main driver to run all test suites for the different classes
     * Classes tested: Question, QuestionResponse, ChecklistStart, UIComponenets, DataSubmission
     */
    class TestStartup
    {

        [STAThread]

        static void Main()
        {

            QuestionValueTest();
            QuestionTest();

            UIComponentsTest();

            
        }

        /**
         * Initial test approach will be to just create a row, add a component and repeat
         */
        public static void UIComponentsTest()
        {
            UIComponents componentBuilder = new UIComponents();
            UIWindowTest window = new UIWindowTest();

            int rownum = 0;
            int questionnum = 1;
            int COLUMN1 = 1;

            Grid grid = new Grid();


            /** set the grid width */
            grid.VerticalAlignment = VerticalAlignment.Stretch;
            grid.HorizontalAlignment = HorizontalAlignment.Stretch;
            grid.ColumnDefinitions.Add(
                                new ColumnDefinition() { Width = new GridLength(35.0) });
            grid.ColumnDefinitions.Add(
                                new ColumnDefinition() { Width = new GridLength(1, GridUnitType.Star) });
            grid.ColumnDefinitions.Add(
                                new ColumnDefinition() { Width = new GridLength(115.0) });


            // create checklist title
            grid.RowDefinitions.Add(componentBuilder.createRowDefinition());
            TextBlock tb = componentBuilder.createTitleBox("Checklist Title");
            grid.Children.Add(componentBuilder.titleBorder(rownum, tb));
            
            rownum++;

            // create first question
            grid.RowDefinitions.Add(componentBuilder.createRowDefinition());

            tb = componentBuilder.createQuestionNums(questionnum);
            grid.Children.Add(componentBuilder.questionBorder(rownum, tb));

            grid.Children.Add(componentBuilder.createTextBox("The first question", rownum, COLUMN1));
            grid.Children.Add(componentBuilder.yesNo(rownum, QuestionValue.NOVALUE));

            questionnum++;
            rownum++;

            // create second question
            grid.RowDefinitions.Add(componentBuilder.createRowDefinition());

            tb = componentBuilder.createQuestionNums(questionnum);
            grid.Children.Add(componentBuilder.questionBorder(rownum, tb));

            grid.Children.Add(componentBuilder.createTextBox("The second question", rownum, COLUMN1));
            grid.Children.Add(componentBuilder.yesNo(rownum, QuestionValue.NOVALUE));

            questionnum++;
            rownum++;

            // create third question
            grid.RowDefinitions.Add(componentBuilder.createRowDefinition());

            tb = componentBuilder.createQuestionNums(questionnum);
            grid.Children.Add(componentBuilder.questionBorder(rownum, tb));

            grid.Children.Add(componentBuilder.createTextBox("The third question", rownum, COLUMN1));
            grid.Children.Add(componentBuilder.yesNo(rownum, QuestionValue.YES));

            questionnum++;
            rownum++;

            // create fourth question
            grid.RowDefinitions.Add(componentBuilder.createRowDefinition());

            tb = componentBuilder.createQuestionNums(questionnum);
            grid.Children.Add(componentBuilder.questionBorder(rownum, tb));

            grid.Children.Add(componentBuilder.createTextBox("The fourth question", rownum, COLUMN1));
            grid.Children.Add(componentBuilder.yesNo(rownum, QuestionValue.NO));

            questionnum++;
            rownum++;

            // create fifth question
            grid.RowDefinitions.Add(componentBuilder.createRowDefinition());

            tb = componentBuilder.createQuestionNums(questionnum);
            grid.Children.Add(componentBuilder.questionBorder(rownum, tb));

            grid.Children.Add(componentBuilder.createTextBox("The fifth question", rownum, COLUMN1));
            grid.Children.Add(componentBuilder.yesNo(rownum, QuestionValue.YES));


            window.dynamicContent.Children.Add(grid);
            window.Show();
            System.Windows.Threading.Dispatcher.Run();

        }

        public static void ChecklistTest()
        {

        }
        public static void QuestionTest()
        {
            List<Question> checklist = new List<Question>();

            List<string> questionResponse1 = new List<string>();

            for ( int i = 1; i<=5; i++)
            {
                questionResponse1.Add(string.Format("#1 Testing value {0}:", i));
            }

            checklist.Add(new Question(QuestionType.CHECKBOX, "Checkbox Question #1:", questionResponse1));

            Console.WriteLine("\n\nQUESTION TEST #1");
            foreach (Question question in checklist)
            {
                Console.WriteLine(question.ToString());
            }

        }

        public static void QuestionValueTest()
        {
            List<QuestionResponse> questionResponse1 = new List<QuestionResponse>();

            questionResponse1.Add(new QuestionResponse("#1 Testing value 1:", Util.QuestionValue.NO));
            questionResponse1.Add(new QuestionResponse("#1 Testing value 2:", Util.QuestionValue.NO));
            questionResponse1.Add(new QuestionResponse("#1 Testing value 3:", Util.QuestionValue.NO));
            questionResponse1.Add(new QuestionResponse("#1 Testing value 4:", Util.QuestionValue.NO));
            questionResponse1.Add(new QuestionResponse("#1 Testing value 5:", Util.QuestionValue.NO));

            //First response output
            Console.WriteLine("QUESTION RESPONSE TEST #1");
            foreach (QuestionResponse qResponse in questionResponse1)
            {
                Console.WriteLine(qResponse.ToString());
                
            }

            List<QuestionResponse> questionResponse2 = new List<QuestionResponse>();

            questionResponse2.Add(new QuestionResponse("#2 Testing value 1:", Util.QuestionValue.NO));
            questionResponse2.Add(new QuestionResponse("#2 Testing value 2:", Util.QuestionValue.YES));
            questionResponse2.Add(new QuestionResponse("#2 Testing value 3:", Util.QuestionValue.NO));
            questionResponse2.Add(new QuestionResponse("#2 Testing value 4:", Util.QuestionValue.YES));
            questionResponse2.Add(new QuestionResponse("#2 Testing value 5:", Util.QuestionValue.NO));

            //Second response output
            Console.WriteLine("\n\nQUESTION RESPONSE TEST #2");
            foreach (QuestionResponse qResponse in questionResponse2)
            {
                Console.WriteLine(qResponse.ToString());
            }

        }

        public static void DataSubmissionTest()
        {

        }
    }

}
