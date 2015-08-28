namespace Maze
{
    using System;

    public class Maze
    {
        private const int MinX = 0;
        private const int MaxX = 100;
        private const int MinY = 1;
        private const int MaxY = 200;

        private static int[,] maze;

        public static void Main()
        {
            int x = 1;
            int y = 2;

            bool shouldVisitCell = CheckIfShouldVisitCell(x, y);

            if ((MinX < x && x < MaxX) &&
                (MinY < y && y < MaxY) &&
                shouldVisitCell)
            {
                VisitCell(x, y);
            }
        }

        public static void VisitCell(int x, int y)
        {
        }

        public static bool CheckIfShouldVisitCell(int x, int y)
        {
            bool shouldVisitCell;
            shouldVisitCell = true;

            return shouldVisitCell;
        }
    }
}
