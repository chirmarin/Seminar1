// Напишите программу, которая на вход принимает 2 числа и проверяет, является ли первое число квадратом второго
// a = 25, b = 5  -> да
// a = 2,  b = 10 -> нет
// a = 9,  b = 3  -> да
// a = -3,  b = 9 -> нет
/*
Console.Write("Введите первое число: ");
int a = int.Parse(Console.ReadLine());

Console.Write("Введите второе число: ");
int b = int.Parse(Console.ReadLine());

if (a == b * b) {
    Console.WriteLine("Первое число является квадратом второго");
}
else {
    Console.WriteLine("Первое число НЕ является квадратом второго");
}
*/

// Напишите программу, которая покажет название дня недели по заданному номеру
// 3 -> Среда, 5 -> Пятница

/*
Console.Write("Введите номер дня: ");
int num = int.Parse(Console.ReadLine());

if (num < 1 | num > 7) {
    Console.Write("Неверное число!");
}
    
if (num == 1) {
    Console.Write("Понедельник");
}

if (num == 2) {
    Console.Write("Вторник");
}   

if (num == 3) {
    Console.Write("Среда");
}

if (num == 4) {
    Console.Write("Четверг");
}

if (num == 5) {
    Console.Write("Пятница");
}

if (num == 6) {
    Console.Write("Суббота");
}

if (num == 7) {
    Console.Write("Воскресенье");
}
*/

// Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4" 
// 2 -> " -2, -1, 0, 1, 2"
/*
Console.Write("Введите число (N): ");
int N = int.Parse(Console.ReadLine());

Console.WriteLine("Все целые числа в промежутке от (-N) до (N): ");
*/
/*
for (int i = -N; i <= N; i++) {
    Console.WriteLine(i);
}
*/

/*
int c;
int b;

if (N > 0) {
    b = -N;
    c = N;
}
else {
    b = N;
    c = -N;
}

while (b <= c) {
    Console.WriteLine(b);
    b++;
}
*/

//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
// 456 -> 6 
// 782 -> 2 
// 918 -> 8

/*
Console.Write("Введите число трехзначное число: ");
int a = int.Parse(Console.ReadLine());

Console.Write("Последняя цифра этого числа: ");
if (a > 99 | a < 1000){
    Console.WriteLine(a % 10);
}
*/

