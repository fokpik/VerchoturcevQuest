namespace VerchoturcevQuest{
    public class Answer
    {
        //string _text;
        //bool _isCorrect;

        public string Text { get; set; }
        public bool IsCorrect { get; set; }

        public override string ToString()
        {
            return Text;
        }
    }
}
