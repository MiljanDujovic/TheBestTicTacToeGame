using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtaPuta
{
	class Program
	{

		static public Dictionary<int, char> StarTheme = new Dictionary<int, char>() { { 1, '*' }, { 2, '*' }, { 3, '*' } };
		static public void Theme()
		{
			
			foreach (var item in StarTheme)
			{
				Console.Write(item.Value);
			}
		}
		static public void OnInput(ConsoleKeyInfo keyInfo)
		{
			Console.Clear();
			StarTheme[1] = '*'; StarTheme[2] = '*'; StarTheme[3] = '*';
			int.TryParse(keyInfo.KeyChar.ToString(), out int result);
			if (result == 1)
			{
				StarTheme[1] = 'X';
			}
			else if (result == 2)
			{
				StarTheme[2] = 'X';
			}
			else if (result == 3)
			{
				StarTheme[3] = 'X';
			}
		}
		static void Main(string[] args)
		{
			
			ConsoleKeyInfo keyInfo = Console.ReadKey(true);
			while (keyInfo.Key != ConsoleKey.Escape)
			{
				OnInput(keyInfo);
				Theme();
				keyInfo = Console.ReadKey(true);
				
			}

		}
	}
}
