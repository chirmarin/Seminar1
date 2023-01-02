/* 
    Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
    m = 3, n = 4
    0,5 7 -2 -0,2
    1 -3,3 8 -9,9
    8 7,8 -7,1 9
*/

/*
double min = 1;
double max = 100;
int countOfRows = 3;
int countOfColumns = 3;

double[,] outputArray = GenerateRandom2DArrayDb(countOfRows, countOfColumns, min, max);
Print2DArray(outputArray);

//Methods
double[,] GenerateRandom2DArrayDb(int m, int n, double min, double max){
    Random random = new Random();
    double[,] tempArray = new double[m, n];
    for (int i = 0; i < tempArray.GetLength(0); i++){
        for (int j = 0; j < tempArray.GetLength(1); j++){
            tempArray[i,j] = Math.Round(random.NextDouble() * (max - min) + min, 1); 
            // random.NextDouble() - возвращает случайное число в диапазоне [0,0; 1,0).
            // https://stackoverflow.com/questions/1064901/random-number-between-2-double-numbers
        }
    }
    return tempArray;
}

void Print2DArray(double[,] tempArray){
    for(int i = 0; i < tempArray.GetLength(0); i++){
        for(int j = 0; j < tempArray.GetLength(1); j++){
            Console.Write($"{tempArray[i, j]} ");
        }
        Console.WriteLine();
    }
}
*/

/*
    Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
    и возвращает значение этого элемента или же указание, что такого элемента нет.
    Например, задан массив:
    1 4 7 2
    5 9 2 3
    8 4 2 4
    17 -> такого числа в массиве нет
*/
/*
int digitOfRow = InputDigit("Введите номер строки: ");
int digitOfColumn = InputDigit("Введите номер столбца: ");

int countOfRows = 4;
int countOfColumns = 4;
int minRandom = 1;
int maxRandom = 100;

int[,] randomIntArray = GenerateRandom2DArray(countOfRows, countOfColumns, minRandom, maxRandom);
ShowResults(randomIntArray);

//Methods
int InputDigit(string textConsole){
    Console.Write(textConsole);
    bool isInt = int.TryParse(Console.ReadLine(), out int number);
    if (isInt && number > 0){
        return number - 1; // индексы начинаются с нуля
    }
    else{
        Console.WriteLine("Неверный ввод!");
        return InputDigit(textConsole);
    }
}

int[,] GenerateRandom2DArray(int row, int column, int min, int max){
    Console.WriteLine("Сгенерированный массив целых чисел:");
    Random random = new Random();
    int[,] tempArray = new int[row, column];    
    for (int i = 0; i < tempArray.GetLength(0); i++){
        for (int j = 0; j < tempArray.GetLength(1); j++){
            tempArray[i,j] = random.Next(min, max);
            Console.Write("{0} ", tempArray[i,j]);
        }
        Console.WriteLine();
    }
    return tempArray;
}

void ShowResults(int[,] tempArray){
    if (digitOfRow > tempArray.GetLength(0) - 1 | digitOfColumn > tempArray.GetLength(1) - 1){
        Console.WriteLine("Такого элемента в массиве нет!");
    }
    else {
        Console.WriteLine("Значение элемента массива = {0}", tempArray[digitOfRow, digitOfColumn]);
    }    
}
*/

/* 
    Задача 52. Задайте двумерный массив из целых чисел. 
    Найдите среднее арифметическое элементов в каждом столбце.
    Например, задан массив:
    1 4 7 2
    5 9 2 3
    8 4 2 4
    Среднее арифметическое каждого столбца: 4,6;  5,6;  3,6;  3.
*/

int countOfRow = InputCount("Введите количество строк: ");
int countOfColumn = InputCount("Введите количество столбцов: ");
int minRandom = 1;
int maxRandom = 100;
int[,] randomArray = CreateRandom2DArray(countOfRow, countOfColumn, minRandom, maxRandom);
Print2DArray(randomArray);

double[] arrayAvgColumns = CalcAvgOfColumns(randomArray);
Console.WriteLine($"Среднее арифметическое каждого столбца: ");
PrintArray(arrayAvgColumns);

//Methods
int InputCount(string textConsole){
    Console.Write(textConsole);
    bool isInt = int.TryParse(Console.ReadLine(), out int number);
    if (isInt && number > 0){
        return number;
    }
    else{
        Console.WriteLine("Неверный ввод!");
        return InputCount(textConsole);
    }
}

int[,] CreateRandom2DArray(int countOfRows, int countOfColumns, int min, int max){
    Random random = new Random();
    int[,] array = new int[countOfRows, countOfColumns];
    for(int i = 0; i < array.GetLength(0); i++){
        for(int j = 0; j < array.GetLength(1); j++){
            array[i, j] = random.Next(min, max);
        }
    }
    return array;
}

void Print2DArray(int[,] tempArray){
    Console.WriteLine("Сгенерированный массив целых чисел:");    
    for(int i = 0; i < tempArray.GetLength(0); i++){
        for(int j = 0; j < tempArray.GetLength(1); j++){
            Console.Write($"{tempArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

double[] CalcAvgOfColumns(int[,] tempArray){
    double[] sum = new double[tempArray.GetLength(1)];
    double[] avg = new double[tempArray.GetLength(1)]; ;
    for (int i = 0; i < tempArray.GetLength(1); i++){
        for (int j = 0; j < tempArray.GetLength(0); j++){
            sum[i] += tempArray[j, i];
        }
    }
    for (int i = 0; i < sum.Length; i++){
        avg[i] = Math.Round((sum[i] / sum.Length), 1);
    }
    return avg;
}

void PrintArray(double[] array){
    Console.WriteLine(string.Join(", ", array));
}