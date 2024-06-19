using System;
using System.Collections.Generic;

namespace VerchoturcevQuest{
    partial class GQuestion
    {
        public GQuestion(Question question)
        {
            Text = question.Text;
            Type = (int)question.GetQType();
            GAnswer = new HashSet<GAnswer>();
            foreach (Answer answer in question.GetOptions())
            {
                GAnswer.Add(new GAnswer(answer));
            }
        }

        public Question Create()
        {
            switch(Type)
            {
                case (int)QuestionType.QT_Single:
                    List<Answer> answers1 = new List<Answer>();
                    foreach (GAnswer answer in this.GAnswer)
                    {
                        answers1.Add(answer.Create());
                    }
                    QuestionSingle question1 = new QuestionSingle(Text, answers1);
                    return question1;
                case (int)QuestionType.QT_Multiple:
                    List<Answer> answers2 = new List<Answer>();
                    foreach (GAnswer answer in this.GAnswer)
                    {
                        answers2.Add(answer.Create());
                    }
                    QuestionMultiple question2 = new QuestionMultiple(Text, answers2);
                    return question2;
                case (int)QuestionType.QT_Free:
                    Answer answer3 = default(Answer);
                    foreach (GAnswer answer in this.GAnswer)
                    {
                        answer3 = answer.Create();
                    }
                    QuestionFree question3 = new QuestionFree(Text, answer3);
                    return question3;
                default:
                    throw new NotImplementedException();
            }

        }
    }
}