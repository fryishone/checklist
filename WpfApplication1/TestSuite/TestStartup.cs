using CheckListApp.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        }

        public static void UIComponentsTest()
        {

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
                questionResponse1.Add("#1 Testing value " + i + ":");
            }

            checklist.Add(new Question(QuestionENUMS.questionType.CHECKBOX, "Checkbox Question #1:", questionResponse1));

            Console.WriteLine("\n\nQUESTION TEST #1");
            foreach (Question question in checklist)
            {
                Console.WriteLine(question.ToString());
            }

        }

        public static void QuestionValueTest()
        {
            List<QuestionResponse> questionResponse1 = new List<QuestionResponse>();

            questionResponse1.Add(new QuestionResponse("#1 Testing value 1:", Util.QuestionENUMS.questionValue.NO));
            questionResponse1.Add(new QuestionResponse("#1 Testing value 2:", Util.QuestionENUMS.questionValue.NO));
            questionResponse1.Add(new QuestionResponse("#1 Testing value 3:", Util.QuestionENUMS.questionValue.NO));
            questionResponse1.Add(new QuestionResponse("#1 Testing value 4:", Util.QuestionENUMS.questionValue.NO));
            questionResponse1.Add(new QuestionResponse("#1 Testing value 5:", Util.QuestionENUMS.questionValue.NO));

            //First response output
            Console.WriteLine("QUESTION RESPONSE TEST #1");
            foreach (QuestionResponse qResponse in questionResponse1)
            {
                Console.WriteLine(qResponse.ToString());
                
            }

            List<QuestionResponse> questionResponse2 = new List<QuestionResponse>();

            questionResponse2.Add(new QuestionResponse("#2 Testing value 1:", Util.QuestionENUMS.questionValue.NO));
            questionResponse2.Add(new QuestionResponse("#2 Testing value 2:", Util.QuestionENUMS.questionValue.YES));
            questionResponse2.Add(new QuestionResponse("#2 Testing value 3:", Util.QuestionENUMS.questionValue.NO));
            questionResponse2.Add(new QuestionResponse("#2 Testing value 4:", Util.QuestionENUMS.questionValue.YES));
            questionResponse2.Add(new QuestionResponse("#2 Testing value 5:", Util.QuestionENUMS.questionValue.NO));

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
