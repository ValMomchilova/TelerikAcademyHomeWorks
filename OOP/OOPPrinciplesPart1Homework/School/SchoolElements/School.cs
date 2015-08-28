using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace School
{
    public class School : INameable
    {
        private string name;
        private List<SchoolClass> schoolClasses;

        public School(string name)
        {
            this.schoolClasses = new List<SchoolClass>();
            this.Name = name;
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

        public IList<SchoolClass> SchoolClasses
        {
            get
            {
                return new List<SchoolClass>(schoolClasses);
            }
        }

        public void AddSchoolClass(SchoolClass schoolClass)
        {
            if (this.schoolClasses.Any(schClass => schClass.NameID.Equals(schoolClass.NameID, StringComparison.InvariantCultureIgnoreCase)))
            {
                throw new ArgumentException(
                    String.Format("SchoolClass NameID must be unique. There is already defined SchoolClass with NameID {0}", schoolClass.NameID));
            }

            this.schoolClasses.Add(schoolClass);
        }

        public void DeleteSchoolClass(SchoolClass schoolClass)
        {
            this.schoolClasses.Remove(schoolClass);
        }

        public void DeleteSchoolClass(int schoolClassIndex)
        {
            this.schoolClasses.RemoveAt(schoolClassIndex);
        }

        public void ClearSchoolClasses()
        {
            this.schoolClasses.Clear();
        }

        public SchoolClass GetSchoolClassByNameID(string nameID)
        {
            SchoolClass result = this.schoolClasses
                .FirstOrDefault(schClass => schClass.NameID.Equals(nameID, StringComparison.InvariantCultureIgnoreCase));

            return result;
        }

        public override string ToString()
        {           
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(String.Format("School: \"{0}\"", this.Name));
            sb.AppendLine();
            sb.AppendLine("Classes:");
            this.SchoolClasses.OrderBy(schCl => schCl.NameID);

            foreach (var item in this.SchoolClasses)
            {
                sb.AppendLine(item.ToString());
            }

            return sb.ToString();
        }
    }
}
