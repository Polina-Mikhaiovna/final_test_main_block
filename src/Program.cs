// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

int count = 0;
string[] originArray = {"Hel", "2", "wor", ":-)"}; //“Russia”, “Denmark”, “Kazan” “1234”, “1567”, “-2”, “computer science”
string[] myArray = FindMyLength(originArray, originArray.Length);

PrintArray(myArray, count);

string[] FindMyLength(string[] array, int length)
{
	string[] newArray = new string[length];
	for (int i = 0; i < length; i++)
	{
		if (array[i].Length <= 3) // задавать в параметрах метода
		{
			newArray[count] = originArray[i];
			count++;
		}
	}
	return newArray;
}



void PrintArray(string[] array, int length)
{
	for (int i = 0; i < length; i++)
	{
		Console.Write(array[i] + " ");
	}
}
// Console.WriteLine(originArray);
// Console.WriteLine(count);
// Console.WriteLine(originArray[2]);