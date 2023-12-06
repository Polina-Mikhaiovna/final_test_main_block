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
			else continue;
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
		else Console.WriteLine("Используйте только 1 разрешённый аргумент. Для справки -h или --help.");
		return flag;
	}
/*
static int Compare(string strA, string strB, StringComparison comparisonType)
Возвращает отрицательное значение, если строка strA меньше строки strB;
положительное значение, если строка strA больше строки strВ;
и нуль, если сравниваемые строки равны. Способ сравнения определяется аргументом comparisonType
*/

	static string[] EnterByHand(int len)
	{
		string[] handArray = new string[len];
		Console.WriteLine(handArray[0]);
		for(int i = 0; i < len; i++)
		{
			Console.Write($"Введите элемент массива под индексом {i}:\t");
			handArray[i] = Console.ReadLine();
		}
		Console.Write("Исходный массив:\t");
		return handArray;
	}
	static int ReadConsole()
	{
		int len = 0;
		Console.WriteLine("Введите желаемое количество строк в массиве:\t");
		var stringValue = Console.ReadLine(); // сохраняем в переменную без явного типа, то что введено в консоль
		if ((int.TryParse(stringValue, out len)) && len > 0 && len < 50) return len;
		else 
		{
			Console.WriteLine("Используйте целое положительное число"); 
			return 0;
		}

	}
	static void Main(string[] args)
	{
		if (args.Length > 0) CheckFlags(args);
		string[] originArray = {"Hel", "2", "wor", ":-)"}; //“Russia”, “Denmark”, “Kazan” “1234”, “1567”, “-2”, “computer science”
		int length = originArray.Length;
		string[] myArray = new string[length];
		int flag = CheckFlags(args);
		if (flag == 0) myArray = FindMyLength(originArray, length);
		if (flag == 2)
		{
			length = ReadConsole();
			if (length > 0) myArray = EnterByHand(length);
		}
		PrintArray(myArray, myArray.Length);
	}

}