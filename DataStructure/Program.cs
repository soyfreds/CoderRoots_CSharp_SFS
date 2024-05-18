using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace DataStructure
{
	class Program
	{
		static void Main(string[] args)
		{
			// QUEUE DATA STRUCTURE
			Console.WriteLine("------QUEUE DATA STRUCTURE (FIFO)-----");
			DataStructureTypes.Queue();
			Console.WriteLine("-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-\n");
			//--------------------

			// STACK DATA STRUCTURE
			Console.WriteLine("------STACK DATA STRUCTURE (LIFO)-----");
			DataStructureTypes.Stack();
			Console.WriteLine("-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-\n");
			//--------------------

			// LIST DATA STRUCTURE
			Console.WriteLine("------LIST DATA STRUCTURE-----");
			DataStructureTypes.List();
			Console.WriteLine("-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-\n");
			//--------------------

			// HASHSET DATA STRUCTURE
			Console.WriteLine("------HASHSET DATA STRUCTURE-----");
			DataStructureTypes.HashSet();
			Console.WriteLine("-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-\n");
			//--------------------

			// HASHTABLE DATA STRUCTURE
			Console.WriteLine("------HASHTABLE DATA STRUCTURE-----");
			DataStructureTypes.HashTable();
			Console.WriteLine("-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-\n");
			//--------------------

			// DICTIONARY DATA STRUCTURE
			Console.WriteLine("------DICTIONARY DATA STRUCTURE-----");
			DataStructureTypes.dictionary();
			Console.WriteLine("-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-\n");
			//--------------------

			// ARRAYLIST DATA STRUCTURE
			Console.WriteLine("------ARRAYLIST DATA STRUCTURE-----");
			DataStructureTypes.arrayList();
			Console.WriteLine("-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-\n");
			//--------------------
		}
	}

	class DataStructureTypes
	{
		public static void Queue()
		{
			Queue<int> queue = new Queue<int>();
			queue.Enqueue(1);
			queue.Enqueue(2);
			queue.Enqueue(3);
			queue.Enqueue(4);
			queue.Enqueue(5);
			Console.WriteLine("-> La cantidad de de datos en cola son {0} ", queue.Count());
			Console.WriteLine("-> El último sin sacarlo de la cola {0} ", queue.Peek());
			Console.WriteLine("-> Contiene el número 5? {0} ", queue.Contains(5));
			Console.WriteLine("Impresion de los valores en cola:", queue.Contains(5));
			foreach (int item in queue)
			{
				Console.WriteLine("-> valor {0} de la cola.", item);
			}
			Console.WriteLine("-> Atendiendo de la cola y sacando a {0} ", queue.Dequeue());

			Console.WriteLine("Impresion de los valores en cola luego de atender al primero que entró:");
			foreach (int item in queue)
			{
				Console.WriteLine("-> valor {0} de la cola.", item);
			}



		}

		public static void Stack()
		{
			Stack<int> pila = new Stack<int>();
			pila.Push(45);
			pila.Push(55);
			pila.Push(65);
			pila.Push(75);
			pila.Push(85);
			Console.WriteLine("Esta pila contiene {0} items.", pila.Count());
			Console.WriteLine("Contiene esta pila el item 45? {0}", pila.Contains(45));
			Console.WriteLine("Cual es el último agregado a la pila? - {0}", pila.Peek());
			Console.WriteLine("Imprimir todos los datos de la pila:");
			foreach (int item in pila)
			{
				Console.WriteLine("-> Item {0}", item);
			}
			Console.WriteLine("Atendemos a último de la pila? - {0}", pila.Pop());
			Console.WriteLine("Imprimir todos los datos de la pila sin el último que atendimos:");
			foreach (int item in pila)
			{
				Console.WriteLine("-> Item {0}", item);
			}

		}

		public static void List()
		{
			List<string> list = new List<string>();
			list.Add("A");
			list.Add("I");
			list.Add("C");
			list.Add("D");
			List<string> list2 = new List<string>();
			list.Add("E");
			list.Add("F");
			list.Add("Esteban");
			list.Add("H");
			list.Add("B");

			//Contar cantidad de items
			Console.WriteLine("* Ahorita la lista 1 contiene {0} items", list.Count());

			//Añadir lista en otra lista
			list.AddRange(list2); //Añade una lista al final de otra AddRange()

			//Impresion de toda la lista
			Console.WriteLine("* Impresion de todos los item de la lista 1 luego de agregarle la lista 2:");
			foreach (string item in list)
			{
				Console.WriteLine("-> {0}", item);
			}

			//Buscar un dato específico find() -- usando también Contains()
			Console.WriteLine("* Buscando el primer item que contenga una 'E' con Find(): => {0}", list.Find(x => x.Contains("E")));

			//Buscar la posision o index de un dato específico BinarySearch()
			Console.WriteLine("* Buscando con BinarySearch la posision del item 'A': => {0}", list.BinarySearch("A"));

			//Buscar la posision o index de un dato específico BinarySearch()
			//y lo uso para cambiar el dato en ese index devuelto.
			int b2 = list.BinarySearch("H");
			Console.WriteLine("* Inserto una lista completa en un index específico con InsertRange()");
			list.InsertRange(b2, list2);

			//Eliminar un item por su valor
			Console.WriteLine("* Borro el item 'B' CON list.Remove('B')");
			list.Remove("B");

			//Eliminar un item por su index
			Console.WriteLine("* Borro el item que esté en la posicion 0 (osea la A) CON list.RemoveAt(0)");
			list.RemoveAt(0);

			//Ordenar
			Console.WriteLine("* Ordenamos toda la lista y volvemos a imprimir con todos los cambios anteriores:");
			list.Sort();
			foreach (string item in list)
			{
				Console.WriteLine("-> {0}", item);
			}

			//Buscar la posision o index de un dato específico BinarySearch()
			//y lo uso para cambiar el dato en ese index devuelto.
			//NOTA: NO borra el dato que tenía, sino que mueve la lista hacia el frente.
			Console.WriteLine("* Inserto una 'Z' donde hay una 'I' y la palabra 'REMPLAZO' en el index de la 'D' - con la función Insert(INDEX,VALUE)");
			int b1 = list.BinarySearch("I");
			int b3 = list.BinarySearch("D");
			list.Insert(b1, "Z");
			list.Insert(b3, "REMPLAZO");
			foreach (string item in list)
			{
				Console.WriteLine("-> {0}", item);
			}

		}

		public static void HashSet()
		{
			//HashSet no acepta datos duplicados de los siguientes si uno está repetido no lo agrega
			HashSet<int> hashset = new HashSet<int>();
			hashset.Add(200);
			hashset.Add(800);
			hashset.Add(200);
			hashset.Add(900);
			hashset.Add(7500);
			hashset.Add(540);
			Console.WriteLine("Imprimimos los item en la hashset:");
			foreach (int item in hashset)
			{
				Console.WriteLine("--> {0}", item);
			}

			//Borramos el item:
			hashset.Remove(900);
			//Borramos otro item por predicado, esto es útil con objetos,
			//si nesecitamos remover por alguno de los atributos del mismo
			hashset.RemoveWhere(x => x.ToString() == "540");
			Console.WriteLine("Imprimimos los item en la hashset luego de borrar el 900 y 540:");
			foreach (int item in hashset)
			{
				Console.WriteLine("--> {0}", item);
			}
		}

		public static void HashTable()
		{
			Hashtable hashtable = new Hashtable();
			hashtable.Add(1, "Frederick");
			hashtable.Add(2, "Johan");
			hashtable.Add(3, "Emily");
			hashtable.Add(4, "Tita");
			hashtable.Add(5, "Federico");
			hashtable.Add(6, "Manfred");
			Console.WriteLine("Intems dentro del hashtable:");
			foreach (DictionaryEntry item in hashtable)
			{
				Console.WriteLine("--> Key:{0} - Value:{1}", item.Key, item.Value);
			}
			//Actualizar un item
			hashtable[6] = "Juan";
			//Buscar Items
			Console.WriteLine("Se actualizó el campo de Manfred -> {0}", hashtable[6]);
			Console.WriteLine("Existe un Item con esta key=4?? -> " + hashtable.Contains(4));
			Console.WriteLine("Existe un Item con el valor=Johan?? -> " + hashtable.ContainsValue("Johan"));
			Console.WriteLine("Contiene {0} items", hashtable.Count);
			//Eliminar item
			hashtable.Remove(5);
		}

		public static void dictionary()
		{
			Dictionary<int, string> dictionary = new Dictionary<int, string>();
			dictionary.Add(1, "Joshua");
			dictionary.Add(3, "Steven");
			dictionary.Add(4, "Pedro");
			dictionary.Add(5, "Drake");
			dictionary.Add(2, "Ulises");
			dictionary.Add(6, "Alfred");

			Console.WriteLine("Intems dentro del hashtable:");
			foreach (KeyValuePair<int, string> item in dictionary)
			{
				Console.WriteLine("--> Key:{0} - Value:{1}", item.Key, item.Value);
			}
			//Actualizar un item
			dictionary[6] = "Juan";
			Console.WriteLine("Se actualizó el campo de Alfred -> {0}", dictionary[6]);
			//Buscar Item
			Console.WriteLine("Existe un Item con esta key=4?? -> " + dictionary.ContainsKey(5));
			Console.WriteLine("Existe un Item con el valor=Johan?? -> " + dictionary.ContainsValue("Johan"));
			//Eliminar Item
			dictionary.Remove(5);
		}

		public static void arrayList()
		{
			//El arrayliste se llena de cualquier cosa
			var arr = new ArrayList();
			arr.Add(1);
			arr.Add(2);
			arr.Add("tijuana");
			arr.Add(4);
			arr.Add("maracuyá");
			arr.Add(2.33);
			arr.Add(true);
			Console.WriteLine("Imprimo todo el ArrayList:");
			for (int i = 0; i < arr.Count; i++)
			{
				Console.WriteLine("--> {0}", arr[i]);
			}
			//Editar
			arr[3] = "cambioo1";
			arr[arr.IndexOf(true)] = "tttttt";
			// Buscar
			Console.WriteLine("El index de 'tttttt' es {0}.", arr.IndexOf("tttttt"));
			Console.WriteLine("El valor del index 5 es: {0}.", arr[5]);
			Console.WriteLine("Imprimo de nuevo todo el ArrayList con cambios:");
			for (int i = 0; i < arr.Count; i++)
			{
				Console.WriteLine("--> {0}", arr[i].ToString());
			}

		}
	}

}
