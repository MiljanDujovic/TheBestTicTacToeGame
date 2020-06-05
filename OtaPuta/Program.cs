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
		static public void RandomInput(int row, int col)
		{

				if (matrix[row, col] != 1)
				{
					matrix[row, col] = (int)XO.X;
				}
				else
				{
					RandomInput(rnd.Next(0, 3), rnd.Next(0, 3));
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
			//if (inputNumb <= 9 && inputNumb >= 1)
			//{
			//	int index = inputNumb - 1;
			//	int row = 2 - index / 3;
			//	int col = index % 3;
			//	matrix[row, col] = 1;

			//}
			if (inputNumb == 1)
			{
				RandomInput(rnd.Next(0,3),rnd.Next(0,3));
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
		}
	}
}

