// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
int startNumber = 0 - number;

while (startNumber != number + 1)
{
    Console.Write(startNumber);
    startNumber++;
}