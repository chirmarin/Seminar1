/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/

/*
//Основной блок
int minRnd = 100;
int maxRnd = 999;
int lengthForArray = 5;
int[] InitArray = GenerateRndArrayThreeDigits(minRnd, maxRnd, lengthForArray);
PrintArray(InitArray);

int countEvenNumbers = DefiniteEvenNumbers(InitArray);
Console.WriteLine($"В созданном массиве найдено четных чисел => {countEvenNumbers}");

//Методы
int[] GenerateRndArrayThreeDigits(int min, int max, int length) {
    Random random = new Random();
    int[] array = new int[length];
    for(int i = 0; i < length; i++){
        array[i] = random.Next(min, max + 1);
    }
    return array;
}

void PrintArray(int[] array){
    Console.WriteLine(string.Join(", ", array));
}

int DefiniteEvenNumbers(int[] array) {
    int count = 0;
    for (int i = 0; i < array.Length; i++) {
        if (array[i] % 2 == 0) {
            count++;
        }
    }
    return count;
}
*/

/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных индексах.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

/*
//Основной блок
int minRnd = 100;
int maxRnd = 999;
int lengthForArray = 5;
int[] InitArray = GenerateRndArray(minRnd, maxRnd, lengthForArray);
PrintArray(InitArray);

int sumWithUnevenIndexes = DefiniteUnevenIndexes(InitArray);
Console.WriteLine($"Сумма элементов с нечетными индексами (индекс начинается с нуля) => {sumWithUnevenIndexes}");

//Методы
int[] GenerateRndArray(int min, int max, int length) {
    Random random = new Random();
    int[] array = new int[length];
    for(int i = 0; i < length; i++){
        array[i] = random.Next(min, max + 1);
    }
    return array;
}

void PrintArray(int[] array){
    Console.WriteLine(string.Join(", ", array));
}

int DefiniteUnevenIndexes(int[] array) {
    int sum = 0;
    for (int i = 0; i < array.Length; i++) {
        if (i % 2 != 0) {
            sum = sum + array[i];
        }
    }
    return sum;
}
*/

/*
Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива. 
Не использовать готовые методы Min и Max
[3 7 22 2 78] -> 76
*/

/*
//Основной блок
int minRnd = 1;
int maxRnd = 50;
int lengthForArray = 5;
float[] InitArray = GenerateRndArray(minRnd, maxRnd, lengthForArray);
PrintArray(InitArray);

float minElem = FindMinElement(InitArray);
Console.WriteLine($"Значение минимального элемента массива => {minElem}");
float maxElem = FindMaxElement(InitArray);
Console.WriteLine($"Значение максимального элемента массива => {maxElem}");
float deltaMinMaxElem = DeltaMaxMin(minElem, maxElem);
Console.WriteLine($"Разница между максимальным и минимальным элементов массива => {deltaMinMaxElem}");

//Методы
float[] GenerateRndArray(int min, int max, int length){
    Random random = new Random();
    float[] array = new float[length];
    for(int i = 0; i < length; i++){
        array[i] = random.Next(min, max + 1);
    }
    return array;
}

void PrintArray(float[] array){
    Console.WriteLine(string.Join(", ", array));
}

float FindMinElement(float[] array){
    float min = array[0]; 
    for (int i = 1; i < array.Length; i++){
        if (array[i] < min){
            min = array[i];
        }
    }
    return min;
}

float FindMaxElement(float[] array){
    float max = array[0]; 
    for (int i = 1; i < array.Length; i++){
        if (array[i] > max){
            max = array[i];
        }
    }
    return max;
}

float DeltaMaxMin(float min, float max){
    float delta = max - min;
    return delta;
}
*/