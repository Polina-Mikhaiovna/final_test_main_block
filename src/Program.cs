class Program
{
	static int count = 0;
	
	static string[] FindMyLength(string[] array, int length)
	{
		
		string[] newArray = new string[length];
		for (int i = 0; i < length; i++)
		{
			if (array[i].Length <= 3)
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
		if (arguments.Length > 0 && arguments.Length < 2) // заходим в тело условия если получен один флаг
		{
			switch (arguments[0])
			{
				case "--help":
				case "-h":  flag = 10;
				break;
				case "--byhand": flag = 1;
				break;
				default: flag = -1; // невалидный флаг
				break;
			}
			
		}
		else if (arguments.Length > 1) flag = 2; // если флагов больше одного
		else flag = 0; // когда флагов нет
		return flag;
	}

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
		Console.Write(message);
		int len = 0;
		var stringValue = Console.ReadLine(); // сохраняем в переменную без явного типа, то что введено в консоль
		if ((int.TryParse(stringValue, out len)) && len > 0 && len < 50) return len;
		else return 0;

	}

	static void OutArrays(string[] array, int length)
	{
		Console.Write("\nИсходный массив:\t");
		PrintArray(array, array.Length);
		array = FindMyLength(array, array.Length);
		Console.Write("Полученный массив:\t");
		PrintArray(array, count);
	}

	static void Main(string[] args) // инициализирует основные переменные и массив, обрабатывает их в соответствии с аргументами(args[])
	{								// и выводит сообщения об ошибках
		int flag = 0;
		string[] myArray = {"Hello", "2", "world!", ":-)", "1234", "1567", "-2", "computer scienc"};
		flag = CheckFlags(args);

		if (flag == 1) // обнаружен флаг --byhand просим пользователя ввести количество и сами строки и обрабатываем этот массив
		{
			int len = ReadConsole("Введите желаемое количество строк в массиве:\t");
			if (len == 0) Console.WriteLine("[-]Используйте целое положительное число от 1 до 50");
			else
			{
				myArray = EnterByHand(len);
				OutArrays(myArray, myArray.Length);
			}
		}
		else if (flag == 2) Console.WriteLine("[-]Используйте только 1 разрешённый аргумент. Для справки -h или --help.");
		
		else if (flag == -1) Console.WriteLine("[-]Введён некорректный аргумент! Перезапустите программу и попробуйте снова :)");
		
		else if (flag == 10) Console.WriteLine("Разрешенные флаги:\n--byhand\t\t- позволяет пользователю ввод массива вручную" +
											"\n--random\t\t- генерирует исходный массив рандомно" +
											"\n--help -h\t\t- справка о разрешённых флагах");
		
		else OutArrays(myArray, myArray.Length); // ни одного флага не найдено, обрабатываем массив {"Hello", "2", ... }
	}
}