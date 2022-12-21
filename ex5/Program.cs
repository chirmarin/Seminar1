//string [,] table = new string[2,5];

//String.Empty - default initialization
// table[0,0]  table[0,1]  table[0,2]  table[0,3]  table[0,4]  
// table[1,0]  table[1,1]  table[1,2]  table[1,3]  table[1,4]

/*
table[1,2] = "слово";
for (int rows = 0; rows < 2; rows++) {
    for (int columns = 0; columns < 5; columns++){
        Console.WriteLine($"-{table[rows,columns]}-");
    }
}
*/

/*
int[,] matrix = new int[3,4];
PrintArray(matrix);
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);
void FillArray(int[,] matr){
    for (int i = 0; i < matr.GetLength(0); i++) {
        for (int j = 0; j < matr.GetLength(1); j++){
            matr[i,j] = new Random().Next(1,10); //[1,10)
        }            
    }
}
void PrintArray(int[,] matr){
    
    for (int i = 0; i < matr.GetLength(0); i++) {
        for (int j = 0; j < matr.GetLength(1); j++){
            Console.Write($"{matr[i,j]} ");
        }    
        Console.WriteLine();
    }
}
*/

//task factorial

//Console.WriteLine(Factorial(3));

/*
double Factorial (int n){
    if(n == 1){ // по определению факториала 1! = 1, а также 0! = 1
        return 1;
    }
    else {
        return n * Factorial(n - 1);
    }
}
for (int i = 1; i < 40; i++){
    Console.WriteLine($"{i}! = {Factorial(i)}");
}
*/

//task fibonacci numbers

/*
f(1) = 1
f(2) = 1
f(n) = f(n-1) + f(n-2)
*/
/*
double Fibonacci(int n){
    if(n == 1 || n == 2){
        return 1;
    }
    else {
        return Fibonacci(n - 1) + Fibonacci(n - 2);
    }
}
for (int i = 1; i < 40; i++){
    Console.WriteLine($"f({i}) => {Fibonacci(i)}");
}
*/

/*Задача 24. Напишите программу, которая принимает на вход число (А) и выдает сумму чисел от 1 до А
7 -> 28   4-> 10   8 -> 36*/

/*
bool isParsed = int.TryParse(Console.ReadLine(), out int number);

if(!isParsed || number < 1){
    Console.WriteLine("Неверное число!");
    return;
}

int sum = GetSum(number);
Console.WriteLine(sum);*/

/*

int[] numbers = new int[]{1,2,3,4};
int[] sums = new int[]{1,3,6,10};

for (var i = 0; i < numbers.Length; i++){
    int sum = GetSum(numbers[i]);
    if (sum != sums[i]){
        Console.WriteLine($"Ожидали получить {sums[i]}, получили -> {sum}");
    }
    else{
        Console.WriteLine("Все ок!");
    }
}

int GetSum(int number){
    int sum = 0;
    for(var i = 1; i <= number; i++){
        sum = sum + i;
    }
    return sum;
}
*/


//Задача 28. Напишите программу, которая принимает на вход число N и выдает произведение числ от 1 до N
//4 -> 24   5-> 120

/*
Console.WriteLine("Введите число:");

bool usersNumber = int.TryParse(Console.ReadLine(), out int number);
if(!usersNumber){
    Console.WriteLine("Неверное число");
    return;
}
else {
    int factorial = Factorial(number);
}

Console.WriteLine($"Факториал числа {number} равен {Factorial(number)}");

void Test(){
    int[] numbers = new int[]{4,5};
    int[] sums = new int[]{24,120};

    for (var i = 0; i < numbers.Length; i++){
        int sum = Factorial(numbers[i]);
        if (sum != sums[i]){
            Console.WriteLine($"Ожидали получить {sums[i]}, получили -> {sum}");
        }
        else{
            Console.WriteLine($"Результат: {sums[i]}");
        }
    }
}

int Factorial(int number){
    if(number == 0 || number == 1){
        return 1;
    }
    return number * Factorial(number - 1);
}
*/
/*
int num = int.Parse(Console.ReadLine());
double j = CountDigitNumber(num);
Console.WriteLine(j);

double CountDigitNumber(int n){
    double product = 1;
    for(it i = 1; i <= n; i++){
        product = product * i;
    }
    return product;
}
*/


// Задача 30. НАпишите программу, которая выводит маcсив из 8 элементов, завполненный нулями и единицами в случайном порядке.

Random rnd = new Random();

bool isInt = int.TryParse(Console.ReadLine(), out int num);
if(!isInt){
    Console.WriteLine("Неверный ввод");
}
else{
    int userLength = num;

    int[] userArray = ArrayFilling(userLength);
    PrintArray(userArray);  
    Test(userArray, userLength);

    int[] ArrayFilling(int userLength){
        int[] arr = new int[userLength];
        for(int i = 0; i < arr.Length; i++){
            arr[i] = rnd.Next(0,2);
        }
        return arr;
    } 

    void PrintArray(int [] array){
        for(int i = 0; i < array.Length; i++){
            Console.WriteLine($"{array[i]} ");
        }
    }
}

void Test(int[] userArray, int userLength){    
    if(userArray.Length == userLength){
        Console.WriteLine("Тест на длину прошел успешно");
    }
    else{
        Console.WriteLine("Тест на длину прошел неуспешно");
    }
    for(int i = 0; i < userArray.Length; i++){
        if(!(i == 0) || (i == 1)){
            Console.WriteLine("Тест на совместимость данных прошел неуспешно");
        }
    }
    Console.WriteLine("Тест на совместимость данных прошел успешно");
}