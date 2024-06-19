using System.Collections.Generic;

namespace VerchoturcevQuest{
    /// <summary>
    /// Основной контроллер.
    /// Служит мостом между интерфейсом и данными, хранящимися в БД. Создаёт контроллеры теста и конструктора тестов.
    /// </summary>
    public class ControllerMain
    {
        ControllerDB _controllerDB = new ControllerDB();
        public ControllerMain()
        {
        }

        public ControllerTest CreateControllerTest(Test test, string name, string group)
        {
            return new ControllerTest(test, name, group);
        }

        public ControllerConstructor CreateControllerConstructor()
        {
            return new ControllerConstructor();
        }

        public List<Test> GetTests()
        {
            return _controllerDB.GetTests();
        }

        public void SaveResult(Test test, TestResult testResult)
        {
            test.AddResult(testResult);
            _controllerDB.SaveResult(test, testResult);
        }

        public void SaveTest(Test test)
        {
            _controllerDB.SaveTest(test);
        }

        public void DeleteTest(Test test)
        {
            _controllerDB.DeleteTest(test);
        }
    }
}
