/*Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11
82 -> 10
9012 -> 12*/

/*int number = ReadInt("Введите число: ");
int len = NumberLen(number);
SumNumbers(number, len);*/



Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine ());
int result= number;
int count = 0;

while (number>0)
{
    count += number % 10;
    number = number / 10;
}
Console.WriteLine($"Сумма цифр в числе {result} -> {count}");

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
