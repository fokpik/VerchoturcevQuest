using System.Collections.Generic;

namespace VerchoturcevQuest{
    public class ControllerTest
    {
        Test _test;
        string _name;
        string _group;
        int _curIndex = 0;
        int _correct = 0;

        public int CurIndex { get => _curIndex; set => _curIndex = value; }
        public Question CurQuestion { get => _test.Questions[_curIndex - 1]; }
        public int Correct { get => _correct; set => _correct = value; }

        public ControllerTest(Test test, string name, string group)
        {
            _test = test;
            _name = name;
            _group = group;
        }

        public int GetMaxIndex()
        {
            return _test.QuestionCount;
        }

        public Question GetNextQuestion()
        {
            return _test.Questions[_curIndex++];
        }

        public void Answer(List<Answer> answers)
        {
            int corCount = 0;
            foreach(Answer answer in _test.Questions[_curIndex - 1].GetOptions())
            {
                if (answer.IsCorrect)
                    corCount++;
            }
            if (corCount != answers.Count)
                return;
            foreach(Answer answer in answers)
            {
                if (!answer.IsCorrect)
                    return;
            }
            _correct++;
        }

        public void Answer(Answer answer)
        {
            if (answer.IsCorrect)
                _correct++;
        }

        public void Answer(string answer)
        {
            Answer aanswer = _test.Questions[_curIndex - 1].GetOptions()[0];
            if (aanswer.Text.ToLower() == answer.ToLower())
                _correct++;
        }

        public TestResult GetResult()
        {
            return new TestResult(_name, _group, _correct, _test.QuestionCount);
        }
    }
}
