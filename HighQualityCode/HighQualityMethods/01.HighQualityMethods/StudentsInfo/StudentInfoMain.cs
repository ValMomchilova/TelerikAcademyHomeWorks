namespace StudentInfo
{
    using System;
    
    public class StudentInfoMain
    {
        public static void Main()
        {
            Student peter = new Student("Peter", "Ivanov");
            peter.DateOfBirth = new DateTime(1992, 3, 17);
            peter.Town = "Sofia";
           
            Student stella = new Student("Stella", "Markova");
            stella.DateOfBirth = new DateTime(1993, 11, 03);
            stella.Town = "Vidin";
            stella.CourseResult = CourseResult.Hight;
            stella.Interest = "gamer";
           
            Console.WriteLine(
                "{0} older than {1} -> {2}",
                peter.FirstName,
                stella.FirstName,
                peter.IsOlderThan(stella));
        }
    }
}
