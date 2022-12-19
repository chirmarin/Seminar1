/*Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. 
Задание должно быть выполнено в методе. 
В методе не должно быть вывода в консоль. 
Не использовать String!
14212 -> нет
12821 -> да
23432 -> да
*/

/*
//Основной блок
Console.WriteLine("Введите целое число:");
int numInp = InputInt();
if (numInp == -1){ // + обработка если ввели очень большое число
    Console.WriteLine("Неверный тип данных / число вне диапазона");
    return;
}
numInp = System.Math.Abs(numInp);

bool isPalindrome = CheckPalindrome(numInp);
if (isPalindrome){
    Console.Write($"Число {numInp} является палиндромом");
}
else{
    Console.Write($"Число {numInp} не является палиндромом");
}

//Методы
int InputInt(){    
    bool isNum = int.TryParse(Console.ReadLine(), out int num);
    if (isNum){
        return num;
    }
    else {
        return -1;
    }
}

bool CheckPalindrome(int numInput){
    int resNum = numInput;
    int reverseNum = 0;
    int lastDigit = 0;
    int dividerNum = 10;

    while(numInput > 0){
        lastDigit = numInput % dividerNum;
        reverseNum = reverseNum * dividerNum + lastDigit;
        numInput = numInput / dividerNum;
    }

    if (resNum == reverseNum) {        
        return true;
    }
    else {
        return false;
    }

}
*/

/*
Задача 21
Напишите программу, которая принимает на вход координаты двух точек 
и находит расстояние между ними в 3D пространстве. 
Задание должно быть выполнено в методе. 
В методе не должно быть вывода в консоль.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

/*
//Основной блок
int ax = inputInt("ax");
int bx = inputInt("bx");
int ay = inputInt("ay");
int by = inputInt("by");
int az = inputInt("az");
int bz = inputInt("bz");
int powerNum = 2;

double result = GetDistance(ax, bx, ay, by, az, bz, powerNum);
Console.WriteLine($"Расстояние = {result}");

//Методы
int inputInt(string param){
    Console.Write($"Введите координаты {param}: "); 
    bool isNum = int.TryParse(Console.ReadLine(), out int num);
    if (isNum){
        return num;
    }
    else {
        Console.WriteLine("Введено некорректное значение");
        return -1;
    }
}

double GetDistance(int ax, int bx, int ay, int by, int az, int bz, int powerNum){
    double ab = Math.Round(Math.Sqrt(Math.Pow(bx - ax, powerNum) + Math.Pow(by - ay, powerNum) + Math.Pow(bz - az, powerNum)),2);
    return ab;
}
*/

/*
Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N. 
Задание должно быть выполнено в методе и метод должен вернуть массив чисел.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

/*
//Основной блок
int num = inputInt();
if (num <= 0){
    Console.Write("Вы ввели какую-то дичь!");
    return;
}
int powerNum = 3;
int[] cubesTable = GetTableOfCubes(num, powerNum);
PrintArray(cubesTable);

//Методы
int inputInt(){
    Console.Write("Введите положительное целое число больше 0: "); 
    bool isNum = int.TryParse(Console.ReadLine(), out int num);
    if (isNum){
        return num;
    }
    else {
        Console.WriteLine("Вы ввели некорректное значение");
        return -1;
    }
}

int[] GetTableOfCubes(int num, int powr){
    int[] arr = new int[num];
    for(int i = 0; i < num; i++){
        arr[i] = (int)Math.Pow(i + 1, powr); //(int) - приводим double к типу int
    }
    return arr;
}

void PrintArray(int[] array){
    for(int i = 0; i < array.Length; i++){
        Console.Write($"{array[i]} ");
    }
}
*/