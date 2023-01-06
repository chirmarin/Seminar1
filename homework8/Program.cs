/*
    Задача 54: Задайте двумерный массив. 
    Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
    Например, задан массив:
        1 4 7 2
        5 9 2 3
        8 4 2 4
    В итоге получается вот такой массив:
        7 4 2 1
        9 5 3 2
        8 4 4 2
*/
/*
using static Common.Helpers;

int minNumber = 1;
int maxNumber = 11;
int countRows = 3;
int countColumns = 4;

int[,] randomArray = CreateRandom2DArray(countRows, countColumns, minNumber, maxNumber);
Console.WriteLine("Сгенерированный массив целых чисел:");  
Print2DIntArray(randomArray);

Console.WriteLine("Массив с упорядоченными строками по убыванию::");  
int[,] ArrayWithSortRaw = SortArrayRaws(randomArray);
Print2DIntArray(ArrayWithSortRaw);

//Methods
int[,] SortArrayRaws(int[,] tempArray){
    int[,] editedArray = new int[tempArray.GetLength(0), tempArray.GetLength(1)];
    for (int i = 0; i < tempArray.GetLength(0); i++){
        int temp = 0;
        for (int j = 0; j < tempArray.GetLength(1) - 1; j++){
            if (tempArray[i, j] < tempArray[i, j + 1]){
                temp = tempArray[i, j + 1];
                tempArray[i, j + 1] = tempArray[i, j];
                tempArray[i, j] = temp;
                j = 0;
                j--;
            }
        }
    }
    return tempArray;
}
*/
/*
    Задача 56: Задайте прямоугольный двумерный массив. 
    Напишите программу, которая будет находить строку с наименьшей суммой элементов.
    Например, задан массив:
        1 4 7 2
        5 9 2 3
        8 4 2 4
        5 2 6 7
    Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 
    1 строка
*/
/*
using static Common.Helpers;

int minNumber = 1;
int maxNumber = 11;
int countRows = 4;
int countColumns = 4;

int[,] randomArray = CreateRandom2DArray(countRows, countColumns, minNumber, maxNumber);
Console.WriteLine("Сгенерированный массив целых чисел:");  
Print2DIntArray(randomArray);

int[] sumArrayRaws = SumElementsInRaw(randomArray);
Console.WriteLine("Суммы элементов каждой строки:");  
PrintArrayInt(sumArrayRaws);

//Console.WriteLine($"Наименьшая сумма элементов находится в строкax:");
//Print2DIntArray(randomArray);

//Methods
int SumElementsInRaw(int[] tempArray){
    int[] sumRaw = new int[tempArray.GetLength(0)];
    for (int i = 0; i < tempArray.GetLength(0); i++){
        sumRaw = sumRaw + tempArray[stringIndex, i];
    }
    return sumRaw;
}

/*
int MinSumElementsInRaw(int[,] tempArray){
    int length = tempArray.GetLength(0);
    int minIndex = 0;
    for (int i = 0; i < length; i++){
        if (SumElementsInRaw(tempArray, i) < SumElementsInRaw(tempArray, minIndex)){
            minIndex = i;
        }
    }
    return minIndex + 1;
}*/


/*
    Задача 58: Задайте две матрицы. 
    Напишите программу, которая будет находить произведение двух матриц.
    Например, даны 2 матрицы:
        2 4 | 3 4
        3 2 | 3 3
    Результирующая матрица будет:
        18 20
        15 18
*/

using static Common.Helpers;
/*
int minNumber = 1;
int maxNumber = 11;
int countRows = 2;
int countColumns = 2;

int[,] firstRandomArray = CreateRandom2DArray(countRows, countColumns, minNumber, maxNumber);
Console.WriteLine("Первый сгенерированный массив целых чисел:");  
Print2DIntArray(firstRandomArray);

int[,] secondRandomArray = CreateRandom2DArray(countRows, countColumns, minNumber, maxNumber);
Console.WriteLine("Второй сгенерированный массив целых чисел:");  
Print2DIntArray(secondRandomArray);
*/
int[,] firstRandomArray = new int[2,2];
firstRandomArray[0,0] = 2;
firstRandomArray[0,1] = 4;
firstRandomArray[1,0] = 3;
firstRandomArray[1,1] = 2;
Print2DIntArray(firstRandomArray);
Console.WriteLine();

int[,] secondRandomArray = new int[2,2];
secondRandomArray[0,0] = 3;
secondRandomArray[0,1] = 4;
secondRandomArray[1,0] = 3;
secondRandomArray[1,1] = 3;
Print2DIntArray(secondRandomArray);
Console.WriteLine();

int[,] resultArray = CompositionOf2Matrix(firstRandomArray, secondRandomArray);
/*Console.WriteLine("Результат произведения 2 матриц:");
Print2DIntArray(resultArray);
*/

//Methods

//Произведение прямоугольных матриц есть прямоугольная матрица, число строк которой равно числу строк первого множителя, 
//а число столбцов — числу столбцов второго множителя 
int[,] CompositionOf2Matrix (int[,] firstMatrix, int[,] secondMatrix){
    int[,] compArray = new int[firstMatrix.GetLength(0), secondMatrix.GetLength(1)];    
    for (int i = 0; i < firstMatrix.GetLength(0); i++){
        for (int j = 0; j < secondMatrix.GetLength(1); j++){
                compArray[i, j] = compArray[i, j] + firstMatrix[i, j] * secondMatrix[i, j];
                Console.WriteLine(compArray[i, j]);
            }
        }
    return compArray;
}

/*
    Задача 60. Cформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
    Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
    Массив размером 2 x 2 x 2
        66(0,0,0) 25(0,1,0)
        34(1,0,0) 41(1,1,0)
        27(0,0,1) 90(0,1,1)
        26(1,0,1) 55(1,1,1)
*/

/*
    Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
    Например, на выходе получается вот такой массив:
        01 02 03 04
        12 13 14 05
        11 16 15 06
        10 09 08 07
*/
