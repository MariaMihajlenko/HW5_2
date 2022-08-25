//Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0



using System;
class Program
{
    static void Main(string[] args)
    {
        int s = 4;
        int[] a = new int[s];

        int summ = 0; 
        Random random = new Random();
        Console.Write("Исходный массив: ");
        for (int i = 0; i < s; i++)
        {
            Console.Write($"{a[i] = random.Next(-100, 100)}{"  "}");
            if (a[i] % 2 != 0 && a[i] != 0)
                summ += a[i];
        }
        Console.WriteLine("   ");
        Console.WriteLine($"{"Сумма не четных чисел равна :  "}{summ}");
    }

}