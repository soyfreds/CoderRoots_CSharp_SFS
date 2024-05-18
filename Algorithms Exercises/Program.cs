using System;
using System.Collections.Generic;
using System.Linq;

namespace Ejercisios_Practicas_Algoritmos
{
	class Program
	{
		static void Main(string[] args)
		{
			// Mini_Max_Sum
			Console.WriteLine("-------------Mini_Max_Sum-----------------");
			List<int> arr = new List<int> { 8, 2, 7, 4, 10, 1 };
			functions.Mini_Max_Sum(arr);
			Console.WriteLine("--------------------------------------------");
			Console.WriteLine("\n");
			//--------------------------------------------

			// Time_Conversion
			Console.WriteLine("-------------Time_Conversion-----------------");
			string s = "07:05:45 pm";
			functions.Time_Conversion(s);
			Console.WriteLine("--------------------------------------------");
			Console.WriteLine("\n");
			//--------------------------------------------

			// FizzBuzz
			Console.WriteLine("-------------FizzBuzz-----------------");
			int n = 15;
			functions.FizzBuzz(n);
			Console.WriteLine("--------------------------------------------");
			Console.WriteLine("\n");
			//--------------------------------------------

			// findMedian
			Console.WriteLine("-------------findMedian-----------------");
			List<int> arr2 = new List<int> { 0, 2, 1, 3, 4, 7, 6, 5, 9 };
			functions.findMedian(arr2);
			Console.WriteLine("--------------------------------------------");
			Console.WriteLine("\n");
			//--------------------------------------------

			// lonelyInterger
			Console.WriteLine("-------------lonelyInterger-----------------");
			List<int> arr3 = new List<int> { 1, 2, 3, 4, 3, 2, 1 };
			functions.lonelyInterger(arr3);
			Console.WriteLine("--------------------------------------------");
			Console.WriteLine("\n");
			//--------------------------------------------

			// diagonalDifference
			Console.WriteLine("-------------diagonalDifference-----------------");
			functions.diagonalDifference();
			Console.WriteLine("--------------------------------------------");
			Console.WriteLine("\n");
			//--------------------------------------------

			// matrixListsSublist
			Console.WriteLine("-------------matrixListsSublist-----------------");
			functions.matrixListsSublist();
			Console.WriteLine("--------------------------------------------");
			Console.WriteLine("\n");
			//--------------------------------------------

			// diagonalDifferencePro
			Console.WriteLine("-------------diagonalDifferencePro-----------------");
			List<List<int>> outerList = new List<List<int>>
			{   new List<int>(){1, 2, 3},
				new List<int>(){4,5,6},
				new List<int>(){9,8,9}
			};
			functions.diagonalDifferencePro(outerList);
			Console.WriteLine("--------------------------------------------");
			Console.WriteLine("\n");
			//--------------------------------------------

			// countingSort
			Console.WriteLine("-------------countingSort-----------------");
			List<int> arr4 = new List<int> { 63, 25, 73, 1, 98, 73, 56, 84, 86, 57, 16, 83, 8, 25, 81, 56, 9 ,53,
				98, 67, 99, 12, 83, 89, 80, 91, 39, 86, 76, 85, 74, 39, 25, 90, 59, 10, 94, 32, 44, 3, 89, 30,
				27, 79, 46, 96, 27, 32, 18, 21, 92, 69, 81, 40, 40, 34, 68, 78, 24, 87, 42, 69, 23, 41, 78, 22,
				6 ,90, 99, 89, 50, 30, 20, 1, 43, 3, 70, 95, 33, 46, 44, 9 ,69, 48, 33, 60, 65, 16, 82, 67, 61,
				32, 21, 79, 75, 75, 13, 87, 70, 33 };
			functions.countingSort(arr4);
			Console.WriteLine("--------------------------------------------");
			Console.WriteLine("\n");
			//--------------------------------------------

			// flippingTheMatrix
			Console.WriteLine("-------------flippingTheMatrix-----------------");
			functions.flippingTheMatrix();
			Console.WriteLine("--------------------------------------------");
			Console.WriteLine("\n");
			//--------------------------------------------

			// flippingTheMatrix2
			Console.WriteLine("-------------flippingTheMatrix2-----------------");
			List<List<int>> matrixList = new List<List<int>>
			{   new List<int>(){112,42,83,119},
				new List<int>(){56,125,56,49},
				new List<int>(){15,78,101,43},
				new List<int>(){62,98,114,108}
			};
			int primerCuadrante = functions.flippingMatrix(matrixList);
			Console.WriteLine("La suma del primer cuadrante de la Matrix es {0}", primerCuadrante);
			Console.WriteLine("--------------------------------------------");
			Console.WriteLine("\n");
			//--------------------------------------------

			// Palindrome
			Console.WriteLine("-------------Palindrome-----------------");
			functions.Palindrome();
			Console.WriteLine("--------------------------------------------");
			Console.WriteLine("\n");
			//--------------------------------------------

			// CaesarCipher
			Console.WriteLine("-------------CaesarCipher-----------------");
			functions.CaesarCipher("middle-Outz", 3);
			Console.WriteLine("--------------------------------------------");
			Console.WriteLine("\n");
			//--------------------------------------------

			// BinarySearchPerform - Divide and Conquer
			Console.WriteLine("-------------BinarySearchPerform - Divide and Conquer-----------------");
			List<int> lista = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 25, 45, 68, 79, 254, 877, 1000, 5000321, 8559623 };
			int buscado = 1000;
			int respuesta = functions.BinarySearchPerform(lista, buscado);
			Console.WriteLine("El dato buscado es {0} y está ubicado en la posición {1} de la lista.", buscado, respuesta);
			//------------------------------------------------------
			Console.WriteLine("--------------------------------------------");
			Console.WriteLine("\n");
			//--------------------------------------------



		}


		public class functions
		{
			public static void Mini_Max_Sum(List<int> arr)
			{
				arr.Sort();
				int min = arr[0];
				int max = arr[arr.Count() - 1];
				int SumMin = 0;
				int SumMax = 0;


				foreach (int item in arr)
				{
					Console.WriteLine(item);
					if (item != max)
					{
						SumMin = SumMin + item;
					}

					if (item != min)
					{
						SumMax = SumMax + item;
					}
				}
				Console.WriteLine(SumMin + " " + SumMax);
			}

			public static void Time_Conversion(string s)
			{
				DateTime dateTime = DateTime.Parse(s);
				Console.WriteLine(dateTime.ToString("HH:mm:ss"));


			}

			public static void FizzBuzz(int n)
			{
				for (int i = 1; i <= n; i++)
				{
					if (i % 3 == 0 && i % 5 == 0)
					{
						Console.WriteLine("FizzBuzz");
					}
					else

					if (i % 3 == 0)
					{
						Console.WriteLine("Fizz");
					}
					else

					if (i % 5 == 0)
					{

						Console.WriteLine("Buzz");
					}
					else
					{
						Console.WriteLine(i);
					}

				}
			}

			public static int findMedian(List<int> arr)
			{
				arr.Sort();
				int mid = (arr.Count() - 1) / 2;
				int solv = arr[mid];
				Console.WriteLine("Encontrando el mediano: {0}", solv);
				return solv;
			}

			public static int lonelyInterger(List<int> a)
			{
				List<int> twice = new List<int>();
				List<int> compare = new List<int>();
				int notRep = 0;

				for (int i = 0; i < a.LongCount(); i++)
				{
					if (compare.Contains(a[i]))
					{
						twice.Add(a[i]);
					}
					else
					{
						compare.Add(a[i]);
					}
				}

				for (int i = 0; i < a.LongCount(); i++)
				{
					if (twice.Contains(a[i]))
					{

					}
					else
					{
						notRep = a[i];
					}
				}
				Console.WriteLine("El no repetido es: {0}", notRep);
				return notRep;
			}

			public static void diagonalDifference()
			{
				int[,] matriz = new int[3, 3];
				matriz[0, 0] = 1;
				matriz[0, 1] = 2;
				matriz[0, 2] = 3;
				matriz[1, 0] = 4;
				matriz[1, 1] = 5;
				matriz[1, 2] = 6;
				matriz[2, 0] = 9;
				matriz[2, 1] = 8;
				matriz[2, 2] = 9;

				int diag1 = 0;
				int diag2 = 0;

				Console.WriteLine("Ejercisio diagonalDifference\nDibujo la Matriz:");
				for (int i = 0; i < matriz.GetLength(0); i++)
				{
					for (int e = 0; e < matriz.GetLength(1); e++)
					{
						Console.Write(" " + matriz[i, e] + " ");
					}
					Console.WriteLine("\n");
				}

				//Sum and diference
				for (int i = 0; i < matriz.GetLength(0); i++)
				{
					for (int e = 0; e < matriz.GetLength(1); e++)
					{
						if (i == 0 && e == 0)
						{
							diag1 = diag1 + matriz[i, e];
						}
						if (i == 0 && e == 2)
						{
							diag2 = diag2 + matriz[i, e];
						}
						if (i == 1 && e == 1)
						{
							diag1 = diag1 + matriz[i, e];
							diag2 = diag2 + matriz[i, e];
						}
						if (i == 2 && e == 0)
						{
							diag1 = diag1 + matriz[i, e];
						}
						if (i == 2 && e == 2)
						{
							diag2 = diag2 + matriz[i, e];
						}
					}
				}
				Console.WriteLine("La suma de diagonal 1: {0}", diag1);
				Console.WriteLine("La suma de diagonal 2: {0}", diag2);
				int difference = diag1 - diag2;
				Console.WriteLine("La diferencia es de {0}", difference);

			}

			public static void matrixListsSublist()
			{
				// Part 1: add rows and columns to the List.
				List<List<int>> list = new List<List<int>>();
				var rand = new Random();
				for (int i = 0; i < 3; i++)
				{
					// Put some integers in the inner lists.
					List<int> sublist = new List<int>();
					int top = rand.Next(1, 4);
					for (int v = 0; v < top; v++)
					{
						sublist.Add(rand.Next(1, 5));
					}
					// Add the sublist to the top-level List.
					list.Add(sublist);
				}

				// Display the List.
				// Part 2: loop over and display everything in the List.
				Console.WriteLine("Elements:");
				foreach (var sublist in list)
				{
					foreach (var value in sublist)
					{
						Console.Write(value);
						Console.Write(' ');
					}
					Console.WriteLine();
				}
				// Part 3: display element.
				Console.WriteLine("Element at 1, 0:");
				Console.WriteLine(list[1][0]);
				// Part 4: display total count.
				int count = 0;
				foreach (var sublist in list)
				{
					count += sublist.Count;
				}
				Console.WriteLine("Count:");
				Console.WriteLine(count);

			}

			public static int diagonalDifferencePro(List<List<int>> arr)
			{

				int diag1 = (arr[0][0]) + (arr[1][1]) + (arr[2][2]);
				int diag2 = (arr[0][2]) + (arr[1][1]) + (arr[2][0]);
				int solv = diag2 - diag1;
				Console.WriteLine("La diferencia pro de listas en lista diagonal es: {0}", solv);
				return solv;


			}

			public static List<int> countingSort(List<int> arr)
			{
				//Contar la cantidad de veces que un valor se repite en la lista.
				//Se hace una lista igual pero con ceros, en este caso 100 espacios
				List<int> freqList = new List<int>(new int[100]);
				foreach (int x in arr)
				{
					freqList[x] = freqList[x] + 1;
				}
				//Imprimir
				Console.WriteLine("Repeticion de un valor en la lista:");
				foreach (int i in freqList)
				{
					Console.Write(i + " "); ;
				}
				Console.WriteLine("\n");
				return freqList;

			}

			public static void flippingTheMatrix()
			{
				int[,] matriz = new int[4, 4];
				matriz[0, 0] = 112;
				matriz[0, 1] = 42;
				matriz[0, 2] = 83;
				matriz[0, 3] = 119;
				matriz[1, 0] = 56;
				matriz[1, 1] = 125;
				matriz[1, 2] = 56;
				matriz[1, 3] = 49;
				matriz[2, 0] = 15;
				matriz[2, 1] = 78;
				matriz[2, 2] = 101;
				matriz[2, 3] = 43;
				matriz[3, 0] = 62;
				matriz[3, 1] = 98;
				matriz[3, 2] = 114;
				matriz[3, 3] = 108;

				//imprimiendo Matriz Inicial
				Console.Write("\nMatriz Inicial\n");
				for (int q = 0; q < 4; q++)
				{
					for (int m = 0; m < 4; m++)
					{
						Console.Write(matriz[q, m] + " ");
					}
					Console.Write("\n");

				}
				//----------------

				//Ordenando filas
				List<int> ordenando = new List<int>();
				for (int i = 0; i < 4; i++)
				{
					for (int k = 0; k < 4; k++)
					{
						int celda = matriz[i, k];
						ordenando.Add(celda);
					}
					ordenando.Sort();
					ordenando.Reverse();
					for (int o = 0; o < 4; o++)
					{
						matriz[i, o] = ordenando[o];
					}
					ordenando.Clear();
				}

				//imprimiendo
				Console.Write("\nMatriz Con filas ordenadas de mayor a menor\n");
				for (int q = 0; q < 4; q++)
				{
					for (int m = 0; m < 4; m++)
					{
						Console.Write(matriz[q, m] + " ");
					}
					Console.Write("\n");

				}
				//----------------

				//Ordenando Columnas
				for (int y = 0; y < 4; y++)
				{
					for (int x = 0; x < 4; x++)
					{
						int celda = matriz[x, y];
						ordenando.Add(celda);
					}
					ordenando.Sort();
					ordenando.Reverse();
					for (int p = 0; p < 4; p++)
					{
						matriz[p, y] = ordenando[p];
					}
					ordenando.Clear();
				}
				//------------------

				//imprimiendo final
				Console.Write("\nMatriz Final Con columnas ordenadas de mayor a menor\n");
				for (int q = 0; q < 4; q++)
				{
					for (int m = 0; m < 4; m++)
					{
						Console.Write(matriz[q, m] + " ");
					}
					Console.Write("\n");

				}
				//----------------
				Console.WriteLine("La suma del caudrande superior izquierdo es de {0}", matriz[0, 0] + matriz[0, 1]
					+ matriz[1, 0] + matriz[1, 1]);



			}

			public static int flippingMatrix(List<List<int>> matrix)
			{
				//Ordenando Columnas
				List<int> ordenando = new List<int>();
				for (int x = 0; x < 4; x++)
				{
					int celda = matrix[x][2];
					ordenando.Add(celda);
				}
				ordenando.Reverse();
				for (int p = 0; p < 4; p++)
				{
					matrix[p][2] = ordenando[p];
				}
				ordenando.Clear();

				//Ordenando filas
				for (int k = 0; k < 4; k++)
				{
					int celda = matrix[0][k];
					ordenando.Add(celda);
				}
				ordenando.Reverse();
				for (int o = 0; o < 4; o++)
				{
					matrix[0][o] = ordenando[o];
				}
				ordenando.Clear();

				int final = matrix[0][0] + matrix[0][1] + matrix[1][0] + matrix[1][1];

				return final;


			}

			public static void Palindrome()
			{
				string word = "arriba la birra";
				char[] wordToArray = word.ToCharArray();
				char[] newWord = new char[wordToArray.Length];
				string showNew = "";
				int indexLectura = (wordToArray.Length) - 1;
				for (int i = 0; i < wordToArray.Length; i++)
				{
					newWord[i] = wordToArray[indexLectura];
					showNew += newWord[i];
					indexLectura--;
				}
				Console.WriteLine("La palabra {0} leída alrevéz es {1}", word, showNew);
				if (word.Replace(" ", String.Empty) == showNew.Replace(" ", String.Empty))
				{
					Console.WriteLine("Por lo tanto es un Palindromo");
				}
				else
				{
					Console.WriteLine("Por lo que no es un Palindromo");
				}
			}

			public static void CaesarCipher(string inWord, int KeyCrypto)
			{
				char[] Word = inWord.ToCharArray();
				string newString = "";

				Queue<string> Alphabet = new Queue<string>();
				Alphabet.Enqueue("a"); Alphabet.Enqueue("b");
				Alphabet.Enqueue("c"); Alphabet.Enqueue("d");
				Alphabet.Enqueue("e"); Alphabet.Enqueue("f");
				Alphabet.Enqueue("g"); Alphabet.Enqueue("h");
				Alphabet.Enqueue("i"); Alphabet.Enqueue("j");
				Alphabet.Enqueue("k"); Alphabet.Enqueue("l");
				Alphabet.Enqueue("m"); Alphabet.Enqueue("n");
				Alphabet.Enqueue("o"); Alphabet.Enqueue("p");
				Alphabet.Enqueue("q"); Alphabet.Enqueue("r");
				Alphabet.Enqueue("s"); Alphabet.Enqueue("t");
				Alphabet.Enqueue("u"); Alphabet.Enqueue("v");
				Alphabet.Enqueue("w"); Alphabet.Enqueue("x");
				Alphabet.Enqueue("y"); Alphabet.Enqueue("z");

				List<string> AlphabetOriginal = Alphabet.ToList();

				//lectura
				Console.WriteLine("La palabra original es: {0}", inWord);

				//lectura
				Console.WriteLine("Readed of the original alphabet");
				foreach (string item in Alphabet)
				{
					Console.Write(item + " ");
				}

				for (int i = 0; i < KeyCrypto; i++)
				{
					Alphabet.Enqueue(Alphabet.Dequeue());
				}

				//lectura
				Console.WriteLine("\nReaded of the modified alphabet");
				foreach (string item in Alphabet)
				{
					Console.Write(item + " ");
				}

				List<string> Alphabet2 = Alphabet.ToList();

				for (int i = 0; i < Word.Length; i++)
				{
					if (Word[i].ToString() == "-")
					{
						newString += "-";
					}
					else
					{
						newString += Alphabet2[(AlphabetOriginal.BinarySearch(Word[i].ToString().ToLower())) - 1];
					}

				}
				Console.WriteLine("\nEncrytado final: {0}", newString);

				//return newWord;
			}


			//Divide and conquer
			public static int BinarySearchPerform(List<int> list, int value)
			{
				int start = 0;
				int end = list.Count() - 1;

				while (start <= end)
				{
					//se establece la mitad
					int mid = start + (end - start) / 2;

					if (list[mid] == value)
					{
						return mid;
					}

					//si la mitad es mayor que el valor buscado entonces el end es esa mitad menos 1
					if (list[mid] > value)
					{
						end = mid - 1;
					}
					else //si la mitad es menor que el valor buscado entonces el start es esa mitad mas 1
					{
						start = mid + 1;
					}
				}
				//si no eh devuelto la posision en el proceso anterior entonces devuelvo -1(no encontrado)
				return -1;
			}
		}





	}
}
