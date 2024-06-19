using System;

namespace VerchoturcevQuest{
    public class TestResult
    {
        string _studentName;
        string _studentGroup;
        int _score;
        DateTime _dateTime;

        public string StudentName { get => _studentName; set => _studentName = value; }
        public string StudentGroup { get => _studentGroup; set => _studentGroup = value; }
        public int Score { get => _score; set => _score = value; }
        public DateTime Date { get => _dateTime; set => _dateTime = value; }

        public TestResult(string name, string group, int correct, int qcount)
        {
            _studentName = name;
            _studentGroup = group;
            _score = (int)Math.Round(((double)correct / qcount) * 5, 0);
            if (_score < 2)
                _score = 2;
            _dateTime = DateTime.Now;
        }

        public TestResult()
        {
            
        }
    }
}
