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

