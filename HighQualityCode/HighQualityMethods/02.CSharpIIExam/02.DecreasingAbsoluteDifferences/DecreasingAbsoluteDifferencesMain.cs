namespace DecreasingAbsoluteDifferences
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class DecreasingAbsoluteDifferencesMain
    {
        public static void Main(string[] args)
        {
            List<List<long>> sequences = ReadInput();

            for (int i = 0; i < sequences.Count; i++)
            {
                bool isDecr = CheckIsDecripted(sequences[i]);
                if (isDecr)
                {
                    Console.WriteLine("True");
                }
                else
                {
                    Console.WriteLine("False");
                }
            }
        }

        public static List<List<long>> ReadInput()
        {
            int linesCount = int.Parse(Console.ReadLine());

            List<List<long>> sequences = new List<List<long>>();

            for (int i = 0; i < linesCount; i++)
            {
                string input = Console.ReadLine();
                string[] inputNumbers = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                List<long> currentNumbers = inputNumbers.Select(x => long.Parse(x)).ToList<long>();
                sequences.Add(currentNumbers);
            }

            return sequences;
        }

        public static bool CheckIsDecripted(List<long> currentSequence)
        {
            bool result = true;

            List<long> absoluteSequence = GetAbsoluteSequence(currentSequence);

            long previous = absoluteSequence[0];
            for (int i = 1; i < absoluteSequence.Count; i++)
            {
                if (previous < absoluteSequence[i])
                {
                    result = false;
                    break;
                }

                long diff = absoluteSequence[i] - previous;
                diff = Math.Abs(diff);

                if (diff != 0 && diff != 1)
                {
                    result = false;
                    break;
                }

                previous = absoluteSequence[i];
            }

            return result;
        }

        private static List<long> GetAbsoluteSequence(List<long> currentSequence)
        {
            List<long> absoluteSequence = new List<long>();

            long previous = currentSequence[0];
            for (int i = 1; i < currentSequence.Count; i++)
            {
                long difference = currentSequence[i] - previous;
                long differenceAbs = Math.Abs(difference);
                absoluteSequence.Add(differenceAbs);
                previous = currentSequence[i];
            }

            return absoluteSequence;
        }
    }
}