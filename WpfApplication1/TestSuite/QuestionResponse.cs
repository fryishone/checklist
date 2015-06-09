using CheckListApp.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckListApp.TestSuite
{
    /**
     * QuestionResponse entity for testing purpose.
     * Normally these would be created through entity framework
     * Each question will have > 1 of these responses depending on question type
     */
    class QuestionResponse
    {
        public string responseMessage { get; private set; }
        public QuestionENUMS.questionValue  responseValue { get; set; }

        public QuestionResponse(string responseMessage, QuestionENUMS.questionValue value)
        {
            this.responseMessage = responseMessage;
            this.responseValue = value;
        }

        public override string ToString()
        {
            if (responseMessage == null)
            {
                return this.responseValue.ToString();
            }
            else
                return responseMessage + " " + responseValue;
        }

        
    }
}
