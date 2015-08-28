using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace School
{
    public class Teacher : Person, ICommentable
    {
        private List<Discipline> disciplines;
        private string comment;

        public Teacher(string name)
            : base(name)
        {
            this.disciplines = new List<Discipline>();
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

        public IList<Discipline> Disciplines
        {
            get
            {
                return new List<Discipline>(disciplines);
            }           
        }

        public void AddDiscipline(Discipline discipline)
        {

            this.disciplines.Add(discipline);
        }

        public void DeleteDiscipline(Discipline discipline)
        {
            this.disciplines.Remove(discipline);
        }

        public void DeleteDiscipline(int disciplineIndex)
        {
            this.disciplines.RemoveAt(disciplineIndex);
        }

        public void ClearTeachers()
        {
            this.disciplines.Clear();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(this.Name);
            sb.AppendLine("Disciplines:");
            this.Disciplines.OrderBy(d => d.Name);

            foreach (var item in this.Disciplines)
            {
                sb.AppendLine(item.ToString());
            }

            return sb.ToString();
        }
    }
}
