using CheckListApp.Util;

namespace CheckListApp.TestSuite
{
    /**
     * QuestionResponse entity for testing purpose.
     * Normally these would be created through entity framework
     * Each question will have > 1 of these responses depending on question type
     */

    internal class QuestionResponse
    {
        public string responseMessage { get; private set; }

        public QuestionValue responseValue { get; set; }

        public QuestionResponse(string responseMessage, QuestionValue value)
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
                return string.Format("{0} {1}", responseMessage, responseValue);
        }
    }
}