// Вывести случайное число из отрезка [10, 99] и показать наибольшую цифру числа
/*
Random randаааom = new Random();

int number = randаааom.Next(10, 100);

Console.WriteLine(number);

int firstNumber = number / 10;
int lastNumber = number % 10;

if (firstNumber > lastNumber)
{
    Console.WriteLine(firstNumber);
}
else
{
    Console.WriteLine(lastNumber);
}
*/

// Вывести случайное трехначное число и удалить из него вторую цифру

/*
Random randoma = new Random();
int number = randoma.Next(100, 1000);

Console.WriteLine(number);

int firstNumber = number / 100;
int lastNumber  = number % 10;

int result = firstNumber * 10 + lastNumber;

Console.WriteLine(result);
*/

// Написать программу, которая принимает на вход 2 числа 
// и сообщает является ли второе число кратным первому.
// Если второе число не кратно первому, то программа
// выводит остаток от деления.
/*
Console.WriteLine("Введите первое число: ");
int firstNumber = int.Parse(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int secondNumber = int.Parse(Console.ReadLine());

int rest = secondNumber %  firstNumber;

if (rest == 0){
    Console.WriteLine("Второе число кратно первому");
}
else {
    Console.WriteLine("Второе число не кратно первому. Остаток от деления = " + rest);
}
*/

// Фишечки
/* int a = 5;
Console.WriteLine($"Результат равен = {a} вот так уот"); //интерполяция строк// */
// Фишечки
/* int number  = int.Parse(Console.ReadLine());
bool isParsed = int.TryParse(Console.ReadLine(), out int number);
Console.WriteLine(isParsed); */
//Фишечки
/* int a = 1;
int b = 2;
if(b == a && b % a == 0) //если первое не выполнится, то второе даже смотреть не будем.
//одинарный амперсанд работает как простое логич. И*/



// Написать программу, которая принимает на вход число 
// и проверяет кратно оно 7 и 23 одновременно 

/*
Console.Write("Введите целое число: ");
bool isParsed = int.TryParse(Console.ReadLine(), out int number);
//int number = int.Parse(Console.ReadLine());

if(!isParsed) {
    Console.Write("Неверное число!");
    return; //экстренно завершаем метод
}
else {
    int rest7 = number % 7;
    int rest23 = number % 23;

    if (rest23 == 0 && rest23 == 0){ 
        Console.Write($"Ваше число {number} делится одновременно на 7 и 23");
    }
    else {
        Console.Write($"Ваше число {number} НЕ делится одновременно на 7 и 23");
    }
}
*/

// Написать программу, которая принимает на вход число
// и проверяет является ли одно число квадратом другого
/*
Console.Write("Введите первое число: ");
bool isParsed = int.TryParse(Console.ReadLine(), out int number1);

if(!isParsed) {
    Console.Write("Неверное число!");
    return; //экстренно завершаем метод
}

Console.Write("Введите второе число: ");
isParsed = int.TryParse(Console.ReadLine(), out int number2);

if(!isParsed) {
    Console.Write("Неверное число!");
    return; //экстренно завершаем метод
}

if (number1 == number2 * number2) {
    Console.WriteLine($"Число {number1} является квадратом числа {number2}");
}
else {
    if(number2 == number1 * number1){
        Console.WriteLine($"Число {number2} является квадратом числа {number1}");
    }
    else {
        Console.WriteLine("Ни одно из чисел не является квадратом другого");
    }

}
*/

