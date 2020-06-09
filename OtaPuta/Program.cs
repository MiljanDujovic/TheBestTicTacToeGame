using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtaPuta
{
	class Program
	{
		enum XO
		{
			X = 1, O
		}
		static public int[,] matrix = new int[3, 3];
		static public int GetWinner()
		{
			int countD0 = 0;
			int countD1 = 0;
			int countD2 = 0;
			int countR0 = 0;
			int countR1 = 0;
			int countR2 = 0;
			int countC0 = 0;
			int countC1 = 0;
			int countC2 = 0;
			for (int i = 0; i < 3; i++)
			{
				for (int j = 0; j < 3; j++)
				{
					if ((i == 0 & j == 2) & matrix[i, j] == 1)
					{
						countD1++;

					}
					if ((i == 1 & j == 1) & matrix[i, j] == 1)
					{
						countD1++;

					}
					if ((i == 2 & j == 0) & matrix[i, j] == 1)
					{
						countD1++;

					}
					if (countD1 == 3)
					{
						return 1;
					}
					if (i == j & matrix[i, j] == 1)
					{
						countD0++;
						if (countD0 == 3)
						{
							return 1;
						}
					}
					if (i == 0 & matrix[i, j] == 1)
					{
						countR0++;
						if (countR0 == 3)
						{
							return 1;
						}
					}
					if (i == 1 & matrix[i, j] == 1)
					{
						countR1++;
						if (countR1 == 3)
						{
							return 1;
						}
					}
					if (i == 2 & matrix[i, j] == 1)
					{
						countR2++;
						if (countR2 == 3)
						{
							return 1;
						}
					}
					if (j == 0 & matrix[i, j] == 1)
					{
						countC0++;
						if (countC0 == 3)
						{
							return 1;
						}
					}
					if (j == 1 & matrix[i, j] == 1)
					{
						countC1++;
						if (countC1 == 3)
						{
							return 1;
						}
					}
					if (j == 2 & matrix[i, j] == 1)
					{
						countC2++;
						if (countC2 == 3)
						{
							return 1;
						}
					}

				}
			}
			return 0;
		}
		static public bool isNotFilled()
		{
			for (int i = 0; i < 3; i++)
			{
				for (int j = 0; j < 3; j++)
				{
					if (matrix[i, j] == 0)
					{
						return true;
					}
				}
			}
			return false;
		}
		static public void RandomInput(int row, int col)
		{

			if (matrix[row, col] == 0)
			{
				matrix[row, col] = (int)XO.O;
			}
			else
			{
				if (isNotFilled())
				{
					RandomInput(rnd.Next(0, 3), rnd.Next(0, 3));
				}
			}
		}
		static public void Print()
		{
			Console.Clear();
			for (int i = 0; i < 3; i++)
			{
				for (int j = 0; j < 3; j++)
				{
					if (matrix[i, j] == 0)
					{
						Console.Write("*");
					}
					else if (matrix[i, j] == 1)
					{
						Console.Write("X");
					}
					else if (matrix[i, j] == 2)
					{
						Console.Write("O");
					}
				}
				Console.WriteLine();
			}
		}
		static public Random rnd = new Random();
		static public void OnInput(ConsoleKeyInfo keyInfo)
		{
			int.TryParse(keyInfo.KeyChar.ToString(), out int inputNumb);
			if (inputNumb <= 9 && inputNumb >= 1)
			{
				int index = inputNumb - 1;
				int row = 2 - index / 3;
				int col = index % 3;
				if (matrix[row, col] == 0)
				{
					matrix[row, col] = 1;
					RandomInput(rnd.Next(0, 3), rnd.Next(0, 3));
				}
			}
		}
		static void Main(string[] args)
		{
			Print();
			ConsoleKeyInfo keyInfo;
			while ((keyInfo = Console.ReadKey(true)).Key != ConsoleKey.Escape)
			{
				OnInput(keyInfo);
				Print();
			}
			Console.WriteLine("Pobednik je: " + GetWinner());

			Console.ReadLine();
		}
	}
}

