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
        public QuestionENUMS.questionType questionType { get; private set; }

        public string question { get; private set; }
        public List<QuestionResponse> questionResponse { get; private set; }

        public Question(QuestionENUMS.questionType questionType, string question, List<string> response)
        {
            this.questionType = questionType;
            this.question = question;
            this.questionResponse = new List<QuestionResponse>();

            foreach (string responseMsg in response)
            {
                questionResponse.Add(new QuestionResponse(responseMsg, QuestionENUMS.questionValue.NO));
            }
               

        }

        public override string ToString()
        {
            string returnVal = questionType + " " + question;
            foreach (QuestionResponse response in questionResponse)
            {
                returnVal += "\n" + response.ToString();
            }

            return returnVal;

        }
    }
}
