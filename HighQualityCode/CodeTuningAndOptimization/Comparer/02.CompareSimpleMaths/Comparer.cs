namespace CompareSimpleMaths
{
    using System;
    using System.Diagnostics;

    public class Comparer
    {
        public void TestAdditionInt()
        {
            Console.WriteLine("Add int");
            for (int i = 0; i < 10; i++)
            {
                Stopwatch sw = new Stopwatch();
                int testNumber = 0;
                sw.Start();
                for (int j = 0; j < 100000; j++)
                {
                    testNumber = testNumber + 2;
                }

                sw.Stop();
                Console.WriteLine(sw.Elapsed);
            }
        }

        public void TestAdditionLong()
        {
            Console.WriteLine("Add long");
            for (int i = 0; i < 10; i++)
            {
                Stopwatch sw = new Stopwatch();
                long testNumber = 0;
                sw.Start();
                for (int j = 0; j < 100000; j++)
                {
                    testNumber = testNumber + 2L;
                }

                sw.Stop();
                Console.WriteLine(sw.Elapsed);
            }
        }

        public void TestAdditionFloat()
        {
            Console.WriteLine("Add float");
            for (int i = 0; i < 10; i++)
            {
                Stopwatch sw = new Stopwatch();
                float testNumber = 0;
                sw.Start();
                for (int j = 0; j < 100000; j++)
                {
                    testNumber = testNumber + 2F;
                }

                sw.Stop();
                Console.WriteLine(sw.Elapsed);
            }
        }

        public void TestAdditionDouble()
        {
            Console.WriteLine("Add double");
            for (int i = 0; i < 10; i++)
            {
                Stopwatch sw = new Stopwatch();
                double testNumber = 0;
                sw.Start();
                for (int j = 0; j < 100000; j++)
                {
                    testNumber = testNumber + 2D;
                }

                sw.Stop();
                Console.WriteLine(sw.Elapsed);
            }
        }

        public void TestAdditionDecimal()
        {
            Console.WriteLine("Add decimal");
            for (int i = 0; i < 10; i++)
            {
                Stopwatch sw = new Stopwatch();
                decimal testNumber = 0;
                sw.Start();
                for (int j = 0; j < 100000; j++)
                {
                    testNumber = testNumber + 2M;
                }

                sw.Stop();
                Console.WriteLine(sw.Elapsed);
            }
        }

        public void TestSubstractInt()
        {
            Console.WriteLine("Substract int");
            for (int i = 0; i < 10; i++)
            {
                Stopwatch sw = new Stopwatch();
                int testNumber = 0;
                sw.Start();
                for (int j = 0; j < 100000; j++)
                {
                    testNumber = testNumber - 2;
                }

                sw.Stop();
                Console.WriteLine(sw.Elapsed);
            }
        }

        public void TestSubstractLong()
        {
            Console.WriteLine("Substract long");
            for (int i = 0; i < 10; i++)
            {
                Stopwatch sw = new Stopwatch();
                long testNumber = 0;
                sw.Start();
                for (int j = 0; j < 100000; j++)
                {
                    testNumber = testNumber - 2L;
                }

                sw.Stop();
                Console.WriteLine(sw.Elapsed);
            }
        }

        public void TestSubstractFloat()
        {
            Console.WriteLine("Substract float");
            for (int i = 0; i < 10; i++)
            {
                Stopwatch sw = new Stopwatch();
                float testNumber = 0;
                sw.Start();
                for (int j = 0; j < 100000; j++)
                {
                    testNumber = testNumber - 2F;
                }

                sw.Stop();
                Console.WriteLine(sw.Elapsed);
            }
        }

        public void TestSubstractDouble()
        {
            Console.WriteLine("Substract double");
            for (int i = 0; i < 10; i++)
            {
                Stopwatch sw = new Stopwatch();
                double testNumber = 0;
                sw.Start();
                for (int j = 0; j < 100000; j++)
                {
                    testNumber = testNumber - 2D;
                }

                sw.Stop();
                Console.WriteLine(sw.Elapsed);
            }
        }

        public void TestSubstractDecimal()
        {
            Console.WriteLine("Substract decimal");
            for (int i = 0; i < 10; i++)
            {
                Stopwatch sw = new Stopwatch();
                decimal testNumber = 0;
                sw.Start();
                for (int j = 0; j < 100000; j++)
                {
                    testNumber = testNumber - 2M;
                }

                sw.Stop();
                Console.WriteLine(sw.Elapsed);
            }
        }

        public void TestIncrementInt()
        {
            Console.WriteLine("Increment int");
            for (int i = 0; i < 10; i++)
            {
                Stopwatch sw = new Stopwatch();
                int testNumber = 0;
                sw.Start();
                for (int j = 0; j < 100000; j++)
                {
                    testNumber = testNumber++;
                }

                sw.Stop();
                Console.WriteLine(sw.Elapsed);
            }
        }

        public void TestIncrementLong()
        {
            Console.WriteLine("Increment long");
            for (int i = 0; i < 10; i++)
            {
                Stopwatch sw = new Stopwatch();
                long testNumber = 0;
                sw.Start();
                for (int j = 0; j < 100000; j++)
                {
                    testNumber = testNumber++;
                }

                sw.Stop();
                Console.WriteLine(sw.Elapsed);
            }
        }

        public void TestIncrementFloat()
        {
            Console.WriteLine("Increment float");
            for (int i = 0; i < 10; i++)
            {
                Stopwatch sw = new Stopwatch();
                float testNumber = 0;
                sw.Start();
                for (int j = 0; j < 100000; j++)
                {
                    testNumber = testNumber++;
                }

                sw.Stop();
                Console.WriteLine(sw.Elapsed);
            }
        }

        public void TestIncrementDouble()
        {
            Console.WriteLine("Increment double");
            for (int i = 0; i < 10; i++)
            {
                Stopwatch sw = new Stopwatch();
                double testNumber = 0;
                sw.Start();
                for (int j = 0; j < 100000; j++)
                {
                    testNumber = testNumber++;
                }

                sw.Stop();
                Console.WriteLine(sw.Elapsed);
            }
        }

        public void TestIncrementDecimal()
        {
            Console.WriteLine("Increment decimal");
            for (int i = 0; i < 10; i++)
            {
                Stopwatch sw = new Stopwatch();
                decimal testNumber = 0;
                sw.Start();
                for (int j = 0; j < 100000; j++)
                {
                    testNumber = testNumber++;
                }

                sw.Stop();
                Console.WriteLine(sw.Elapsed);
            }
        }

        public void TestMultiplyInt()
        {
            Console.WriteLine("Multiply int");
            for (int i = 0; i < 10; i++)
            {
                Stopwatch sw = new Stopwatch();
                int testNumber = 2;
                sw.Start();
                for (int j = 0; j < 100000; j++)
                {
                    testNumber = testNumber * 1;
                }

                sw.Stop();
                Console.WriteLine(sw.Elapsed);
            }
        }

        public void TestMultiplyLong()
        {
            Console.WriteLine("Multiply long");
            for (int i = 0; i < 10; i++)
            {
                Stopwatch sw = new Stopwatch();
                long testNumber = 2;
                sw.Start();
                for (int j = 0; j < 100000; j++)
                {
                    testNumber = testNumber * 1L;
                }

                sw.Stop();
                Console.WriteLine(sw.Elapsed);
            }
        }

        public void TestMultiplyFloat()
        {
            Console.WriteLine("Multiply float");
            for (int i = 0; i < 10; i++)
            {
                Stopwatch sw = new Stopwatch();
                float testNumber = 2;
                sw.Start();
                for (int j = 0; j < 100000; j++)
                {
                    testNumber = testNumber * 1F;
                }

                sw.Stop();
                Console.WriteLine(sw.Elapsed);
            }
        }

        public void TestMultiplyDouble()
        {
            Console.WriteLine("Multiply double");
            for (int i = 0; i < 10; i++)
            {
                Stopwatch sw = new Stopwatch();
                double testNumber = 2;
                sw.Start();
                for (int j = 0; j < 100000; j++)
                {
                    testNumber = testNumber * 1D;
                }

                sw.Stop();
                Console.WriteLine(sw.Elapsed);
            }
        }

        public void TestMultiplyDecimal()
        {
            Console.WriteLine("Multiply decimal");
            for (int i = 0; i < 10; i++)
            {
                Stopwatch sw = new Stopwatch();
                decimal testNumber = 2;
                sw.Start();
                for (int j = 0; j < 100000; j++)
                {
                    testNumber = testNumber * 1M;
                }

                sw.Stop();
                Console.WriteLine(sw.Elapsed);
            }
        }

        public void TestDivideInt()
        {
            Console.WriteLine("Divide int");
            for (int i = 0; i < 10; i++)
            {
                Stopwatch sw = new Stopwatch();
                int testNumber = 888888888;
                sw.Start();
                for (int j = 0; j < 100000; j++)
                {
                    testNumber = testNumber / 2;
                }

                sw.Stop();
                Console.WriteLine(sw.Elapsed);
            }
        }

        public void TestDivideLong()
        {
            Console.WriteLine("Divide long");
            for (int i = 0; i < 10; i++)
            {
                Stopwatch sw = new Stopwatch();
                long testNumber = 888888888;
                sw.Start();
                for (int j = 0; j < 100000; j++)
                {
                    testNumber = testNumber / 2L;
                }

                sw.Stop();
                Console.WriteLine(sw.Elapsed);
            }
        }

        public void TestDivideFloat()
        {
            Console.WriteLine("Divide float");
            for (int i = 0; i < 10; i++)
            {
                Stopwatch sw = new Stopwatch();
                float testNumber = 888888888;
                sw.Start();
                for (int j = 0; j < 100000; j++)
                {
                    testNumber = testNumber / 2F;
                }

                sw.Stop();
                Console.WriteLine(sw.Elapsed);
            }
        }

        public void TestDivideDouble()
        {
            Console.WriteLine("Multiply Divide");
            for (int i = 0; i < 10; i++)
            {
                Stopwatch sw = new Stopwatch();
                double testNumber = 888888888;
                sw.Start();
                for (int j = 0; j < 100000; j++)
                {
                    testNumber = testNumber / 2D;
                }

                sw.Stop();
                Console.WriteLine(sw.Elapsed);
            }
        }

        public void TestDivideDecimal()
        {
            Console.WriteLine("Divide decimal");
            for (int i = 0; i < 10; i++)
            {
                Stopwatch sw = new Stopwatch();
                decimal testNumber = 888888888;
                sw.Start();
                for (int j = 0; j < 100000; j++)
                {
                    testNumber = testNumber / 2M;
                }

                sw.Stop();
                Console.WriteLine(sw.Elapsed);
            }
        }
    }
}
