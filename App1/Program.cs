// See https://aka.ms/new-console-template for more information
Console.Write("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());

int result = number * number;

Console.WriteLine($"Number = {result}");