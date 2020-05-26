using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.SetWindowSize(60, 30);
			ConsoleKeyInfo keyInfo = Console.ReadKey(true);
			while (keyInfo.Key != ConsoleKey.Escape)
			{
				keyInfo = Console.ReadKey(true);
				if (keyInfo.Key == ConsoleKey.UpArrow)
				{
					Console.SetCursorPosition(Console.CursorLeft , Console.CursorTop - 1);
				}
				else if (keyInfo.Key == ConsoleKey.DownArrow)
				{
					Console.SetCursorPosition(Console.CursorLeft , Console.CursorTop + 1);
				}
				else if (keyInfo.Key == ConsoleKey.LeftArrow)
				{
					Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
				}
				else if (keyInfo.Key == ConsoleKey.RightArrow)
				{
					Console.SetCursorPosition(Console.CursorLeft +1 , Console.CursorTop);
				}
			}

		}
	}
}
