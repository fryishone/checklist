using LibCLModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckListApp.TestSuite
{
    /**
     *  Fake db entity. Create a question set to be returned in the CheckList application to build a valid grid
     */
    class DatabaseEntity : CLEntities
    {
        public List<TASKFULLORDEREDV_CL> getQuestionList()
        {
            return TestStartup.QUESTIONS;
        }

        public List<TASKVALUEFULLV_CL> getQuestionValues()
        {


            return TestStartup.QUESTIONVALUES;
        }

        private TASKVALUEFULLV_CL createQuestion() 
        {
            return null;
        }

        private TASKFULLORDEREDV_CL createQuestionValues()
        {
            return null;
        }

    }
}
