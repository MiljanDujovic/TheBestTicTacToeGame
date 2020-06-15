using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtaPuta {
	class Program {
		enum XO {
			X = 1, O
		}
		static public int[,] matrix = new int[3, 3];
		static public int GetWinner() {
			int symbolX = 1;
			int symbolO = 2;
			if (matrix[0, 0] == symbolX) if (matrix[1, 1] == symbolX) if (matrix[2, 2] == symbolX) return symbolX;
			if (matrix[0, 0] == symbolO) if (matrix[1, 1] == symbolO) if (matrix[2, 2] == symbolO) return symbolO;
			if (matrix[0, 0] == symbolX) if (matrix[0, 1] == symbolX) if (matrix[0, 2] == symbolX) return symbolX;
			if (matrix[0, 0] == symbolO) if (matrix[0, 1] == symbolO) if (matrix[0, 2] == symbolO) return symbolO;
			if (matrix[1, 0] == symbolX) if (matrix[1, 1] == symbolX) if (matrix[1, 2] == symbolX) return symbolX;
			if (matrix[1, 0] == symbolO) if (matrix[1, 1] == symbolO) if (matrix[1, 2] == symbolO) return symbolO;
			if (matrix[2, 0] == symbolX) if (matrix[2, 1] == symbolX) if (matrix[2, 2] == symbolX) return symbolX;
			if (matrix[2, 0] == symbolO) if (matrix[2, 1] == symbolO) if (matrix[2, 2] == symbolO) return symbolO;
			if (matrix[2, 0] == symbolX) if (matrix[1, 1] == symbolX) if (matrix[0, 2] == symbolX) return symbolX;
			if (matrix[2, 0] == symbolO) if (matrix[1, 1] == symbolO) if (matrix[0, 2] == symbolO) return symbolO;
			if (matrix[0, 0] == symbolX) if (matrix[1, 0] == symbolX) if (matrix[2, 0] == symbolX) return symbolX;
			if (matrix[0, 0] == symbolO) if (matrix[1, 0] == symbolO) if (matrix[2, 0] == symbolO) return symbolO;
			if (matrix[0, 1] == symbolX) if (matrix[1, 1] == symbolX) if (matrix[2, 1] == symbolX) return symbolX;
			if (matrix[0, 1] == symbolO) if (matrix[1, 1] == symbolO) if (matrix[2, 1] == symbolO) return symbolO;
			if (matrix[0, 2] == symbolX) if (matrix[1, 2] == symbolX) if (matrix[2, 2] == symbolX) return symbolX;
			if (matrix[0, 2] == symbolO) if (matrix[1, 2] == symbolO) if (matrix[2, 2] == symbolO) return symbolO;
			if (isNotFilled()) return -1;
			return 0;
		}

		static public bool isNotFilled() {
			for (int i = 0; i < 3; i++) {
				for (int j = 0; j < 3; j++) {
					if (matrix[i, j] == 0) {
						return true;
					}
				}
			}
			return false;
		}
		static public void RandomInput() {
			if (isNotFilled()) {
				int row = rnd.Next(0, 3);
				int col = rnd.Next(0, 3);
				if (matrix[row, col] == 0) {
					//if (true) {

					//}
					matrix[row, col] = (int)XO.O;
				}
				else {
					RandomInput();
				}
			}
		}
		static public void Print() {
			//Console.Clear();
			for (int i = 0; i < 3; i++) {
				for (int j = 0; j < 3; j++) {
					if (matrix[i, j] == 0) {
						Console.Write("*");
					}
					else if (matrix[i, j] == 1) {
						Console.Write("X");
					}
					else if (matrix[i, j] == 2) {
						Console.Write("O");
					}
				}
				Console.WriteLine();
			}
			//	Console.Write("Pobednik je: ");
			//	switch (GetWinner()) {
			//		case 0:
			//			Console.Write("Nereseno");
			//			break;
			//		case 1:
			//			Console.Write("Iks");
			//			break;
			//		case 2:
			//			Console.Write("Oks");
			//			break;
			//		case -1:
			//			Console.WriteLine("Niko");
			//			break;
			//		default:
			//			break;
			//	}


		}
		static public int minimax(bool isMax) {
			Print();
			Console.WriteLine("Max: "+ isMax);
			var result = GetWinner();
			if (result != -1) {
				switch (result) {
					case 1:
						return -1;
					case 2:
						return 1;
					case 0:
						return 0;
				}
			}
			if (isMax) {
				var bestScore = -9999;
				for (int i = 0; i < 3; i++) {
					for (int j = 0; j < 3; j++) {
						if (matrix[i, j] == 0) {
							matrix[i, j] = 2;
							var score = minimax(false);
							matrix[i, j] = 0;
							if (score > bestScore) {
								bestScore = score;
							}
						}
					}
				}
				return bestScore;
			}
			else {
				var bestScore = 9999;
				for (int i = 0; i < 3; i++) {
					for (int j = 0; j < 3; j++) {
						if (matrix[i, j] == 0) {
							matrix[i, j] = 1;
							var score = minimax(true);
							matrix[i, j] = 0;
							if (score < bestScore) {
								bestScore = score;
							}
						}
					}
				}
				return bestScore;
			}

		}
		static public Random rnd = new Random();
		static public void OnInput(ConsoleKeyInfo keyInfo) {
			if (keyInfo.Key == ConsoleKey.Escape) {
				Environment.Exit(0);
			}
			if (keyInfo.Key == ConsoleKey.Enter) {
				Console.Clear();
				matrix = new int[3, 3];
				Print();
			}

			int.TryParse(keyInfo.KeyChar.ToString(), out int inputNumb);
			if (inputNumb <= 9 && inputNumb >= 1) {
				if (GetWinner() == -1) {
					int index = inputNumb - 1;
					int row = 2 - index / 3;
					int col = index % 3;
					if (matrix[row, col] == 0) {
						matrix[row, col] = 1;
						//RandomInput();
						for (int i = 0; i < 3; i++) {
							for (int j = 0; j < 3; j++) {
								if (matrix[i, j] == 0) {
									matrix[i, j] = (int)XO.O;
									minimax(false);
									matrix[i, j] = 0;
								}
							}
						}
					}
				}
			}
		}
		static void Main(string[] args) {
			//Print();
			while (true) {
				OnInput(Console.ReadKey(true));
				//Print();
			}
		}
	}
}

