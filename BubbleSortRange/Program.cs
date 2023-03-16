internal class Program
{
    private static void Main(string[] args)
    {
        var random = new Random();
        int[] firstArray = new int[] { 4, 3, 2, 0, 1, 5, 7, 6, 9, 8 };

        Console.WriteLine("Lets sort a range of array by bubblesort");
        Console.Write("First array: ");
        WriteAnArray(firstArray);
        WriteAnArray(BubbleSortRange(firstArray, 2, 6));
        
        int[] newArray = new int[random.Next(100)];
        for (int i = 0; i < newArray.Length; i++)
        {
            newArray[i] = random.Next(100);
        }

        WriteAnArray(BubbleSortRange(newArray, 1, 2));
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
        Console.Write("Array length: ");
        Console.WriteLine(array.Length);
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
    }
}