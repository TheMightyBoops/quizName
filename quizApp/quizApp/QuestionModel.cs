using System;
using System.Collections.Generic;
using System.Text;

namespace quizApp
{
    class QuestionModel
    {
        public string Question { get; set; }
        public string AnsA { get; set; }
        public string AnsB { get; set; }
        public string AnsC { get; set; }
        public string AnsD { get; set; }

        public QuestionModel(string QS, string AnsA, string AnsB, string AnsC, string AnsD)
        {
            this.Question = QS;
            this.AnsA = AnsA;
            this.AnsB = AnsB;
            this.AnsC = AnsC;
            this.AnsD = AnsD;
        }
    }
}
