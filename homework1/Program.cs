/*
Задача 2: 
Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Примечание: добавить условие когда числа равны.

Данные:
a = 5,  b = 7   -> max = 7
a = 2,  b = 10  -> max = 10
a = -9, b = -3  -> max = -3
*/

/*
Console.Write("Введите первое число: ");
int firstNumber = int.Parse(Console.ReadLine());

Console.Write("Введите второе число: ");
int secondNumber = int.Parse(Console.ReadLine());

int max = firstNumber;

if (firstNumber == secondNumber) {
    Console.WriteLine("Числа равны!");
}
else {
    if (firstNumber < secondNumber){
        max = secondNumber;            
    }
    Console.WriteLine("Максимум = "  + max);
}  
*/

/*
Задача 4: 
Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Данные:
2,  3, 7  -> 7
44, 5, 78 -> 78
22, 3, 9  -> 22
*/

/*
Console.Write("Введите первое число: ");
int firstNumber = int.Parse(Console.ReadLine());

Console.Write("Введите второе число: ");
int secondNumber = int.Parse(Console.ReadLine());

Console.Write("Введите третье число: ");
int thirdNumber = int.Parse(Console.ReadLine());

int max = firstNumber;

if (firstNumber == secondNumber &&  secondNumber == thirdNumber) {
    Console.WriteLine("Числа равны!");
}
else {
    if (max < secondNumber){
        max = secondNumber;            
    }
    if (max < thirdNumber){
        max = thirdNumber;            
    }
    Console.WriteLine("Максимум = "  + max);
}  
*/

/*
Задача 6: 
Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Данные:
4  -> да
-3 -> нет
7  -> нет
*/

/*
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());

if (num % 2 == 0){
    Console.WriteLine("Ваше число четное!");
}
else {
    Console.WriteLine("Ваше число нечетное!");
}
*/

/*
Задача 8: 
Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Данные: 
5 -> 2, 4
8 -> 2, 4, 6, 8
*/

/*
Console.Write("Введите число (N): ");
int num = int.Parse(Console.ReadLine());

Console.WriteLine("Выводим все четные числа от 1 до N:");
int temp = 1;

while (temp <= num)
{
    if ((temp % 2) == 0) {
        Console.WriteLine(temp);
        temp++;
    }
    else {
        temp++;
    }
} 
*/