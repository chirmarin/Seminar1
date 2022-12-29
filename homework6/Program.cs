/* 
    Задача 41: Пользователь вводит с клавиатуры M чисел. 
    Посчитайте, сколько чисел больше 0 ввёл пользователь.
    0,  7,   8, -2, -2   -> 2
    1, -7, 567, 89, -223 -> 3
*/

/*
// Основной блок
Console.WriteLine("Введите несколько целых чисел, разделенных пробелом:");
int[] userIntArray = InputArray();
PrintArray(userIntArray);
Console.WriteLine();

int countPositiveNumbers = FindPositiveNumbers(userIntArray);
Console.WriteLine($"Было введено чисел, которые больше нуля => {countPositiveNumbers}");

// Методы
int[] InputArray(){        
    string[] userArray = (Console.ReadLine()).Split(new char[] {' '});
    int[] tempArray = new int[userArray.Length];
    
    for (int i = 0; i < tempArray.Length; i++){
        bool isInt = int.TryParse(userArray[i], out int num);
        if (isInt){
            tempArray[i] = num;
        } 
        else{
            Console.WriteLine("Недопустимые значения! Повторите ввод");
            return InputArray();
        }
    }
    return tempArray;
} 

void PrintArray(int[] array){
    Console.Write("Введенные числа: [");
    for(int i = 0; i < array.Length; i++){
        if (i == array.Length -1){
            Console.Write($"{array[i]}]");
        }
        else {
            Console.Write($"{array[i]}, ");
        }
    }
}

int FindPositiveNumbers(int[] tempArray){
    int count = 0;
    for (int i = 0; i < tempArray.Length; i++) {
        if (tempArray[i] > 0) {
            count++;
        }
    }
    return count;
}
*/

/*
    Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
    заданных уравнениями y = k1*x + b1, y = k2*x + b2; 
    значения b1, k1, b2 и k2 задаются пользователем.
    b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

/*
// Основной блок
double b1Value = DoubleInput("b1");
double k1Value = DoubleInput("k1");
double b2Value = DoubleInput("b2");
double k2Value = DoubleInput("k2");

FindPointIntersection(b1Value, k1Value, b2Value, k2Value);

//Методы
double DoubleInput (string textConsole){
    Console.Write($"Введите значение {textConsole}:");
    bool isDouble = double.TryParse((Console.ReadLine()), out double num);
    if (!isDouble){
        Console.WriteLine ("Неверный ввод!");
        return DoubleInput(textConsole);
    } 
    else{
        return num;
    }
}

void FindPointIntersection(double b1, double k1, double b2, double k2){
    if(k1 == k2 && b1 == b2){
        Console.WriteLine("Прямые совпадают!");
    }
    else if(k1 == k2){
        Console.WriteLine("Прямые параллельны!");
    }
    else{
        double x = (b2 - b1) / (k1 - k2);
        double y = k1 * (b2 - b1) / (k1 - k2) + b1;
        Console.WriteLine($"Пересечение прямых находится в точке c координатами (x;y) => ({Math.Round(x, 1)};{Math.Round(y, 1)})");
    }
    
}
*/