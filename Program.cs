using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
	class XO
	{

		static public void PrintTheme()
		{
			for (int i = 0; i < 5; i++)
			{
				for (int j = 0; j < 5; j++)
				{
					if (i == 0 & j == 0)
					{
						Console.Write(" ");
					}
					else if (i == 0 & j == 2)
					{
						Console.Write(" ");
					}
					else if (i == 0 & j == 4)
					{
						Console.Write(" ");
					}
					else if (i == 2 & j == 0)
					{
						Console.Write(" ");
					}
					else if (i == 2 & j == 2)
					{
						Console.Write(" ");
					}
					else if (i == 2 & j == 4)
					{
						Console.Write(" ");
					}
					else if (i == 4 & j == 0)
					{
						Console.Write(" ");
					}
					else if (i == 4 & j == 2)
					{
						Console.Write(" ");
					}
					else if (i == 4 & j == 4)
					{
						Console.Write(" ");
					}
					else Console.Write("░");
				}
				Console.WriteLine();
			}
		}
		static public void PrintX(ConsoleKeyInfo keyInfo)
		{
			if (keyInfo.Key == ConsoleKey.NumPad1)
			{
				Console.SetCursorPosition(0, 4); Console.WriteLine("X");
			}
			else if (keyInfo.Key == ConsoleKey.NumPad2)
			{
				Console.SetCursorPosition(2, 4); Console.WriteLine("X");
			}
			else if (keyInfo.Key == ConsoleKey.NumPad3)
			{
				Console.SetCursorPosition(4, 4); Console.WriteLine("X");
			}
			else if (keyInfo.Key == ConsoleKey.NumPad4)
			{
				Console.SetCursorPosition(0, 2); Console.WriteLine("X");
			}
			else if (keyInfo.Key == ConsoleKey.NumPad5)
			{
				Console.SetCursorPosition(2, 2); Console.WriteLine("X");
			}
			else if (keyInfo.Key == ConsoleKey.NumPad6)
			{
				Console.SetCursorPosition(4, 2); Console.WriteLine("X");
			}
			else if (keyInfo.Key == ConsoleKey.NumPad7)
			{
				Console.SetCursorPosition(0, 0); Console.WriteLine("X");
			}
			else if (keyInfo.Key == ConsoleKey.NumPad8)
			{
				Console.SetCursorPosition(2, 0); Console.WriteLine("X");
			}
			else if (keyInfo.Key == ConsoleKey.NumPad9)
			{
				Console.SetCursorPosition(4, 0); Console.WriteLine("X");
			}


		}
		static public void PrintO()
		{
			Random rnd = new Random();
			int[] setofnumbers = { 0, 2, 4 };
			Console.SetCursorPosition(setofnumbers[rnd.Next(setofnumbers[0], setofnumbers.Length)], setofnumbers[rnd.Next(setofnumbers[0], setofnumbers.Length)]);
			Console.WriteLine("O");

		}
		static public void ContainsO()
		{

		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			XO.PrintTheme();
			ConsoleKeyInfo keyInfo = Console.ReadKey(true);
			//while (keyInfo.Key != ConsoleKey.Escape)
			//{
			//	keyInfo = Console.ReadKey(true); 
			//	if (keyInfo.Key == ConsoleKey.UpArrow)
			//	{
			//		Console.SetCursorPosition(Console.CursorLeft , Console.CursorTop - 1);
			//	}
			//	else if (keyInfo.Key == ConsoleKey.DownArrow)
			//	{
			//		Console.SetCursorPosition(Console.CursorLeft , Console.CursorTop + 1);
			//	}
			//	else if (keyInfo.Key == ConsoleKey.LeftArrow)
			//	{
			//		Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
			//	}
			//	else if (keyInfo.Key == ConsoleKey.RightArrow)
			//	{
			//		Console.SetCursorPosition(Console.CursorLeft +1 , Console.CursorTop);
			//	}
			//}

			while (keyInfo.Key != ConsoleKey.Escape)
			{

				XO.PrintX(keyInfo);
				XO.PrintO();
				keyInfo = Console.ReadKey(true);

			}
		}
	}
}

