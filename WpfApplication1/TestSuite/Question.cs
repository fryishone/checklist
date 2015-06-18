using CheckListApp.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckListApp.TestSuite
{
    
    /**
     * Question entity for testing purpose.
     * Normally these would be created through entity framework
     */
    class Question
    {
        public QuestionType questionType { get; private set; }

        public string question { get; private set; }
        public List<QuestionResponse> questionResponse { get; private set; }

        public Question(QuestionType questionType, string question, List<string> response)
        {
            this.questionType = questionType;
            this.question = question;
            this.questionResponse = new List<QuestionResponse>();

            foreach (string responseMsg in response)
            {
                questionResponse.Add(new QuestionResponse(responseMsg, QuestionValue.NO));
            }
               

        }

        public override string ToString()
        {
            string returnVal = string.Format("{0} {1}", questionType, question);
            foreach (QuestionResponse response in questionResponse)
            {
                returnVal += "\n" + response.ToString();
            }

            return returnVal;

        }
    }
}
