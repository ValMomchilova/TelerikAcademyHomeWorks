using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace School
{
    public class Discipline : INameable, ICommentable
    {
        private string name;
        private string comment;
        private int lectureCount;
        private int exerciseCount;

        public Discipline(string name)
        {
            this.Name = name;
        }

        public Discipline(string name, int lectureCount, int exerciceCount)
            : this(name)
        {
            this.LectureCount = lectureCount;
            this.ExerciseCount = exerciceCount;
        }

        public Discipline(string name, int lectureCount, int exerciceCount, string comment)
            : this(name, lectureCount, exerciceCount)
        {
            this.Comment = comment;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name can not be null or empty.");
                }

                this.name = value;
            }
        }

        public int LectureCount
        {
            get
            {
                return this.lectureCount;
            }
            set
            {
                this.lectureCount = value;
            }
        }

        public int ExerciseCount
        {
            get
            {
                return this.exerciseCount;
            }
            set
            {
                this.exerciseCount = value;
            }
        }

        public string Comment
        {
            get
            {
                return this.comment;
            }
            set
            {
                this.comment = value;
            }
        }

        public override string ToString()
        {
            return String.Format("{0} - Lectures: {1}, Exercises: {2}"
                , this.Name, this.LectureCount, this.ExerciseCount);
        }
    }
}
