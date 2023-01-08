/*
    Задача 64: Задайте значение N. Напишите программу, которая выведет 
    все натуральные числа в промежутке от N до 1. 
    Выполнить с помощью рекурсии.
    N = 5 -> "5, 4, 3, 2, 1"
    N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

/*
int inputNumber = InputIntPositive("Введите число > 1: ");
Console.WriteLine($"Все натуральные числа в промежутке от {inputNumber} до 1:");
NumbersFromNto1(inputNumber);

//Methods
void NumbersFromNto1 (int number){    
    if (number == 0) return;
    Console.Write($"{number} ");
    NumbersFromNto1(number - 1);
}

int InputIntPositive(string textConsole){
    Console.Write(textConsole);
    bool isInt = int.TryParse(Console.ReadLine(), out int number);
    if (isInt && number > 1) {
        return number;  
    }  
    else {
        Console.WriteLine("Неверный ввод!");
        return InputIntPositive(textConsole);
    }
}
*/

/*
    Задача 66: Задайте значения M и N. Напишите программу, которая найдёт 
    сумму натуральных элементов в промежутке от M до N. 
    Выполнить с помощью рекурсии.
    M = 1; N = 15 -> 120
    M = 4; N = 8. -> 30
*/

/*
int inputNumberM = InputIntPositive("Введите положительное число M (начало): ");
int inputNumberN = InputIntPositive("Введите положительное число N (конец): ");

SumNatureElements(inputNumberM, inputNumberN, 0);

//Methods
void SumNatureElements (int m, int n, int sum){
    if (m > n) {
        Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N: {sum}");
        return;
    }
    sum = sum + m++;
    SumNatureElements(m, n, sum);
}

int InputIntPositive(string textConsole){
    Console.Write(textConsole);
    bool isInt = int.TryParse(Console.ReadLine(), out int number);
    if (isInt && number > 0) {
        return number;  
    }  
    else {
        Console.WriteLine("Неверный ввод!");
        return InputIntPositive(textConsole);
    }
}
*/

/*
    Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
    Даны два неотрицательных числа m и n.
    m = 2, n = 3 -> A(m,n) = 9
    m = 3, n = 2 -> A(m,n) = 29
*/
/*
int inputNumberM = InputIntPositive("Введите число M: ");
int inputNumberN = InputIntPositive("Введите число N: ");

Console.WriteLine($"Функция Аккермана для введеных чисел = {AkkermanFunc(inputNumberM, inputNumberN)}");

//Methods
int AkkermanFunc(int m, int n){
    if (m == 0) {
        return n + 1;
    }
    if (m != 0 && n == 0) {
        return AkkermanFunc(m - 1, 1);
    }
    if (m > 0 && n > 0) {
        return AkkermanFunc(m - 1, AkkermanFunc(m, n - 1));
    }
    return AkkermanFunc(m, n);
}

int InputIntPositive(string textConsole){
    Console.Write(textConsole);
    bool isInt = int.TryParse(Console.ReadLine(), out int number);
    if (isInt && number > 0) {
        return number;  
    }  
    else {
        Console.WriteLine("Неверный ввод!");
        return InputIntPositive(textConsole);
    }
}
*/