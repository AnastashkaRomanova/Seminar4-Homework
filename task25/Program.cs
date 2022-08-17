// Напишите цикл, который принимает на вход два числа (А и В) и возводит А в натуральную степень 

Console.WriteLine("Введите число А: ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());

int numberC = numberA;


for (int i = 1; i < numberB; i++)
{
    numberC = numberC * numberA;
}
Console.WriteLine($" Число {numberA} в степени {numberB} = {numberC}");
