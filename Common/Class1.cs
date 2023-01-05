namespace Common;
public static class Helpers
{
    public static int[] CreateRandomArray()
    {
        Random random = new Random();
        int[] array = new int[10];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(-10, 11);
        }
        return array;
    }

    public static void PrintArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i]);
            Console.Write(" ");
        }
    }
}
