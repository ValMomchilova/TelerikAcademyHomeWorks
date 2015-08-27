namespace AnswerGenerator
{
    using System;

    public class AnswerGenerator
    {
        private const int MaxCount = 6;
        private const bool Answer = true;

        public static void Main()
        {
            AnswerPrinter answerPrinter = new AnswerPrinter();
            answerPrinter.Print(Answer);
        }
    }
}
