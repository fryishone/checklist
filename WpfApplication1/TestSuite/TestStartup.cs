using LibCLModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckListApp.TestSuite
{
    // create 5 questions
    class TestStartup
    {
        public static List<TASKVALUEFULLV_CL> QUESTIONVALUES;
        public static List<TASKFULLORDEREDV_CL> QUESTIONS;

        [STAThread]

        static void Main()
        {
            createQuestionList();
            createQuestionValueList();

            new MainWindow();

        }

        public static void createQuestionList()
        {
            QUESTIONS = new List<TASKFULLORDEREDV_CL>();
        }

        public static void createQuestionValueList()
        {
            QUESTIONVALUES = new List<TASKVALUEFULLV_CL>();
        }
    }

}
