/*Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2]
*/
/*
//Основной блок
int[] InitArray = GenerateArray(-10, 10, 10);
PrintArray(InitArray);
int[] EditArray = ReplacePositiveOnNegative(InitArray);
PrintArray(EditArray);

//Методы
int[] GenerateArray(int min, int max, int length){
    Random random = new Random();
    int[] array = new int[length];

    for(int i = 0; i < length; i++){
        array[i] = random.Next(min, max + 1);
    }
    return array;
}

int[] ReplacePositiveOnNegative(int[] array){ 
    int[] arr = new int[array.Length];
    for(int i = 0; i < array.Length; i++){
        arr[i] = -array[i];
    }
    return arr;
}

void PrintArray(int[] array){
    Console.WriteLine(string.Join(", ", array));
}
*/

/*Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет -3; массив [6, 7, 19, 345, 3] -> да
*/

//Основной блок
Console.WriteLine("Введите целое число:");
bool isInt = int.TryParse(Console.ReadLine(), out int number);
if(!isInt){
    Console.WriteLine("Неверное число");
    return;
}

int[] array = GenerateArray(-50, 50, 15);
PrintArray(array);

if(isExist(array, number)){
    Console.WriteLine("Число содержится в массиве");
}
else{
    Console.WriteLine("Число не содержится в массиве");
}

//Методы
bool isExist(int[] array, int numToFind){
    bool result = false;
    for(int i = 0; i < array.Length; i++){
        if(array[i] == numToFind){
            result = true;
            break;
        }
    }
    return result;
}

int[] GenerateArray(int min, int max, int length){
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

/*Задача 35: Задайте одномерный массив из 123 случайных чисел.
Найдите количество элементов массива, значения которых лежат в
отрезке [10,99].
Пример для массива из 5, а не 123 элементов. В своём решении сделайте для
123
[5, 18, 123, 6, 2] -> 1 [1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5 */



/*Задача 37: Найдите произведение пар чисел в одномерном массиве.
Парой считаем первый и последний элемент, второй и предпоследний
и т.д. Результат запишите в новом массиве. [1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21*/

