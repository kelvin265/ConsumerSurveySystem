using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsumerSurveySystem.classes
{
    class Respondent
    {
        public string completionDate;
 
        public string CompletionDate
        {
            get { return completionDate; }
            set { completionDate = value; }
        }
        public void recordRespondentCompletionDate()
        {
        }
        public void recordLastQuestionNumber(int questionId)
        {
        }
    }
}
