// Напишите программу, которая задает массив из 8 элементов и выводит их на экран.
int[] array = new int[8];

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(10);
        Console.Write($" {arr[i]} ");

    }
}

PrintArray(array);