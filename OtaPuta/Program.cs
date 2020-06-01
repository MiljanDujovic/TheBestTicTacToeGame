using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtaPuta
{
	class Program
	{
		static public int[] row = new int[3] { 0, 1, 2 };
		static public void Print()
		{
			for (int i = 0; i < 3; i++)
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
			if (inputNumb <= 3 && inputNumb >= 1)
			{

			}
		}
		static void Main(string[] args)
		{
			Print();
			ConsoleKeyInfo keyInfo;
			while ((keyInfo = Console.ReadKey(true)).Key != ConsoleKey.Escape)
			{
				OnInput(keyInfo);
			}

		}
	}
}
