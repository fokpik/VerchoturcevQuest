using System.Collections.Generic;

namespace VerchoturcevQuest{
    public class ControllerDB
    {
        TestDBEntities _dbContext = new TestDBEntities();
        Dictionary<Test, GTest> _mapping = new Dictionary<Test, GTest>();

        public List<Test> GetTests()
        {
            List<Test> tests = new List<Test>();
            foreach(GTest gtest in _dbContext.GTest)
            {
                Test test = gtest.Create();
                tests.Add(test);
                _mapping.Add(test, gtest);
            }
            return tests;
        }

        public void AddTest(Test test)
        {
            GTest gTest = new GTest(test);
            _dbContext.GTest.Add(gTest);
            _mapping.Add(test,gTest);
            _dbContext.SaveChanges();
        }

        public void DeleteTest(Test test)
        {
            GTest gTest = _mapping[test];
            List<GQuestion> questionsToDelete = new List<GQuestion>();
            List<GAnswer> answersToDelete = new List<GAnswer>();
            List<GTestResult> resultsToDelete = new List<GTestResult>();
            foreach (GQuestion gQuestion in gTest.GQuestion)
            {
                foreach(GAnswer gAnswer in gQuestion.GAnswer)
                {
                    answersToDelete.Add(gAnswer);
                }
                questionsToDelete.Add(gQuestion);
            }
            foreach(GTestResult gTestResult in gTest.GTestResult)
            {
                resultsToDelete.Add(gTestResult);
            }
            foreach(GAnswer gAnswer in answersToDelete)
            {
                _dbContext.GAnswer.Remove(gAnswer);
            }
            foreach (GQuestion gQuestion in questionsToDelete)
            {
                _dbContext.GQuestion.Remove(gQuestion);
            }
            foreach (GTestResult gTestResult in resultsToDelete)
            {
                _dbContext.GTestResult.Remove(gTestResult);
            }
            _dbContext.GTest.Remove(gTest);
            _mapping.Remove(test);
            _dbContext.SaveChanges();
        }

        public void SaveResult(Test test, TestResult testResult)
        {
            int ID = _mapping[test].ID;
            GTestResult gTestResult = new GTestResult(testResult);
            gTestResult.IDts = ID;
            _dbContext.GTestResult.Add(gTestResult);
            _dbContext.SaveChanges();
        }

        public void SaveTest(Test test)
        {
            GTest gTest = new GTest(test);
            _mapping.Add(test, gTest);
            _dbContext.GTest.Add(gTest);
            _dbContext.SaveChanges();
        }
    }
}
