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
			ConsoleKeyInfo info = Console.ReadKey();
			int index = 0;
			while (Console.ReadKey().Key != ConsoleKey.Escape)
			{
				
				if (info.Key == ConsoleKey.DownArrow)
				{
					Console.SetCursorPosition(0, index + 1);
				}
				else if (info.Key == ConsoleKey.UpArrow)
				{
					Console.SetCursorPosition(0, index -1);
				}
				else if (info.Key == ConsoleKey.RightArrow)
				{
					Console.SetCursorPosition(index +1, 0);
				}
				else if (info.Key == ConsoleKey.LeftArrow)
				{
					Console.SetCursorPosition(index -1, 0);
				}
				index= index+1;
				
				info = Console.ReadKey();
			}
		}
	}
}
