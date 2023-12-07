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
		int flag = 0; // значение флага останется 0, если методу Main() не будет передано ни одного
		if (arguments.Length > 0 && arguments.Length < 2) // заходим в тело условия если получен 1 флаг
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

		for(int i = 0; i < len; i++)
		{
			Console.Write($"Введите элемент массива под индексом {i}:\t");
			handArray[i] = Console.ReadLine();
		}

		return handArray;
	}

	static int ReadConsole(string message)
	{
		Console.WriteLine(message);
		int len = 0;
		var stringValue = Console.ReadLine(); // сохраняем в переменную без явного типа, то что введено в консоль
		if ((int.TryParse(stringValue, out len)) && len > 0 && len < 50) return len;
		else return 0;

	}

	static void Main(string[] args)
	{
		int flag = 0;
		string[] myArray = {"Hel", "2", "wor", ":-)"};
		flag = CheckFlags(args); // если есть флаг/-и то отправляем их в метод обработки флагов
		if (flag == 2) // -by hand
		{
			int len = ReadConsole("Введите желаемое количество строк в массиве:\t");
			if (len == 0) Console.WriteLine("Используйте целое положительное число");
			else myArray = EnterByHand(len);

		}
		 //“Russia”, “Denmark”, “Kazan” “1234”, “1567”, “-2”, “computer science”
		// если флаги не получены запускаем программу с уже заданным массивом
		Console.Write($"Исходный массив:\t");
		PrintArray(myArray, myArray.Length);
		myArray = FindMyLength(myArray, myArray.Length);
		Console.Write($"Полученный массив:\t");
		PrintArray(myArray, myArray.Length);
	}

}