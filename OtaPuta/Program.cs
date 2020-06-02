using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtaPuta
{
	class Program
	{
		static public int[,] row = new int[3,3] { { 0, 0, 0 }, { 0, 0, 0 }, { 0, 0, 0 } };
		static public void Print()
		{
			Console.Clear();
			for (int i = 0; i < 3; i++)
			{
				for (int j = 0; j < 3; j++)
				{
					if (row[i,j] == 0)
					{
						Console.Write("*");
					}
					else if (row[i,j] == 1)
					{
						Console.Write("X");
					}
					else if (row[i,j] == 2)
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
			if (inputNumb <= 3 && inputNumb >= 1)
			{
				if (row[0,inputNumb-1] ==0)
				{
					row[0,inputNumb - 1] = 1;
				}
				
			}
			else if (inputNumb>3 && inputNumb<=6)
			{
				if (row[1, inputNumb - 4] == 0)
				{
					row[1, inputNumb - 4] = 1;
				}
			}
			else if (inputNumb > 6 && inputNumb <= 9)
			{
				if (row[2, inputNumb - 7] == 0)
				{
					row[2, inputNumb - 7] = 1;
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

		}
	}
}
