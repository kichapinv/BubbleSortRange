using System;

internal class Program
{
    public static Random random = new Random();

    private static void Main(string[] args)
    {
        int[] firstArray = new int[] { 4, 3, 2, 0, 1, 5, 7, 6, 9, 8 };
        int[] secondArray = new int[random.Next(100)];
        

        Console.WriteLine("Lets sort a range of array by bubblesort. We will make two random arrays and sort them.");
        
        Console.Write("First array: ");
        WriteAnArray(firstArray);
        Console.WriteLine("Insert first and second border");
        var firstBorder = Console.ReadKey(true).Key;
        var secondBorder = Console.ReadKey(true).Key;
        WriteAnArray(BubbleSortRange(firstArray, 2, 6));
        
        

        WriteAnArray(BubbleSortRange(secondArray, 1, 2));
    }

    public static int[] MakeRandomArray()
    {
        Console.Write("Insert the length of array: ");
        char lengthOfArray = Console.ReadKey(true).KeyChar;
        int[] array = new int[lengthOfArray];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(100);
        }
        return array;
    }

    public static int[] BubbleSortRange(int[] array, int left, int right)
    {
        for (int i = 0; i < array.Length; i++)
            for (int j = left; j < right; j++)
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