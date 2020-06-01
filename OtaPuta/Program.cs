using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtaPuta
{
	class Program
	{
		static public int[] row = new int[3];
		static public void Print()
		{
			for (int i = 0; i < 3; i++)
			{
				Console.Write(row[i]);
			}
		}
		static public void OnInput(ConsoleKeyInfo keyInfo)
		{
			int.TryParse(keyInfo.KeyChar.ToString(), out int inputNumb);
			if (inputNumb<=3&&inputNumb>=1)
			{
				Console.WriteLine(inputNumb);
			}
		}
		static void Main(string[] args)
		{
			Print();
			ConsoleKeyInfo keyInfo = Console.ReadKey(true);
			while (keyInfo.Key != ConsoleKey.Escape)
			{
				OnInput(keyInfo);
				keyInfo = Console.ReadKey(true);

			}

		}
	}
}
