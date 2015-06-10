using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckListApp.Util
{

    /**
     * Enums for question type/response used by multiple classes
     */
    class QuestionENUMS
    {
        public enum questionType
        {
            CHECKBOX,
            YESNO
        }

        public enum questionValue
        {
            YES,
            NO,
            NOVALUE
        }

        public QuestionENUMS()
        {

        }
    }
}
