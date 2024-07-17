using System;

public static class Functions
{
    public static void PrintNumber(int m, int n)
    {
        if(m < n - 1)
            (m, n) = (n, m);
        if(m < n) return;
        PrintNumber(m - 1, n);
        System.Console.Write(m + " ");
        // System.Console.WriteLine(); 
    }

    public static int ReadInt(string msg)
    {
        System.Console.Write(msg);
        return Convert.ToInt32(Console.ReadLine());
    }

    public static int Acc(int m, int n)
    {
        if(m == 0)
            return n + 1;
        else if (n == 0)
            return Acc(m - 1, 1);
        else
            return Acc(m - 1, Acc(m, n - 1));
    }


    public static int[] GenerateArray()
    {
        Random arraySize = new Random();
        int size = arraySize.Next(1, 20);

        int[] tempArray = new int[size];

        Random rand = new Random();
        for(int i = 0; i < tempArray.Length; i++)
            tempArray[i] = rand.Next(10, 500);

        return tempArray;
    }

    public static void PrintArray(int[] array)
    {
        for(int i = 0; i < array.Length; i++)
            System.Console.Write(array[i] + " ");
        System.Console.WriteLine();
    }

    public static void PrintReversArray(int[] array, int i = 0)
    {
        if(i != array.Length) 
        {
            PrintReversArray(array, i + 1);
            System.Console.Write(array[i] + " ");
        }
    }
}


