using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
	class XO
	{
		static public void PrintXO(ConsoleKeyInfo keyInfo)
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
			if (keyInfo.Key == ConsoleKey.Q)
			{
				Console.SetCursorPosition(0, 0); Console.WriteLine("O");

			}
			else if (keyInfo.Key == ConsoleKey.W)
			{
				Console.SetCursorPosition(2, 0); Console.WriteLine("O");

			}
			else if (keyInfo.Key == ConsoleKey.E)
			{
				Console.SetCursorPosition(4, 0); Console.WriteLine("O");

			}
			else if (keyInfo.Key == ConsoleKey.A)
			{
				Console.SetCursorPosition(0, 2); Console.WriteLine("O");

			}
			else if (keyInfo.Key == ConsoleKey.S)
			{
				Console.SetCursorPosition(2, 2); Console.WriteLine("O");

			}
			else if (keyInfo.Key == ConsoleKey.D)
			{
				Console.SetCursorPosition(4, 2); Console.WriteLine("O");

			}
			else if (keyInfo.Key == ConsoleKey.Z)
			{
				Console.SetCursorPosition(0, 4); Console.WriteLine("O");

			}
			else if (keyInfo.Key == ConsoleKey.X)
			{
				Console.SetCursorPosition(2, 4); Console.WriteLine("O");

			}
			else if (keyInfo.Key == ConsoleKey.C)
			{
				Console.SetCursorPosition(4, 4); Console.WriteLine("O");
			}
		}
	}
	class Program
	{
		static void Main(string[] args)
		{
			Console.SetWindowSize(60, 30);
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
				keyInfo = Console.ReadKey(true);
				XO.PrintXO(keyInfo);

			}


		}
	}
}
