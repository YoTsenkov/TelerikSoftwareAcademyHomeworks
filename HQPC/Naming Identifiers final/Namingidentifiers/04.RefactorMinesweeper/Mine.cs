namespace _04.RefactorMinesweeper
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Mine
    {
        static void Main(string[] arguments)
        {
            const int MaxMovesAllowed = 35;
            string inputCommand = string.Empty;
            char[,] playingField = CreatePlayingField();
            char[,] bombsField = CreateBombsField();
            int playedMovesCounter = 0;
            bool hasExploded = false;
            List<Score> topScorers = new List<Score>(6);
            int row = 0;
            int column = 0;
            bool gameStarted = true;
            bool gameEnded = false;

            do
            {
                if (gameStarted)
                {
                    Console.WriteLine("Lets play “Mines”. Test your luck and try to find the fields with no mines." +
                    " The command 'top' shows the ranklist, 'restart' starts a new game, 'exit' exits the game!");
                    CreateBoard(playingField);
                    gameStarted = false;
                }

                Console.Write("Enter row and column : ");
                inputCommand = Console.ReadLine().Trim();

                if (inputCommand.Length >= 3)
                {
                    if (int.TryParse(inputCommand[0].ToString(), out row) &&
                        int.TryParse(inputCommand[2].ToString(), out column) &&
                        row <= playingField.GetLength(0) && column <= playingField.GetLength(1))
                    {
                        inputCommand = "turn";
                    }
                }

                switch (inputCommand)
                {
                    case "top":
                        DisplayRanklist(topScorers);
                        break;
                    case "restart":
                        playingField = CreatePlayingField();
                        bombsField = CreateBombsField();
                        CreateBoard(playingField);
                        hasExploded = false;
                        gameStarted = false;
                        break;
                    case "exit":
                        Console.WriteLine("Bye bye!");
                        break;
                    case "turn":
                        if (bombsField[row, column] != '*')
                        {
                            if (bombsField[row, column] == '-')
                            {
                                YourTurn(playingField, bombsField, row, column);
                                playedMovesCounter++;
                            }

                            if (MaxMovesAllowed == playedMovesCounter)
                            {
                                gameEnded = true;
                            }
                            else
                            {
                                CreateBoard(playingField);
                            }
                        }
                        else
                        {
                            hasExploded = true;
                        }
                        break;
                    default:
                        Console.WriteLine("\nInvalid command\n");
                        break;
                }

                if (hasExploded)
                {
                    CreateBoard(bombsField);
                    Console.Write("\nYou have died heroicly with {0} points. " +
                        "Enter your nickname: ", playedMovesCounter);
                    string nickname = Console.ReadLine();
                    Score currentScore = new Score(nickname, playedMovesCounter);
                    if (topScorers.Count < 5)
                    {
                        topScorers.Add(currentScore);
                    }
                    else
                    {
                        for (int i = 0; i < topScorers.Count; i++)
                        {
                            if (topScorers[i].PlayerPoints < currentScore.PlayerPoints)
                            {
                                topScorers.Insert(i, currentScore);
                                topScorers.RemoveAt(topScorers.Count - 1);
                                break;
                            }
                        }
                    }

                    topScorers.Sort((Score firstScore, Score secondScore) => secondScore.PlayerName.CompareTo(firstScore.PlayerName));
                    topScorers.Sort((Score firstScore, Score secondScore) => secondScore.PlayerPoints.CompareTo(firstScore.PlayerPoints));
                    DisplayRanklist(topScorers);

                    playingField = CreatePlayingField();
                    bombsField = CreateBombsField();
                    playedMovesCounter = 0;
                    hasExploded = false;
                    gameStarted = true;
                }

                if (gameEnded)
                {
                    Console.WriteLine("\nGratz! You have successfully opened all 35 fields.");
                    CreateBoard(bombsField);
                    Console.WriteLine("Enter your nickname: ");
                    string nickname = Console.ReadLine();
                    Score currentScore = new Score(nickname, playedMovesCounter);
                    topScorers.Add(currentScore);
                    DisplayRanklist(topScorers);
                    playingField = CreatePlayingField();
                    bombsField = CreateBombsField();
                    playedMovesCounter = 0;
                    gameEnded = false;
                    gameStarted = true;
                }
            }
            while (inputCommand != "exit");
            {
                Console.WriteLine("Made in Bulgaria - Uauahahahahaha!");
                Console.WriteLine("Go get em gurl !!.");
                Console.Read();
            }
        }

        private static void DisplayRanklist(List<Score> scores)
        {
            Console.WriteLine("\nScores:");

            if (scores.Count > 0)
            {
                for (int i = 0; i < scores.Count; i++)
                {
                    Console.WriteLine("{0}. {1} --> {2} is hella sick playaaa",
                        i + 1, scores[i].PlayerName, scores[i].PlayerPoints);
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("The ranklist is empty!\n");
            }
        }

        private static void YourTurn(char[,] playingField,
            char[,] bombsField, int row, int col)
        {
            char bombsCounter = Count(bombsField, row, col);
            bombsField[row, col] = bombsCounter;
            playingField[row, col] = bombsCounter;
        }

        private static void CreateBoard(char[,] board)
        {
            int rows = board.GetLength(0);
            int cols = board.GetLength(1);

            Console.WriteLine("\n    0 1 2 3 4 5 6 7 8 9");
            Console.WriteLine("   ---------------------");

            for (int i = 0; i < rows; i++)
            {
                Console.Write("{0} | ", i);

                for (int k = 0; k < cols; k++)
                {
                    Console.Write(string.Format("{0} ", board[i, k]));
                }

                Console.Write("|");
                Console.WriteLine();
            }

            Console.WriteLine("   ---------------------\n");
        }

        private static char[,] CreatePlayingField()
        {
            int boardRows = 5;
            int boardColumns = 10;
            char[,] board = new char[boardRows, boardColumns];
            for (int i = 0; i < boardRows; i++)
            {
                for (int k = 0; k < boardColumns; k++)
                {
                    board[i, k] = '?';
                }
            }

            return board;
        }

        private static char[,] CreateBombsField()
        {
            int rows = 5;
            int cols = 10;
            char[,] playingField = new char[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int k = 0; k < cols; k++)
                {
                    playingField[i, k] = '-';
                }
            }

            List<int> r3 = new List<int>();

            while (r3.Count < 15)
            {
                Random random = new Random();
                int number = random.Next(50);

                if (!r3.Contains(number))
                {
                    r3.Add(number);
                }
            }

            foreach (int number in r3)
            {
                int col = (number / cols);
                int row = (number % cols);

                if (row == 0 && number != 0)
                {
                    col--;
                    row = cols;
                }
                else
                {
                    row++;
                }

                playingField[col, row - 1] = '*';
            }

            return playingField;
        }

        private static void Calculations(char[,] field)
        {
            int col = field.GetLength(0);
            int row = field.GetLength(1);

            for (int i = 0; i < col; i++)
            {
                for (int k = 0; k < row; k++)
                {
                    if (field[i, k] != '*')
                    {
                        char count = Count(field, i, k);
                        field[i, k] = count;
                    }
                }
            }
        }

        private static char Count(char[,] bombsField, int rows, int cols)
        {
            int bombsCounter = 0;
            int bombFieldRows = bombsField.GetLength(0);
            int bombFieldCols = bombsField.GetLength(1);

            if (rows - 1 >= 0)
            {
                if (bombsField[rows - 1, cols] == '*')
                {
                    bombsCounter++;
                }
            }

            if (rows + 1 < bombFieldRows)
            {
                if (bombsField[rows + 1, cols] == '*')
                {
                    bombsCounter++;
                }
            }

            if (cols - 1 >= 0)
            {
                if (bombsField[rows, cols - 1] == '*')
                {
                    bombsCounter++;
                }
            }
            if (cols + 1 < bombFieldCols)
            {
                if (bombsField[rows, cols + 1] == '*')
                {
                    bombsCounter++;
                }
            }

            if ((rows - 1 >= 0) && (cols - 1 >= 0))
            {
                if (bombsField[rows - 1, cols - 1] == '*')
                {
                    bombsCounter++;
                }
            }

            if ((rows - 1 >= 0) && (cols + 1 < bombFieldCols))
            {
                if (bombsField[rows - 1, cols + 1] == '*')
                {
                    bombsCounter++;
                }
            }

            if ((rows + 1 < bombFieldRows) && (cols - 1 >= 0))
            {
                if (bombsField[rows + 1, cols - 1] == '*')
                {
                    bombsCounter++;
                }
            }

            if ((rows + 1 < bombFieldRows) && (cols + 1 < bombFieldCols))
            {
                if (bombsField[rows + 1, cols + 1] == '*')
                {
                    bombsCounter++;
                }
            }

            return char.Parse(bombsCounter.ToString());
        }
    }
}
