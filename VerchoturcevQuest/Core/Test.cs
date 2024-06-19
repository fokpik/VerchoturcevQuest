using System.Collections.Generic;
using System.Linq;

namespace VerchoturcevQuest{
    public class Test
    {
        string _name;
        List<Question> _questions = new List<Question>();
        List<TestResult> _results = new List<TestResult>();

        public string Name { get => _name; set => _name = value; }
        public List<Question> Questions { get => _questions; set => _questions = value; }
        public int QuestionCount { get => _questions.Count(); }
        public List<TestResult> Results { get => _results; set => _results = value; }

        public void AddQuestion(Question question)
        {
            _questions.Add(question);
        }

        public void DeleteQuestion(Question question)
        {
            _questions.Remove(question);
        }

        public void AddResult(TestResult result)
        {
            _results.Add(result);
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
