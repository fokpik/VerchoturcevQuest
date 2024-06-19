namespace VerchoturcevQuest{
    partial class GTestResult
    {
        public GTestResult(TestResult testResult)
        {
            Name = testResult.StudentName;
            Group = testResult.StudentGroup;
            Date = testResult.Date;
            Result = testResult.Score;
        }

        public GTestResult()
        {
        }

        public TestResult Create()
        {
            TestResult testResult = new TestResult();
            testResult.StudentName = Name;
            testResult.StudentGroup = Group;
            testResult.Date = Date;
            testResult.Score = Result;
            return testResult;
        }
    }
}