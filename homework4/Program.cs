/*
Задача 25: Напишите программу, которая принимает на вход два числа (A и B) 
и метод который возводит число A в натуральную степень B. 
Задание должно быть выполнено в методе. 
В методе не должно быть вывода в консоль. 
Не использовать Math.Pow()
*/
/*
//Основной блок
int inpA = InputNum("A");
if (inpA == -1){ //не знаю как вывести проверку один раз для всех чисел и чтобы выкидывало из main
    Console.Write("Неверный тип данных / число вне диапазона");
    return;
}

int inpB = InputNum("B (натуральное)");
if (inpB == -1 || inpB <= 0){ 
    Console.Write("Неверное число / вне диапазона");
    return;
}

//Расчет и вывод результата
int resultPow = MakePow(inpA, inpB);
Console.WriteLine($"А в степени В = {resultPow}");

//Методы
int InputNum(string paramNum) {
    Console.WriteLine($"Введите число {paramNum}: ");
    bool isInt = int.TryParse(Console.ReadLine(), out int num);
    if (isInt) {
        return num;
    }
    else {
        return -1;
    }    
}

int MakePow(int varA, int varB) {
    int result = varA;
    for (int i = 1; i < varB; i++) {
        result *= varA;
    }
    return result;
}
*/

/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452  -> 11
82   -> 10
9012 -> 12
*/

/*
//Основной блок
int inpN = InputNum();
if (inpN == -1){
    Console.Write("Неверный тип данных / число вне диапазона");
    return;
}

//Расчет и вывод результата
int result = SumNumbers(inpN);
Console.WriteLine($"Сумма всех цифр в числе = {result}");

//Методы
int InputNum() {
    Console.WriteLine($"Введите число: ");
    bool isInt = int.TryParse(Console.ReadLine(), out int num);
    if (isInt) {
        return Math.Abs(num);
    }
    else {
        return -1;
    }    
}

int SumNumbers(int inpVar){
    int sumDigits = 0;
    int temp = 0;
    int dividerNum = 10;
    while (inpVar > 0){
        temp = inpVar % dividerNum;
        inpVar = inpVar / dividerNum;
        sumDigits = sumDigits + temp;
    }
    return sumDigits;
}
*/

/*
Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33       -> [6, 1, 33]
*/

/*
//Основной блок
int inpN = InputNum();
if (inpN == -1){
    Console.Write("Неверный тип данных / число вне диапазона");
    return;
}

//Заполнение и вывод результата
int[] outArray = CreateArray(inpN);
PrintArray(outArray);

//Методы
int InputNum() {
    Console.WriteLine($"Введите количество элементов массива: ");
    bool isInt = int.TryParse(Console.ReadLine(), out int num);
    if (isInt) {
        return num;
    }
    else {
        return -1;
    }    
}

int[] CreateArray(int size){    
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++) {
        Console.Write($"Введите элемент ({i}): ");
        array[i] = int.Parse(Console.ReadLine());        
    }    
    return array;
}

void PrintArray(int[] array){
    Console.Write("Итоговый массив данных -> [");
    for(int i = 0; i < array.Length; i++){
        if (i == array.Length -1){
            Console.Write($"{array[i]}]");
        }
        else {
            Console.Write($"{array[i]}, ");
        }
    }
}
*/