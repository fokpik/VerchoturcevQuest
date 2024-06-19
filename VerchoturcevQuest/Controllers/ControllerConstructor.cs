using System;
using System.Collections.Generic;

namespace VerchoturcevQuest{
    public class ControllerConstructor
    {
        string _name = "Новый тест";
        List<Question> questions = new List<Question>();

        public string Name { get => _name; set => _name = value; }

        public ControllerConstructor()
        {
        }

        public void CreateQuestionSingle(string text)
        {
            QuestionSingle questionSingle = new QuestionSingle(text, new List<Answer>());
            questions.Add(questionSingle);
        }

        public void CreateQuestionMultiple(string text)
        {
            QuestionMultiple questionMultiple = new QuestionMultiple(text, new List<Answer>());
            questions.Add(questionMultiple);
        }

        public void CreateQuestionFree(string text, string answer)
        {
            QuestionFree questionFree = new QuestionFree(text, answer);
            questions.Add(questionFree);
        }

        public void DeleteQuestion(Question question)
        {
            questions.Remove(question);
        }

        public List<Question> GetQuestions()
        {
            return questions;
        }

        public void CreateAnswer(Question question, string text, bool isCorrect)
        {
            switch (question.GetQType())
            {
                case QuestionType.QT_Single:
                    QuestionSingle questionSingle = (QuestionSingle)question;
                    Answer answer = new Answer();
                    answer.Text = text;
                    answer.IsCorrect = isCorrect;
                    questionSingle.Options.Add(answer);
                    break;
                case QuestionType.QT_Multiple:
                    QuestionMultiple questionMultiple = (QuestionMultiple)question;
                    Answer answer1 = new Answer();
                    answer1.Text = text;
                    answer1.IsCorrect = isCorrect;
                    questionMultiple.Options.Add(answer1);
                    break;
                default:
                    throw new NotImplementedException();
            }
        }

        public void DeleteAnswer(Question question, Answer answer)
        {
            switch (question.GetQType())
            {
                case QuestionType.QT_Single:
                    QuestionSingle questionSingle = (QuestionSingle)question;
                    questionSingle.Options.Remove(answer);
                    break;
                case QuestionType.QT_Multiple:
                    QuestionMultiple questionMultiple = (QuestionMultiple)question;
                    questionMultiple.Options.Remove(answer);
                    break;
                default:
                    throw new NotImplementedException();
            }
        }

        public Test CreateTest()
        {
            Test test = new Test();
            test.Name = _name;
            foreach(Question question in questions)
            {
                test.AddQuestion(question);
            }
            return test;
        }

        public bool CheckIntegrity()
        {
            if(questions.Count < 1)
            {
                return false;
            }
            foreach(Question question in questions)
            {
                if (question.GetOptions().Count == 0)
                    return false;
                int correctCount = 0;
                foreach(Answer answer in question.GetOptions())
                {
                    if(answer.IsCorrect)
                    {
                        correctCount++;
                    }
                }
                if(correctCount < 1)
                {
                    return false;
                }
                if(correctCount > 1 && question.GetQType() == QuestionType.QT_Single)
                {
                    return false;
                }
            }
            return true;
        }
    }
}