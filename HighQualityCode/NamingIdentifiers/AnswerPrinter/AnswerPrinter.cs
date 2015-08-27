namespace AnswerGenerator
{
    using System;

    public class AnswerPrinter
    {
        public void Print(bool answer)
        {
            string answerText = answer.ToString();
            Console.WriteLine(answerText);
        }
    }
}
