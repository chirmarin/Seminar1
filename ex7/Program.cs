/*5 seminar*/

/*
    Задача 31. Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]
    Найдите сумму отрицательных и положительных элементов массива. Например, в массиве:
    [3, 9, -8, 1, 0, -7, 2, -1, 8, -3, -1, 6]
    сумма положительных чисел равна 29, сумма отрицательных равна -20
*/

/*
int[] array = GenerateArray(-9, 9, 12);
PrintArray(array);
int sumPositiveNumbers = GetSumPositiveNumbersInArray(array);
int sumNegativeNumbers = GetSumNegativeNumbersInArray(array);
Console.WriteLine($"Сумма положительных = {sumPositiveNumbers}, сумма отрицательных = {sumNegativeNumbers}");

//Methods
int[] GenerateArray(int min, int max, int length){
    Random random = new Random();
    int[] array = new int[length];

    for(var i = 0; i < array.Length; i++){
        array[i] = random.Next(min, max + 1);
    }
    return array;
}

int GetSumPositiveNumbersInArray(int[] array){
    int sumPositiveNumbers = 0;
    for(var i = 0; i < array.Length; i++){
        if(array[i] >= 0){
            sumPositiveNumbers+= array[i];
        }
    }
    return sumPositiveNumbers;
}

int GetSumNegativeNumbersInArray(int[] array){
    int sumNegativeNumbers = 0;
    for(var i = 0; i < array.Length; i++){
        if(array[i] < 0){
            sumNegativeNumbers+= array[i];
        }
    }
    return sumNegativeNumbers;
}

void PrintArray(int[] array){
    //Console.WriteLine(@"[{0}]", string.Join(", ", array));
    Console.WriteLine($"[{string.Join(", ", array)}]");
}
*/

/*
    Напишите программу, которая выполняет замену элементов массива:
    положительные элементы замените на соответствующие отрицательные и наоборот.
    [-4, -8, 8, 2] -> [4, 8, -8, -2]
*/
/*
int[] initArray = GenerateArray(-10, 10, 5);
PrintArray(initArray);
int[] outArray = PosNegReplace(initArray);
PrintArray(outArray);

//Methods
int[] GenerateArray(int min, int max, int length){
    Random random = new Random();
    int[] array = new int[length];

    for(var i = 0; i < array.Length; i++){
        array[i] = random.Next(min, max + 1);
    }
    return array;
}

void PrintArray(int[] array){
    //Console.WriteLine(@"[{0}]", string.Join(", ", array));
    Console.WriteLine($"[{string.Join(", ", array)}]");
}

int[] PosNegReplace(int[] array){
    int[] arr = new int[array.Length]; // не трогаем исходный массив
    for(int i = 0; i < array.Length; i++){
        arr[i] = -array[i];
    }
    return arr;
}
*/

/*
    Задайте массив. Напишите программу, которая определяет присутствует ли
    заданное число в массиве.
    4; массив [6, 7, 19, 345, 3] -> нет
    3; массив [6, 7, 19, 345, 3] -> да

    int[] a = new int[];
    int[] a = new int[4]{1,2,34,5};
    a.Contains(12);//bool
*/
/*
Console.WriteLine("Введите целое число: ");
bool isInteger = int.TryParse(Console.ReadLine(), out int number);
if(!isInteger){
    Console.WriteLine("Неверный ввод!");
    return;    
}

int[] initArray = GenerateArray(-100, 100, 100);
PrintArray(initArray);
if(isExist(initArray, number)){
    Console.WriteLine("Число есть в массиве");
}
else{
    Console.WriteLine("Числа нет в массиве");
}

//Methods
int[] GenerateArray(int min, int max, int length){
    Random random = new Random();
    int[] array = new int[length];

    for(var i = 0; i < array.Length; i++){
        array[i] = random.Next(min, max + 1);
    }
    return array;
}

bool isExist(int[] array, int numToFind){
    bool result = false;
    for(var i = 0; i < array.Length; i++){
        if(array[i] == numToFind){
            result = true;
            break; 
        }
    }
    return result;
}

void PrintArray(int[] array){
    //Console.WriteLine(@"[{0}]", string.Join(", ", array));
    Console.WriteLine($"[{string.Join(", ", array)}]");
}
*/

/*
    Задайте одномерный массив из 123 случайных чисел.
    Найдите количество элементов массива, значения которых лежат в отрезке [10, 99]

    Пример для массива из 5, а не из 123 элементов. 
    В своем решении сделайте для 123
    [5, 18, 123, 6, 2] -> 1
    [1, 2, 3, 6, 2] -> 0
    [10, 11, 12, 13, 14 -> 5
*/
/*
int[] initArray = GenerateArray(-100, 100, 10);
PrintArray(initArray);
int min = 10;
int max = 99;
Console.WriteLine($"Количество элементов на отрезке от {min} до {max} = {findElementsinSegment(initArray, min, max)}");

//Methods
int[] GenerateArray(int min, int max, int length){
    Random random = new Random();
    int[] array = new int[length];

    for(var i = 0; i < array.Length; i++){
        array[i] = random.Next(min, max + 1);
    }
    return array;
}

int findElementsinSegment(int[] array, int min, int max){
    int count = 0;
    for(var i = 0; i < array.Length; i++){
        if(array[i] >= min && array[i] <= max){
            count++;
        }
    }
    return count;
}

void PrintArray(int[] array){
    //Console.WriteLine(@"[{0}]", string.Join(", ", array));
    Console.WriteLine($"[{string.Join(", ", array)}]");
}
*/

/*
    Найдите произведение пар чисел в одномерном массиве.
    Парой считаем первый и последний элемент, второй и предпоследний и т.д.
    Результат запишите в новом массиве.
    [1 2 3 4 5] -> 5 8 3
    [6 7 3 6] -> 36 21
*/
/*
int[] initArray = GenerateArray(-10, 10, 10);
PrintArray(initArray);
int[] prodArray = SymmElementsProducts(initArray);
PrintArray(prodArray);

//Methods
int[] GenerateArray(int min, int max, int length){
    Random random = new Random();
    int[] array = new int[length];

    for(int i = 0; i < array.Length; i++){
        array[i] = random.Next(min, max + 1);
    }
    return array;
}

int SymmElementsProducts(int[] arr){
    int[] arr2 = new int[arr.Length/2 + arr.Length%2];
    int i = 0;
    for(i = 0; i < arr2.Length - 1; i++){
        arr2[i] = arr[i] * arr[arr.Length - i -1];            
    }
    if(i != arr2.Length - i - 1){
        arr2[i] = arr[i];
    }
    return arr2;
}

void PrintArray(int[] array){
    //Console.WriteLine(@"[{0}]", string.Join(", ", array));
    Console.WriteLine($"[{string.Join(", ", array)}]");
}
*/

/*6 seminar*/
/*7 seminar*/
//using static Common.Helper.cs;
/*
    Задача 46. Задайте двумерный массив размером m*n, 
    заполненный случайными целыми числами.
    m = 3, n = 4
    1 4 8 19
    5 -2 33 -2
    77 3 8 1
*/
/*
int[,] array = CreateRandom2DArray(3,4);
Print2DArray(array);

int[,] CreateRandom2DArray(int countOfRows, int countOfColumns){
    Random random = new Random();
    int[,] array = new int[countOfRows, countOfColumns];
    for(int i = 0; i < array.GetLength(0); i++){
        for(int j = 0; j < array.GetLength(1); j++){
            array[i, j] = random.Next(-10, 11);
        }
    }
    return array;
}

void Print2DArray(int[,] array){
    for(int i = 0; i < array.GetLength(0); i++){
        for(int j = 0; j < array.GetLength(1); j++){
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}
*/

//(int,int) coordinates = GetSomething();
//Console.WriteLine(coordinates.Item1);
//Console.WriteLine(coordinates.Item2);

//Methods
/*int[] GetSomething(){
    int a = 5;
    int b = 5;

    int[] array = new int[2];
    array[0] = a;
    array[1] = b;
    return array;
}

(int,int) GetSomething(){ //аналогично списку в return
    int a = 5;
    int b = 15;
    return (a,b);
}
*/

/*
int [] array = new int[4]{1,2,3,4};
string str = string.Join(",", array);
Console.WriteLine(str);
string str2 = $"str";
string.Format("Это означает {0} равно {1} ффф {2}", 1, 2, 3); //с нуля
*/

/*
using static Common.Helpers;

int[] array = CreateRandomArray();
PrintArray(array);
/*
int[] CreateRandomArray(){
    Random random = new Random();
    int[] array = new int[10];
    for(int i = 0; i < array.Length; i++){
        array[i] = random.Next(int.MinValue, int.MaxValue);   
    }
    return array;
}

void PrintArray(int[] array){
    for(int i = 0; i < array.Length; i++){
        Console.Write(array[i]);
        Console.Write(" ");
    }
}
*/


// Напишите программу, которая перевернет одномерный массив
// (последний элемент будет на первом месте, а первый на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

/*
using static Common.Helpers;

int[] array = CreateRandomArray();
PrintArray(array);
Console.WriteLine();
int[] reversed = ReverseArray(array);
PrintArray(reversed);

int[] ReverseArray(int[] array){
    int[] reversedArray = new int[array.Length];
    for(int i = 0; i < array.Length; i++){
        reversedArray[i] = array[array.Length - 1 -i ];
    }
    return reversedArray;
}
*/

