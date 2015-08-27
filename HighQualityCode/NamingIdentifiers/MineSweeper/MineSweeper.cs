namespace MineSweeper
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class MineSweeper
    {
        private const int HightScoreListCount = 6;
        private const int BoardRows = 5;
        private const int BoardColumns = 10;
        private const int MineCount = 15;
        private const int MaxScore = (BoardRows * BoardColumns) - MineCount;

        public static void Main()
        {
            List<Score> highScores = new List<Score>(HightScoreListCount);
            
            string command = string.Empty;
            char[,] board = CreateBoard();
            char[,] mines = PlaceMines();
            int row = 0;
            int column = 0;
            int counter = 0;
            bool isMine = false;
            bool isStart = true;
            bool isMaxScore = false;

            do
            {
                if (isStart)
                {
                    Console.WriteLine("Lets play MineSweeper. Try to find the free of mines fields.\n" +
                        "Row and column, separated by space turns the selected field.\n" +
                        "The 'top' command shows the highscores, 'restart' starts a new game, 'exit' " +
                        "quits the game. ");

                    DrawBoard(board);
                    isStart = false;
                }

                Console.Write("Enter row (0 - {0}) and column (0 - {1}): ", BoardRows - 1, BoardColumns - 1);
                command = Console.ReadLine().Trim();

                bool isCorrect = true;
                int[] numbers = new int[1];
                try
                {
                    numbers = command.Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries).Select(a => int.Parse(a)).ToArray();
                }
                catch
                {
                    isCorrect = false;
                }

                if (isCorrect)
                {
                    if (numbers.Length != 2)
                    {
                        isCorrect = false;
                    }
                }

                if (isCorrect)
                {
                    row = numbers[0];
                    column = numbers[1];

                    if (row >= BoardRows || column >= BoardColumns)
                    {
                        isCorrect = false;
                    }
                }

                if (isCorrect)
                {
                    command = "turn";
                }

                switch (command)
                {
                    case "top":
                        PrintHightScore(highScores);
                        break;
                    case "restart":
                        board = CreateBoard();
                        mines = PlaceMines();
                        DrawBoard(board);
                        isMine = false;
                        isStart = false;
                        break;
                    case "exit":
                        break;
                    case "turn":
                        if (mines[row, column] != '*')
                        {
                            if (mines[row, column] == '-')
                            {
                                SetNeighbourMinesCount(board, mines, row, column);
                                counter++;
                            }

                            if (MaxScore == counter)
                            {
                                isMaxScore = true;
                            }
                            else
                            {
                                DrawBoard(board);
                            }
                        }
                        else
                        {
                            isMine = true;
                        }

                        break;
                    default:
                        Console.WriteLine("Invalid command!");
                        break;
                }

                if (isMine)
                {
                    DrawBoard(mines);
                    Console.Write("Game over! points: {0}.\nEnter nickname: ", counter);
                    string nickName = Console.ReadLine();
                    Score score = new Score(nickName, counter);
                    if (highScores.Count < (HightScoreListCount - 1))
                    {
                        highScores.Add(score);
                    }
                    else
                    {
                        for (int i = 0; i < highScores.Count; i++)
                        {
                            if (highScores[i].Points < score.Points)
                            {
                                highScores.Insert(i, score);
                                highScores.RemoveAt(highScores.Count - 1);
                                break;
                            }
                        }
                    }

                    highScores.Sort((Score score1, Score score2) => score2.Name.CompareTo(score1.Name));
                    highScores.Sort((Score score1, Score score2) => score2.Points.CompareTo(score1.Points));
                    PrintHightScore(highScores);

                    board = CreateBoard();
                    mines = PlaceMines();
                    counter = 0;
                    isMine = false;
                    isStart = true;
                }

                if (isMaxScore)
                {
                    Console.WriteLine("You won!!! Points: {0}.", counter);
                    DrawBoard(mines);
                    Console.WriteLine("Enter nickname: ");
                    string name = Console.ReadLine();
                    Score score = new Score(name, counter);
                    highScores.Add(score);
                    PrintHightScore(highScores);
                    board = CreateBoard();
                    mines = PlaceMines();
                    counter = 0;
                    isMaxScore = false;
                    isStart = true;
                }
            }
            while (command != "exit");

            Console.WriteLine("Made in Bulgaria");
            Console.WriteLine("Buy!");
            Console.Read();
        }

        private static void PrintHightScore(List<Score> hightScores)
        {
            Console.WriteLine("\nScore:");
            if (hightScores.Count > 0)
            {
                for (int i = 0; i < hightScores.Count; i++)
                {
                    Console.WriteLine("{0}. {1} --> {2} points", i + 1, hightScores[i].Name, hightScores[i].Points);
                }

                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Empty highscore!\n");
            }
        }

        private static void SetNeighbourMinesCount(char[,] board, char[,] mines, int row, int column)
        {
            char minesCount = CountNeighbourMines(mines, row, column);
            mines[row, column] = minesCount;
            board[row, column] = minesCount;
        }

        private static void DrawBoard(char[,] board)
        {
            int rows = board.GetLength(0);
            int columns = board.GetLength(1);

            Console.WriteLine();
            Console.Write("    ");
            for (int i = 0; i < columns; i++)
            {
                Console.Write("{0} ", i);
            }

            Console.WriteLine();
            Console.Write("   ");

            int dashCount = (columns * 2) + 1;
            for (int i = 0; i < dashCount; i++)
            {
                Console.Write('-');
            }

            Console.WriteLine();

            for (int i = 0; i < rows; i++)
            {
                Console.Write("{0} | ", i);
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(string.Format("{0} ", board[i, j]));
                }

                Console.Write("|");
                Console.WriteLine();
            }

            Console.Write("   ");
            for (int i = 0; i < dashCount; i++)
            {
                Console.Write('-');
            }

            Console.WriteLine();
            Console.WriteLine();
        }

        private static char[,] CreateBoard()
        {
            int boardRows = BoardRows;
            int boardColumns = BoardColumns;
            char[,] board = new char[boardRows, boardColumns];
            for (int i = 0; i < boardRows; i++)
            {
                for (int j = 0; j < boardColumns; j++)
                {
                    board[i, j] = '?';
                }
            }

            return board;
        }

        private static char[,] PlaceMines()
        {
            int rows = BoardRows;
            int columns = BoardColumns;
            char[,] board = new char[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    board[i, j] = '-';
                }
            }

            List<int> minePositionsRandomNumbers = new List<int>();

            int maxMineGeneratorNumber = BoardRows * BoardColumns;

            while (minePositionsRandomNumbers.Count < MineCount)
            {
                Random random = new Random();
                int randomNumber = random.Next(maxMineGeneratorNumber);
                if (!minePositionsRandomNumbers.Contains(randomNumber))
                {
                    minePositionsRandomNumbers.Add(randomNumber);
                }
            }

            foreach (int randomNumber in minePositionsRandomNumbers)
            {
                int column = randomNumber / columns;
                int row = randomNumber % columns;
                if (row == 0 && randomNumber != 0)
                {
                    column--;
                    row = columns;
                }
                else
                {
                    row++;
                }

                board[column, row - 1] = '*';
            }

            return board;
        }

        private static void CountAllNeighbourMines(char[,] board)
        {
            int column = board.GetLength(0);
            int row = board.GetLength(1);

            for (int i = 0; i < column; i++)
            {
                for (int j = 0; j < row; j++)
                {
                    if (board[i, j] != '*')
                    {
                        char neighbourMinesCount = CountNeighbourMines(board, i, j);
                        board[i, j] = neighbourMinesCount;
                    }
                }
            }
        }

        private static char CountNeighbourMines(char[,] board, int row, int column)
        {
            int count = 0;
            int rows = board.GetLength(0);
            int columns = board.GetLength(1);

            if (row - 1 >= 0)
            {
                if (board[row - 1, column] == '*')
                {
                    count++;
                }
            }

            if (row + 1 < rows)
            {
                if (board[row + 1, column] == '*')
                {
                    count++;
                }
            }

            if (column - 1 >= 0)
            {
                if (board[row, column - 1] == '*')
                {
                    count++;
                }
            }

            if (column + 1 < columns)
            {
                if (board[row, column + 1] == '*')
                {
                    count++;
                }
            }

            if ((row - 1 >= 0) && (column - 1 >= 0))
            {
                if (board[row - 1, column - 1] == '*')
                {
                    count++;
                }
            }

            if ((row - 1 >= 0) && (column + 1 < columns))
            {
                if (board[row - 1, column + 1] == '*')
                {
                    count++;
                }
            }

            if ((row + 1 < rows) && (column - 1 >= 0))
            {
                if (board[row + 1, column - 1] == '*')
                {
                    count++;
                }
            }

            if ((row + 1 < rows) && (column + 1 < columns))
            {
                if (board[row + 1, column + 1] == '*')
                {
                    count++;
                }
            }

            return char.Parse(count.ToString());
        }
    }
}