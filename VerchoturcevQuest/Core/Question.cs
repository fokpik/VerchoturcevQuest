using System.Collections.Generic;

namespace VerchoturcevQuest{
    public enum QuestionType
    {
        QT_Single,
        QT_Multiple,
        QT_Free,
        QT_MAX
    }

    public abstract class Question
    {
        string _text;

        public string Text { get => _text; set => _text = value; }

        public abstract QuestionType GetQType();
        public abstract List<Answer> GetOptions();
        public override string ToString()
        {
            return _text;
        }
    }

    public class QuestionSingle : Question
    {
        List<Answer> _options;

        public List<Answer> Options { get => _options; set => _options = value; }

        public QuestionSingle(string text, List<Answer> options)
        {
            Text = text;
            _options = options;
        }

        public override QuestionType GetQType()
        {
            return QuestionType.QT_Single;
        }

        public override List<Answer> GetOptions()
        {
            return _options;
        }
    }

    public class QuestionMultiple : Question
    {
        List<Answer> _options;

        public List<Answer> Options { get => _options; set => _options = value; }

        public QuestionMultiple(string text, List<Answer> options)
        {
            Text = text;
            _options = options;
        }

        public override QuestionType GetQType()
        {
            return QuestionType.QT_Multiple;
        }

        public override List<Answer> GetOptions()
        {
            return _options;
        }
    }

    public class QuestionFree : Question
    {
        Answer _answer;

        public Answer Answer { get => _answer; set => _answer = value; }

        public QuestionFree(string text, Answer answer)
        {
            Text = text;
            _answer = answer;
        }

        public QuestionFree(string text, string answerText)
        {
            Text = text;
            Answer answer = new Answer();
            answer.IsCorrect = true;
            answer.Text = answerText;
            _answer = answer;
        }

        public override QuestionType GetQType()
        {
            return QuestionType.QT_Free;
        }

        public override List<Answer> GetOptions()
        {
            return new List<Answer> { _answer };
        }
    }
}
