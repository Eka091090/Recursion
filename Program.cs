using System;
class Program
{
    static void Main()
    {
        // Задача № 1
        Console.WriteLine("Задача № 1");
        int a = Functions.ReadInt("Введите число M: ");
        int b = Functions.ReadInt("Введите число N: ");
        Functions.PrintNumber(a, b);
        System.Console.WriteLine("\n");

        // Задача № 2
        System.Console.WriteLine("Задача № 2");
        int c = Functions.ReadInt("Введите число M: ");
        int d = Functions.ReadInt("Введите число N: ");
        Console.Write(Functions.Acc(c, d));
        System.Console.WriteLine("\n");

        // Задача № 3
        System.Console.WriteLine("Задача № 3");
        int[] array = Functions.GenerateArray();
        Functions.PrintArray(array);
        Functions.PrintReversArray(array);
    }
}