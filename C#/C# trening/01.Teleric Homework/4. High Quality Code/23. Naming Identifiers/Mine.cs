namespace Minesweeper
{
    using System;
    using System.Collections.Generic;

    public class Mine
	{       
		static void Main(string[] args)
		{
			string command = string.Empty;
			char[,] gameField = CreateGameField();
			char[,] bombField = PutBombs();
			int counter = 0;
			bool isMineClicked = false;
			List<Result> playersResult = new List<Result>(6);
			int row = 0;
			int column = 0;
			bool isNewGame = true;
			const int maxScore = 35;
			bool isOpenCell = false;

			do
			{
				if (isNewGame)
				{
                    Console.WriteLine("Let's play to \"Minesweeper\". Try to find fields without mines. "+
                        "Command:\n -'top' shows ranking;\n -'restart' start new game;\n -'exit' close Minesweeper");                   
					DrawField(gameField);
					isNewGame = false;
				}

				Console.Write("Enter row and column : ");
				command = Console.ReadLine().Trim();

				if (command.Length >= 3)
				{
					if (int.TryParse(command[0].ToString(), out row) &&
					int.TryParse(command[2].ToString(), out column) &&
						row <= gameField.GetLength(0) && column <= gameField.GetLength(1))
					{
						command = "turn";
					}
				}
				switch (command)
				{
					case "top":
						Ranking(playersResult);
						break;
					case "restart":
						gameField = CreateGameField();
						bombField = PutBombs();
						DrawField(gameField);
						isMineClicked = false;
						isNewGame = false;
						break;
					case "exit":
						Console.WriteLine("Bye!");
						break;
					case "turn":
						if (bombField[row, column] != '*')
						{
							if (bombField[row, column] == '-')
							{
								Turn(gameField, bombField, row, column);
								counter++;
							}
							if (maxScore == counter)
							{
								isOpenCell = true;
							}
							else
							{
								DrawField(gameField);
							}
						}
						else
						{
							isMineClicked = true;
						}
						break;
					default:
						Console.WriteLine("\nIncorrect Command\n");
						break;
				}
				if (isMineClicked)
				{
					DrawField(bombField);
					Console.Write("\nYour score are {0} boxes. " + "Enter your name: ", counter);
					string nickName = Console.ReadLine();
					Result playerScore = new Result(nickName, counter);

					if (playersResult.Count < 5)
					{
						playersResult.Add(playerScore);
					}
					else
					{
						for (int i = 0; i < playersResult.Count; i++)
						{
							if (playersResult[i].Score < playerScore.Score)
							{
								playersResult.Insert(i, playerScore);
								playersResult.RemoveAt(playersResult.Count - 1);
								break;
							}
						}
					}
					playersResult.Sort((Result r1, Result r2) => r2.Name.CompareTo(r1.Name));
					playersResult.Sort((Result r1, Result r2) => r2.Score.CompareTo(r1.Score));
					Ranking(playersResult);

					gameField = CreateGameField();
					bombField = PutBombs();
					counter = 0;
					isMineClicked = false;
					isNewGame = true;
				}
				if (isOpenCell)
				{
					Console.WriteLine("\nBRAVOOOS! Otvri 35 kletki bez kapka kryv.");
					DrawField(bombField);
					Console.WriteLine("Daj si imeto, batka: ");
					string imeee = Console.ReadLine();
					Result to4kii = new Result(imeee, counter);
					playersResult.Add(to4kii);
					Ranking(playersResult);
					gameField = CreateGameField();
					bombField = PutBombs();
					counter = 0;
					isOpenCell = false;
					isNewGame = true;
				}
			}
			while (command != "exit");
			Console.WriteLine("Made in Bulgaria - Uauahahahahaha!");
			Console.WriteLine("AREEEEEEeeeeeee.");
			Console.Read();
		}

		private static void Ranking(List<Result> result)
		{
			Console.WriteLine("\nScore:");

			if (result.Count > 0)
			{
				for (int i = 0; i < result.Count; i++)
				{
                    Console.WriteLine("{0}. {1} --> {2} boxes", i + 1, result[i].Name, result[i].Score);
				}
				Console.WriteLine();
			}
			else
			{
				Console.WriteLine("Empty ranking!\n");
			}
		}

		private static void Turn(char[,] Field, char[,] Bombs, int row, int col)
		{
			char kolkoBombi = NumberOfMines(Bombs, row, col);
			Bombs[row, col] = kolkoBombi;
			Field[row, col] = kolkoBombi;
		}

		private static void DrawField(char[,] board)
		{
			int rows = board.GetLength(0);
			int cols = board.GetLength(1);
			Console.WriteLine("\n    0 1 2 3 4 5 6 7 8 9");
			Console.WriteLine("   ---------------------");
			for (int row = 0; row < rows; row++)
			{
				Console.Write("{0} | ", row);
				for (int col = 0; col < cols; col++)
				{
					Console.Write(string.Format("{0} ", board[row, col]));
				}
				Console.Write("|");
				Console.WriteLine();
			}
			Console.WriteLine("   ---------------------\n");
		}

		private static char[,] CreateGameField()
		{
			int boardRows = 5;
			int boardColumns = 10;
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

		private static char[,] PutBombs()
		{
			int Редове = 5;
			int Колони = 10;
			char[,] игрално_поле = new char[Редове, Колони];

			for (int i = 0; i < Редове; i++)
			{
				for (int j = 0; j < Колони; j++)
				{
					игрално_поле[i, j] = '-';
				}
			}

			List<int> r3 = new List<int>();
			while (r3.Count < 15)
			{
				Random random = new Random();
				int asfd = random.Next(50);
				if (!r3.Contains(asfd))
				{
					r3.Add(asfd);
				}
			}

			foreach (int i2 in r3)
			{
				int kol = (i2 / Колони);
				int red = (i2 % Колони);
				if (red == 0 && i2 != 0)
				{
					kol--;
					red = Колони;
				}
				else
				{
					red++;
				}
				игрално_поле[kol, red - 1] = '*';
			}

			return игрално_поле;
		}

		private static void smetki(char[,] pole)
		{
			int kol = pole.GetLength(0);
			int red = pole.GetLength(1);

			for (int i = 0; i < kol; i++)
			{
				for (int j = 0; j < red; j++)
				{
					if (pole[i, j] != '*')
					{
						char kolkoo = NumberOfMines(pole, i, j);
						pole[i, j] = kolkoo;
					}
				}
			}
		}

		private static char NumberOfMines(char[,] cells, int row, int col)
		{
			int countMines = 0;
			int rows = cells.GetLength(0);
			int cols = cells.GetLength(1);

			if (row - 1 >= 0)
			{
				if (cells[row - 1, col] == '*')
				{ 
					countMines++; 
				}
			}
			if (row + 1 < rows)
			{
				if (cells[row + 1, col] == '*')
				{ 
					countMines++; 
				}
			}
			if (col - 1 >= 0)
			{
				if (cells[row, col - 1] == '*')
				{ 
					countMines++;
				}
			}
			if (col + 1 < cols)
			{
				if (cells[row, col + 1] == '*')
				{ 
					countMines++;
				}
			}
			if ((row - 1 >= 0) && (col - 1 >= 0))
			{
				if (cells[row - 1, col - 1] == '*')
				{ 
					countMines++; 
				}
			}
			if ((row - 1 >= 0) && (col + 1 < cols))
			{
				if (cells[row - 1, col + 1] == '*')
				{ 
					countMines++; 
				}
			}
			if ((row + 1 < rows) && (col - 1 >= 0))
			{
				if (cells[row + 1, col - 1] == '*')
				{ 
					countMines++; 
				}
			}
			if ((row + 1 < rows) && (col + 1 < cols))
			{
				if (cells[row + 1, col + 1] == '*')
				{ 
					countMines++; 
				}
			}
			return char.Parse(countMines.ToString());
		}
	}
}
