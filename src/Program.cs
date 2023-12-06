// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
class Program
{
	static string[] FindMyLength(string[] array, int length)
	{
		int count = 0;
		string[] newArray = new string[length];
		for (int i = 0; i < length; i++)
		{
			if (array[i].Length <= 3) // задавать в параметрах метода
			{
				newArray[count] = array[i];
				count++;
			}
		}
		return newArray;
	}



	static void PrintArray(string[] array, int length)
	{
		for (int i = 0; i < length; i++)
		{
			if(i == length - 1) Console.WriteLine(array[i]);
			else Console.Write(array[i] + ", ");
		}
	}

	static int CheckFlags(string[] arguments)
	{
		int flag = 0;
		if (arguments.Length == 1)
		{
			switch (arguments[0])
			{
				case "--help":
				case "-h":  Console.WriteLine("Разрешенные флаги:\n--byhand\t\t- позволяет пользователю ввод массива вручную" +
											"\n--random\t\t- генерирует исходный массив рандомно" +
											"\n--help -h\t\t- справка о разрешённых флагах");
				//flag = 1;
				break;
				case "--byhand": flag = 2;
				break;
				default: Console.WriteLine("Введён некорректный аргумент! Перезапустите программу и попробуйте снова :)");
				break;
			} 
			
		}
		else Console.WriteLine("Используйте только 1 разрешённый аргумент, -h или --help для справки.");
		return flag;
	}
/*
static int Compare(string strA, string strB, StringComparison comparisonType)
Возвращает отрицательное значение, если строка strA меньше строки strB;
положительное значение, если строка strA больше строки strВ;
и нуль, если сравниваемые строки равны. Способ сравнения определяется аргументом comparisonType
*/

	static void EnterByHand()
	{
		int len = 0;
		Console.WriteLine("Введите желаемое количество строк в массиве:\t");
		var stringValue = Console.ReadLine(); // сохраняем в переменную без явного типа, то что введено в консоль
		if ((int.TryParse(stringValue, out len)) && len > 0 && len < 50)
		{
			string[] handArray = new string[len];
			for(int i = 0; i < len; i++)
			{
				Console.Write($"Введите элемент массива под индексом {i}:\t");
				handArray[i] = Console.ReadLine();
			}
			Console.Write("Исходный массив:\t");
			PrintArray(handArray, len);
			//FindMyLength(handArray, len);
		} 
		else
		{
			Console.WriteLine("Используйте целое положительное число");
		}
	}

	static void Main(string[] args)
	{
		if (args.Length > 0) CheckFlags(args);
		string[] originArray = {"Hel", "2", "wor", ":-)"}; //“Russia”, “Denmark”, “Kazan” “1234”, “1567”, “-2”, “computer science”
		string[] myArray;
		if (CheckFlags(args) == 0) myArray = FindMyLength(originArray, originArray.Length);
		if (CheckFlags(args) == 2) myArray = EnterByHand();
		PrintArray(myArray, myArray.Length);
	}

}