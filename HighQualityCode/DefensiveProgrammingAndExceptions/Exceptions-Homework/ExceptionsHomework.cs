using System;
using System.Collections.Generic;
using System.Text;
using StudentsExam;

public class ExceptionsHomework
{
    public static void Main()
    {
        SubsequenceGetter subsequenceGetter = new SubsequenceGetter();
        var substr = subsequenceGetter.GetSubsequence("Hello!".ToCharArray(), 2, 3);
        Console.WriteLine(substr);

        var subarr = subsequenceGetter.GetSubsequence(new int[] { -1, 3, 2, 1 }, 0, 2);
        Console.WriteLine(string.Join(" ", subarr));

        var allarr = subsequenceGetter.GetSubsequence(new int[] { -1, 3, 2, 1 }, 0, 4);
        Console.WriteLine(string.Join(" ", allarr));

        var emptyarr = subsequenceGetter.GetSubsequence(new int[] { -1, 3, 2, 1 }, 0, 0);
        Console.WriteLine(string.Join(" ", emptyarr));

        StringExtractor stringExtractor  = new StringExtractor();
        Console.WriteLine(stringExtractor.ExtractEnding("I love C#", 2));
        Console.WriteLine(stringExtractor.ExtractEnding("Nakov", 4));
        Console.WriteLine(stringExtractor.ExtractEnding("beer", 4));
        Console.WriteLine(stringExtractor.ExtractEnding("Hi", 100));

        PrintIsPrime(23);
        PrintIsPrime(33);
        
        List<Exam> peterExams = new List<Exam>()
        {
            new SimpleMathExam(2),
            new CSharpExam(55),
            new CSharpExam(100),
            new SimpleMathExam(1),
            new CSharpExam(0),
        };
        Student peter = new Student("Peter", "Petrov", peterExams);
        double peterAverageResult = peter.CalcAverageExamResultInPercents();
        Console.WriteLine("Average results = {0:p0}", peterAverageResult);
    }

    private static void PrintIsPrime(int number)
    {
        PrimeChecker primeChecker = new PrimeChecker();

        if (primeChecker.CheckPrime(number))
        {
            Console.WriteLine("{0} is prime", number);
        }
        else
        {
            Console.WriteLine("{0} is not prime", number);
        }
    }
}
