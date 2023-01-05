namespace Common;
public static class Helpers
{
    public static int[] CreateRandomArray(){
        Random random = new Random();
        int[] array = new int[10];
        for (int i = 0; i < array.Length; i++){
            array[i] = random.Next(-10, 11);
        }
        return array;
    }

    public static void PrintArrayUint(uint[] array){
        for (int i = 0; i < array.Length; i++){
            Console.Write(array[i]);
            Console.Write(" ");
        }
    }
    public static void PrintArrayInt(int[] array){
        for (int i = 0; i < array.Length; i++){
            Console.Write(array[i]);
            Console.Write(" ");
        }
    }

    public static void Print(object text){
        Console.WriteLine(text);
    }

    public static int InputIntNegativeAndPositive(string textConsole){
    Console.Write(textConsole);
    bool isInt = int.TryParse(Console.ReadLine(), out int number);
    if (isInt){
        return number;
    }
    else{
        Console.WriteLine("Неверный ввод!");
        return InputIntNegativeAndPositive(textConsole);
    }
    }
    public static uint InputIntPositive(string textConsole){
    Console.Write(textConsole);
    bool isUInt = uint.TryParse(Console.ReadLine(), out uint number);
    if (isUInt /*&& number > 0*/){
        return number;
    }
    else{
        Console.WriteLine("Неверный ввод!");
        return InputIntPositive(textConsole);
    }
    }

    public static int InputIntNumberWithException(string textConsole){
        Console.Write(textConsole);
        bool isParsed = int.TryParse(Console.ReadLine(), out int number);
        if(isParsed) return number;
        else throw new ArgumentException("Неверный ввод!");
    }
    public static int[] GenerateArrayInt(int min, int max, int length){
    Random random = new Random();
    int[] array = new int[length];

    for(int i = 0; i < array.Length; i++){
        array[i] = random.Next(min, max + 1);
    }
    return array;
    }
}
