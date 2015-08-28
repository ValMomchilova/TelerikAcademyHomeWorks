namespace LoverOf2
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Numerics;
    using System.Text;
    using System.Threading.Tasks;

    public class LoverOf2
    {
        private static int rDimension;
        private static int cDimension;        
        private static BigInteger[,] matrix;

        public static void Main()
        {
            BigInteger[] codes = ReadInput();

            List<int[]> positions = CalculatePositions(codes);

            FillMatrix();

            BigInteger sum = CalculateSum(positions);

            Console.WriteLine(sum);
        }

        private static BigInteger CalculateSum(List<int[]> positions)
        {
            int rowStart = rDimension - 1;
            int colStart = 0;

            BigInteger sum = 0;

            for (int i = 0; i < positions.Count; i++)
            {
                int[] currPos = positions[i];
                int row = currPos[0];
                int col = currPos[1];
                BigInteger currentSum = GoToPos(ref rowStart, ref colStart, row, col);

                sum += currentSum;
            }

            return sum;
        }

        private static BigInteger[] ReadInput()
        {
            rDimension = int.Parse(Console.ReadLine());
            cDimension = int.Parse(Console.ReadLine());
            int numberOfMoves = int.Parse(Console.ReadLine());

            string input = Console.ReadLine();
            string[] codeTexts = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            BigInteger[] codes = codeTexts.Select(x => BigInteger.Parse(x)).ToArray();

            return codes;
        }

        private static BigInteger GoToPos(ref int rowStart, ref int colStart, int row, int col)
        {
            BigInteger sum = matrix[rowStart, colStart];
            matrix[rowStart, colStart] = 0;

            int curRow = rowStart;
            int currCol = colStart;

            Directions currDir = Directions.Up;

            if (row <= curRow)
            {
                currDir = Directions.Up;
            }
            else
            {
                currDir = Directions.Down;
            }

            while (curRow != row)
            {
                if (currDir == Directions.Up)
                {
                    curRow--;
                }
                else
                {
                    curRow++;
                }

                sum += matrix[curRow, currCol];
                matrix[curRow, currCol] = 0;
            }

            // columns change
            if (col <= currCol)
            {
                currDir = Directions.Left;    
            }
            else
            {
                currDir = Directions.Right;   
            }

            while (currCol != col)
            {
                if (currDir == Directions.Left) 
                {
                    currCol--;
                }
                else
                {
                    currCol++;
                }

                sum += matrix[curRow, currCol];
                matrix[curRow, currCol] = 0;
            }

            rowStart = curRow;
            colStart = currCol;

            return sum;
        }

        private static List<int[]> CalculatePositions(BigInteger[] codes)
        {
            List<int[]> positions = new List<int[]>();
            BigInteger coeficient = Math.Max(rDimension, cDimension);

            for (int i = 0; i < codes.Length; i++)
            {
                BigInteger code = codes[i];
                int row = (int)(code / coeficient);
                int column = (int)(code % coeficient);

                int[] currentPosition = new int[2];
                currentPosition[0] = row;
                currentPosition[1] = column;

                positions.Add(currentPosition);
            }

            return positions;
        }       

        private static void FillMatrix()
        {
            matrix = new BigInteger[rDimension, cDimension];

            BigInteger pow = 1;
            for (int i = rDimension - 1; i >= 0; i--)
            {
                matrix[i, 0] = pow;
                pow *= 2;
            }

            pow = 1;
            for (int i = 0; i < cDimension; i++)
            {
                matrix[rDimension - 1, i] = pow;
                pow *= 2;
            }

            for (int i = 1; i < cDimension; i++)
            {
                pow = matrix[rDimension - 1, i];
                for (int j = rDimension - 1 - 1; j >= 0; j--)
                {
                    pow *= 2;
                    matrix[j, i] = pow;
                }
            }
        }
    }
}