using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
	class X
	{
		static public void Print(ConsoleKeyInfo keyInfo)
		{
				if (keyInfo.Key == ConsoleKey.NumPad1)
				{
					Console.SetCursorPosition( 0,  0);
					
				}
				else if (keyInfo.Key == ConsoleKey.NumPad2)
				{
					Console.SetCursorPosition( 2,  0);
					
				}
				else if (keyInfo.Key == ConsoleKey.NumPad3)
				{
					Console.SetCursorPosition( 4,  0);
					
				}
				else if (keyInfo.Key == ConsoleKey.NumPad4)
				{
					Console.SetCursorPosition( 0,  2);
					
				}
				else if (keyInfo.Key == ConsoleKey.NumPad5)
				{
					Console.SetCursorPosition(2,  2);
					
				}
				else if (keyInfo.Key == ConsoleKey.NumPad6)
				{
					Console.SetCursorPosition( 4,  2);
					
				}
				else if (keyInfo.Key == ConsoleKey.NumPad7)
				{
					Console.SetCursorPosition( 0,  4);
					
				}
				else if (keyInfo.Key == ConsoleKey.NumPad8)
				{
					Console.SetCursorPosition( 2,  4);
					
				}				
				else if (keyInfo.Key == ConsoleKey.NumPad9)
				{
					Console.SetCursorPosition( 4,  4);
				}
				Console.WriteLine("X");
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
				X.Print(keyInfo);
			}


		}
	}
}
