/* Задача 10:
Напишите программу, которая принимает на вход трёхзначное число 
и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1 
*/

/*
int limLow = 100;
int LimHigh = 1000;
int tempSecondVar = 10;

Console.Write("Введите целое трехзначное число: ");
bool isParsed = int.TryParse(Console.ReadLine(), out int InpNumber);

if (!isParsed) {
    Console.WriteLine("Введено не целое число!");
    return;
} 

if ((InpNumber < limLow  | InpNumber > LimHigh) & (InpNumber > -limLow  | InpNumber < -LimHigh)) {
    Console.WriteLine("Введено не трехзначное число!");
    return;
}
else {
    int firstDigit = InpNumber / limLow;
    int secondDigit = (InpNumber - firstDigit * limLow) / tempSecondVar;
    Console.WriteLine($"Вторая цифра введеного числа - это {System.Math.Abs(secondDigit)}");
} 
*/

/* Задача 13:
Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
что третьей цифры нет. Не использовать string[]

645   -> 5
78    -> третьей цифры нет
32679 -> 6
*/

int chkThirdNumber = 100;
int limThirdNumber = 1000;
int cmnDivider = 10;
int minusOneDigit= 0;
int findDigit = 0;

Console.Write("Введите целое число: ");
bool isParsed = int.TryParse(Console.ReadLine(), out int InpNumber);

if (!isParsed) {
    Console.WriteLine("Введено не целое число!");
    return;
} 

int absInpNumber = System.Math.Abs(InpNumber);

if (absInpNumber < chkThirdNumber) {
    Console.WriteLine("У введеного числа нет третьей цифры!");
    return;
}

while (absInpNumber >= limThirdNumber) { //делаем число с 3 разрядами
    absInpNumber = absInpNumber / cmnDivider;
}

minusOneDigit = absInpNumber / cmnDivider; //теперь делаем на 1 разряд меньше
findDigit = absInpNumber - minusOneDigit * cmnDivider;

Console.WriteLine($"Искомая цифра: {System.Math.Abs(findDigit)}");

/*
Задача 15: 
Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/

/*
int limLow = 1;
int LimHigh = 7;
int[] arrayWeekend = {6,7};
int len = arrayWeekend.Length;
int index = 0;
int flag = 0;

Console.Write("Введите цифру, обозначающую день недели (от 1 до 7): ");
bool isParsed = int.TryParse(Console.ReadLine(), out int InpNumber);

if (!isParsed) {
    Console.WriteLine("Введено не число!");
    return;
} 

if (InpNumber < limLow  | InpNumber > LimHigh) {
    Console.WriteLine("Введено число вне указанного диапазона!");
    return;
}

while(index < len) {
    if(InpNumber == arrayWeekend[index]){        
        flag = 1;
        break;
    }
    index++;
}

if (flag == 1) {
    Console.WriteLine("Выбранный день является выходным");
}
else {
    Console.WriteLine("Выбранный день не является выходным");
}
*/