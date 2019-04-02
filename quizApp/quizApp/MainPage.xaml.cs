using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;


namespace quizApp
{
    public partial class MainPage : ContentPage
    {
        List<QuestionModel> questions = new List<QuestionModel>();
        ViewModel vm;
        QuestionModel current;

        public MainPage()
        {
            InitializeComponent();
            
            QuestionModel Question = new QuestionModel("What's your favorite food?", "A) Metal", "B)Pizza", "C)Anchovies", "D)Something Normal");
            questions.Add(Question);
            Question = new QuestionModel("What is you favorite passtime?", "A)Bending", "B)TV", "C)Molting", "D)Piloting");
            questions.Add(Question);
            Question = new QuestionModel("What is your favorite place?", "A)Metal Apartment", "B)Couch", "C)The Ocean", "D)Ship");
            questions.Add(Question);
            Question = new QuestionModel("What is you favorite color?", "A)Metal", "B)Red", "C)Orange", "D)Blue");
            questions.Add(Question);
            vm = new ViewModel(questions);

            //Q1
            current = vm.GetNextOne();
            string question = current.Question;
            


        }


        public void HandleClickedA(object sender, System.EventArgs e)
        {
            
            vm.ProcessAnswer("a");
        }

        public void HandleClickedB(object sender, System.EventArgs e)
        {
            vm.ProcessAnswer("B");
        }
        public void HandleClickedC(object sender, System.EventArgs e)
        {
            vm.ProcessAnswer("C");
        }
        public void HandleClickedD(object sender, System.EventArgs e)
        {
            vm.ProcessAnswer("D");
        }
    }
}
