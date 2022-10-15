
/*Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
ввод элеменетов через консоль (через запятую. использовать метод string.Split())*/


Console.WriteLine("Введите числа через запятую");
string str = Console.ReadLine();
string [] strArray = str.Split(',');
int [] numArray = new int[strArray.Length];

for (int i = 0; i < strArray.Length; i++)
{
  numArray[i] = int.Parse(strArray[i]);
}
Console.WriteLine("итоговый массив");

for (int i = 0; i < numArray.Length; i++)
{
if(i < numArray.Length - 1)
  Console.Write($"{numArray[i]}, ");
else
  Console.Write($"{numArray[i]}");
}