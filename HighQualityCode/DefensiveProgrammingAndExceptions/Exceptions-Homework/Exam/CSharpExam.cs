namespace StudentsExam
{
    using System;

    public class CSharpExam : Exam
    {
        public const int MaxScore = 100;

        private int score;

        public CSharpExam(int score)
        {
            this.Score = score;
        }

        public int Score
        {
            get
            {
                return this.score;
            }

            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Score can not be less than 0");
                }

                if (value > MaxScore)
                {
                    throw new ArgumentOutOfRangeException(
                        string.Format("Score can not be greater that maximal score ({0})", MaxScore));
                }

                this.score = value;
            }
        }

        public override ExamResult Check()
        {
            return new ExamResult(this.Score, 0, MaxScore, "Exam results calculated by score.");
        }
    }
}
