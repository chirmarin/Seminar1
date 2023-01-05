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

/*
    Задача 40: Напишите программу, которая принимает на
    вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
    Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.
*/
/*
using static Common.Helpers;

int a = InputInt("Введите сторону A = ");
int b = InputInt("Введите сторону B = ");
int c = InputInt("Введите сторону C = ");
bool res = isTriangle(a,b,c);
Print(res);

int InputInt(string textConsole){
    Console.Write(textConsole);
    bool isInt = int.TryParse(Console.ReadLine(), out int number);
    if (isInt && number > 0){
        return number;
    }
    else{
        Console.WriteLine("Неверный ввод!");
        return InputInt(textConsole);
    }
}

bool isTriangle(int a, int b, int c){    
    return (a<(b+c) && b<(a+c) && c<(a+b));
}
*/

/*
    Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное. 
    45 -> 101101
    3 -> 11
    2 -> 10
*/
/*
using static Common.Helpers;

int number = InputIntNegativeAndPositive("Введите целое число: ");
Print($"Исходное число = {number}");

int[] result = TenToBin(number);
Print("Итоговое число:");
PrintArray(result);
Console.WriteLine();

Console.WriteLine($"Второй способ. Исходное = {number}, Итоговое = {GetToBin(number)}");

int[] TenToBin(int num){
    int numRange = 0;
    int numTemp = num;
    while(numTemp > 0){//разряды
        numTemp /= 2;
        numRange++;
    }
    int length = numRange;
    int[] arr = new int[length];
    for(int i = length - 1; i >= 0; i--){
        arr[i] = num % 2;
        num = num / 2;
    }  
    return arr;
}

string GetToBin(int number){
    string binar = string.Empty;
    while(number != 0){
        binar = number % 2 + binar;
        number /= 2;
    }
    return binar;
}
*/

// EXCEPTIONS
/*
using static Common.Helpers;
int number;
try{
    number = InputIntNumberWithException("Введите целое число: ");
}
catch(ArgumentException ex){
    Console.WriteLine(ex.Message);
    return;
}
int aaa = number + 1;//available here, not init in try-catch
*/

/*
    Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. 
    Первые два числа Фибоначчи: 0 и 1.
    Если N = 5 -> 0 1 1 2 3 
    Если N = 3 -> 0 1 1
    Если N = 7 -> 0 1 1 2 3 5 8
*/
/*
using static Common.Helpers;

uint inputNumber = InputIntPositive("Введите целое положительное число: ");
uint[] fib = Fibonacci(inputNumber);
PrintArrayUint(fib);
Console.WriteLine();
Console.WriteLine("Второй способ:");
Fibonacci2(inputNumber);

uint[] Fibonacci(uint userNum){
    uint[] arr = new uint[userNum];    
    if(!(userNum > 1)) return arr;
    arr[0] = 0;
    arr[1] = 1;
    for(int i = 2; i < userNum; i++){
        arr[i] = arr[i-1] + arr[i-2];
    }
    return arr;
}

void Fibonacci2(uint number){
    int a = 0;
    int b = 1;
    if(number == 1) Console.Write($"{a} ");
    else{
        int temp = 0;
        Console.Write($"{a} ");
        Console.Write($"{b} ");
        for(int i = 2; i < number; i++){
            temp = a;
            a = b;
            b = b + temp;
            Console.Write($"{b} ");
        }
    }
}
*/
/*
Задача 45: Напишите программу, которая будет создавать копию заданного массива 
с помощью поэлементного копирования.
*/
/*
using static Common.Helpers;

int minNumber = 1;
int maxNumber = 11;
int length = 5;
int[] userArray = GenerateArrayInt(minNumber, maxNumber, length);
Console.WriteLine("Сгенерированный массив данных:");
PrintArrayInt(userArray);
Console.WriteLine();
Console.WriteLine("Скопированный массив данных:");
int[] resultArray = CopyArr(userArray);
PrintArrayInt(resultArray);

int[] CopyArr(int[] tempArray){
    int[] copyArr = new int[tempArray.Length];
    for(int i = 0; i < tempArray.Length; i++){
        copyArr[i] = tempArray[i];
    }
    return copyArr;
}
*/