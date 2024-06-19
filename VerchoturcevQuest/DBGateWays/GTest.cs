using System.Collections.Generic;

namespace VerchoturcevQuest{
    partial class GTest
    {
        public GTest(Test test)
        {
            Name = test.Name;
            GQuestion = new HashSet<GQuestion>();
            GTestResult = new HashSet<GTestResult>();
            foreach(Question question in test.Questions)
            {
                GQuestion.Add(new GQuestion(question));
            }
            foreach (TestResult testResult in test.Results)
            {
                GTestResult.Add(new GTestResult(testResult));
            }
        }

        public Test Create()
        {
            Test test = new Test();
            test.Name = Name;
            foreach(GQuestion question in GQuestion)
            {
                test.AddQuestion(question.Create());
            }
            foreach (GTestResult testResult in GTestResult)
            {
                test.AddResult(testResult.Create());
            }
            return test;
        }
    }
}