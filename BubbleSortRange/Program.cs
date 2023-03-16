using System;

internal class Program
{
    public static Random random = new Random();

    private static void Main(string[] args)
    {
        Console.WriteLine("Lets sort a range of array by bubblesort. We will make two random arrays and sort them.");
        int[] array;
        for (int i = 0; i < 2; i++)
        {
            array = MakeRandomArray();
            WriteAnArray(array);
            WriteAnArray(BubbleSortRange(array, InsertBorders()));
            if (i == 0) Console.WriteLine("Good! Lets try on more time.");
        }  
    }

    public static int[] InsertBorders()
    {
        int[] range = new int[2];
        Console.WriteLine("Make sure that your borders will be less then length of array,\n" +
            "and first border less then second border.");
        Console.Write("Insert first border: ");
        range[0] = int.Parse(Console.ReadLine());
        Console.Write("and second border: ");
        range[1] = int.Parse(Console.ReadLine());
        return range;
    }

    public static int[] MakeRandomArray()
    {
        Console.Write("Insert the length of array: ");
        var lengthOfArray = int.Parse(Console.ReadLine());
        int[] array = new int[lengthOfArray];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(100);
        }
        return array;
    }

    public static int[] BubbleSortRange(int[] array, int[] range)
    {
        for (int i = 0; i < array.Length; i++)
            for (int j = range[0]; j < range[1]; j++)
                if (array[j] > array[j + 1])
                {
                    var t = array[j + 1];
                    array[j + 1] = array[j];
                    array[j] = t;
                }
        return array;
    }

    public static void WriteAnArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
    }
}