//Напишите программу, которая принимает на вход число и выдает сумму цифр в числе.

Console.WriteLine("Введите число : ");
int UserNumber = Convert.ToInt32(Console.ReadLine());


int SumDigit(int number)
{
    int sumdigit = 0;
    while (number > 0)
    {
        sumdigit = sumdigit + number % 10;
        number = number / 10;
    }
    return sumdigit;
}
Console.WriteLine($"Сумма цифр в числе {UserNumber} равна {SumDigit(UserNumber)}");
