namespace CompareAdvancedMaths
{
    using System;
    using System.Diagnostics;

    public class Comparer
    {
        public void TestSqrtFloat()
        {
            Console.WriteLine("square root float");
            for (int i = 0; i < 10; i++)
            {
                Stopwatch sw = new Stopwatch();
                float testNumber = 4;
                float resultNumber;
                sw.Start();
                for (int j = 0; j < 100000; j++)
                {
                    resultNumber = (float)Math.Sqrt((double)testNumber);
                }

                sw.Stop();
                Console.WriteLine(sw.Elapsed);
            }
        }

        public void TestSqrtDouble()
        {
            Console.WriteLine("square root double");
            for (int i = 0; i < 10; i++)
            {
                Stopwatch sw = new Stopwatch();
                double testNumber = 4;
                double resultNumber;
                sw.Start();
                for (int j = 0; j < 100000; j++)
                {
                    resultNumber = Math.Sqrt(testNumber);
                }

                sw.Stop();
                Console.WriteLine(sw.Elapsed);
            }
        }

        public void TestSqrtDecimal()
        {
            Console.WriteLine("square root decimal");
            for (int i = 0; i < 10; i++)
            {
                Stopwatch sw = new Stopwatch();
                decimal testNumber = 4;
                decimal resultNumber;
                sw.Start();
                for (int j = 0; j < 100000; j++)
                {
                    resultNumber = (decimal)Math.Sqrt((double)testNumber);
                }

                sw.Stop();
                Console.WriteLine(sw.Elapsed);
            }
        }

        public void TestLogFloat()
        {
            Console.WriteLine("natural logarithm float");
            for (int i = 0; i < 10; i++)
            {
                Stopwatch sw = new Stopwatch();
                float testNumber = 4;
                float resultNumber;
                sw.Start();
                for (int j = 0; j < 100000; j++)
                {
                    resultNumber = (float)Math.Log((double)testNumber);
                }

                sw.Stop();
                Console.WriteLine(sw.Elapsed);
            }
        }

        public void TestLogDouble()
        {
            Console.WriteLine("natural logarithm double");
            for (int i = 0; i < 10; i++)
            {
                Stopwatch sw = new Stopwatch();
                double testNumber = 4;
                double resultNumber;
                sw.Start();
                for (int j = 0; j < 100000; j++)
                {
                    resultNumber = Math.Log(testNumber);
                }

                sw.Stop();
                Console.WriteLine(sw.Elapsed);
            }
        }

        public void TestLogDecimal()
        {
            Console.WriteLine("natural logarithm decimal");
            for (int i = 0; i < 10; i++)
            {
                Stopwatch sw = new Stopwatch();
                decimal testNumber = 4;
                decimal resultNumber;
                sw.Start();
                for (int j = 0; j < 100000; j++)
                {
                    resultNumber = (decimal)Math.Log((double)testNumber);
                }

                sw.Stop();
                Console.WriteLine(sw.Elapsed);
            }
        }

        public void TestSinFloat()
        {
            Console.WriteLine("sinus float");
            for (int i = 0; i < 10; i++)
            {
                Stopwatch sw = new Stopwatch();
                float testNumber = 30;
                float resultNumber;
                sw.Start();
                for (int j = 0; j < 100000; j++)
                {
                    resultNumber = (float)Math.Sin((double)testNumber);
                }

                sw.Stop();
                Console.WriteLine(sw.Elapsed);
            }
        }

        public void TestSinDouble()
        {
            Console.WriteLine("sinus double");
            for (int i = 0; i < 10; i++)
            {
                Stopwatch sw = new Stopwatch();
                double testNumber = 30;
                double resultNumber;
                sw.Start();
                for (int j = 0; j < 100000; j++)
                {
                    resultNumber = Math.Sin(testNumber);
                }

                sw.Stop();
                Console.WriteLine(sw.Elapsed);
            }
        }

        public void TestSinDecimal()
        {
            Console.WriteLine("sinus decimal");
            for (int i = 0; i < 10; i++)
            {
                Stopwatch sw = new Stopwatch();
                decimal testNumber = 30;
                decimal resultNumber;
                sw.Start();
                for (int j = 0; j < 100000; j++)
                {
                    resultNumber = (decimal)Math.Sin((double)testNumber);
                }

                sw.Stop();
                Console.WriteLine(sw.Elapsed);
            }
        }
    }
}
