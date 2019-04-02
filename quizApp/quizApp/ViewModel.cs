using System;
using System.Collections.Generic;
using System.Text;

namespace quizApp
{
    class ViewModel
    {
        private List<QuestionModel> QuestionsBeingAsked; 
        private string ChosenAnswer;
        int NumberA;
        int NumberB;
        int NumberC;
        int NumberD;
        int currentQ = 0;

        public ViewModel(List<QuestionModel> questionsBeingAsked)
        {
            this.QuestionsBeingAsked = questionsBeingAsked;
        }

        public void ProcessAnswer(String givenAns)
        {
            switch (givenAns)
            {
                case "a":

                    NumberA++;
                    break;


                case "b":
                    NumberB++;
                    break;

                case "c":
                    NumberC++;
                    break;

                case "d":
                    NumberD++;
                    break;
            }
        }

        public String GetQesAt(int i)
        {
            return QuestionsBeingAsked[i].Question;
        }

        public QuestionModel GetNextOne()
        {
            currentQ++;
            return QuestionsBeingAsked[currentQ - 1];
        }
    }
}
