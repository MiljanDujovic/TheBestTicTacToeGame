using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtaPuta
{
	class Program
	{
		static public int[] row = new int[5] { 0, 0, 0, 2, 0 };
		static public void Print()
		{
			Console.Clear();
			for (int i = 0; i < row.Length; i++)
			{
				if (row[i] == 0)
				{
					Console.Write("*");
				}
				else if (row[i] == 1)
				{
					Console.Write("X");
				}
				else if (row[i] == 2)
				{
					Console.Write("O");
				}
			}
		}
		static public void OnInput(ConsoleKeyInfo keyInfo)
		{
			int.TryParse(keyInfo.KeyChar.ToString(), out int inputNumb);
			if (inputNumb <= 5 && inputNumb >= 1)
			{
				if (row[inputNumb-1] ==0)
				{
					row[inputNumb - 1] = 1;
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
