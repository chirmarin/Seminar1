// Вид 1 у методов
/*
void Method1(){
    Console.WriteLine("Автор ...");
}

// Вызов
Method1();
*/

// Вид 2 у методов
/*
void Method2(string msg){
    Console.WriteLine(msg);
}

// Вызов
Method2(msg: "Текст сообщения");
*/

/*
void Method21(string msg, int count){
    int i = 0;
    while(i < count){
        Console.WriteLine(msg);
        i++;
    }
}

// Вызов
//Method21("Текст", 4);
//Method21(msg: "Текст", count: 4);
Method21(count: 5, msg: "Текст1");
*/

// Вид 3 у методов
/*
int Method3(){
    return DateTime.Now.Year;
}

// Вызов
int year = Method3();
Console.WriteLine(year);
*/

// Вид 4 у методов
/*
string Method4(int count, string text){
    int i = 0;
    string result = String.Empty; //or = ""
    while(i < count){
        result = result + text;
        i++;
    }
    return result;
}

// Вызов
string res = Method4(10, "asdf");
Console.WriteLine(res);
*/
 /*
//ver2.0
string Method4(int count, string text){    
    string result = String.Empty; //or = ""
    for(int i = 0; i < count; i++){
        result = result + text;
    }
    return result;
}

// Вызов
string res = Method4(10, "asdf");
Console.WriteLine(res);
*/

/*
//Замена символов
string text = "- Я думаю, - сазал князь, улыбаясь, - что, " + "ежели бы вас послали вместо нашего милого Винценгероде,"
+ "вы бы взяли приступом согласие прусского короля. " + "Вы так красноречивы. Вы дадите мне чаю?";

string Replace(string text, char oldValue, char newValue){
    string result = String.Empty;
    int length = text.Length;
    for(int i = 0; i < length; i++){
        if (text[i] == oldValue){
            result = result + $"{newValue}";            
        }
        else {
            result = result + $"{text[i]}";
        };
    }
    return result;
}

string newText = Replace(text, ' ', '|');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(newText, 'к', 'К');
Console.WriteLine(newText);
*/
/*
//сортировка
int[] arr = {1,5,4,3,2,6,7,1,1};

void PrintArray(int[] array){
    int count = array.Length;
    for(int i = 0; i < count; i++){
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array){
    
    for(int i = 0; i < array.Length - 1; i++){
        int minPosition = i;

        for(int j = i + 1; j < array.Length; j++){
            if(array[j] < array[minPosition]){
                minPosition = j;
            }
        }

        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}

PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);
*/

/*СЕМИНАР ЗАДАЧА 1 */
/*
bool isParsedX = int.TryParse(Console.ReadLine(), out int x);
bool isParsedY = int.TryParse(Console.ReadLine(), out int y);

if(!isParsedX || !isParsedY){
    Console.WriteLine("Координаты введены некорретно!");
    return;
}

int quarterNumber = GetQuarterNumberByCoordinates(x,y);
if (quarterNumber == -1) { //warning or exception
    Console.WriteLine("Координаты равны нулю!");
    return;
}

Console.WriteLine(quarterNumber);

//возвращаемый_тип_данных НазваниеМетода() {
//    return 1; // оператор return возвращает из метода значение и останавливает его
//}

int GetQuarterNumberByCoordinates(int x, int y) {
    if (x > 0 && y > 0){
        return 1;
    }
    if (x < 0 && y > 0){
        return 2;
    }
    if (x < 0 && y < 0){
        return 3;
    }
    if (x > 0 && y < 0){
        return 4;
    }

    return -1; //warning or exception
}
*/

//Напишите программу, которая по заданному номеру четверти показывает диапазон возможных координат точек в этой четверти (x, y)
/*
Console.WriteLine("Введите номер четверти от 1 до 4");
int coord = inputInt();
Console.WriteLine(GetCoordinates(coord));

int inputInt(){    
    bool isNum = int.TryParse(Console.ReadLine(), out int num);
    if (isNum){
        return num;
    }
    else {
        Console.WriteLine("Вы ввели некорректное значение");
        return -1;
    }
}

string GetCoordinates(int num) {
    if (num == 1){
        return "x > 0 && y > 0"; 
    }
    if (num == 2){
        return "x < 0 && y > 0";
    }
    if (num == 3){
        return "x < 0 && y < 0";
    }
    if (num == 4){
        return "x > 0 && y < 0";
    }
    return "Какая-то дичь!"; 
}
*/

//Напишите программу, которая принимает на вход координаты 2 точек и находит расстояние между ними в 2D пространстве.
// A(3,6); B(2,1) -> 5.09
// A(7,-5); B(1,-1) -> 7.21
/*
using static Console; --чтобы писать сразу writeline и все
void PrintArray(int[] array){
    for(int i = 0; i < array.Length; i++){
        Console.WriteLine(array[i]);
    }
}
AB = квадратный корень из AC(во 2 степени) + BC(во 2 степени)
*/
/*
int ax = inputInt();
int bx = inputInt();
int ay = inputInt();
int by = inputInt();

double result = GetDistance(ax, bx, ay, by);
Console.WriteLine(result);

int inputInt(){
    Console.WriteLine("Введите число"); 
    bool isNum = int.TryParse(Console.ReadLine(), out int num);
    if (isNum){
        return num;
    }
    else {
        Console.WriteLine("Вы ввели некорректное значение");
        return -1;
    }
}

double GetDistance(int ax, int bx, int ay, int by){
    double ab = Math.Sqrt((bx - ax)*(bx - ax) + (by - ay)*(by - ay)); 
    return ab;
}
*/

//Напишите программу, которая принимает на вход число (N) и выдает таблицу квадратов чисел от 1 до N.
//5 -> 1,4,9,16,25
//2 -> 1,4
/*
int num = inputInt();
int[] squaresTable = GetTableOfSquares(num);
PrintArray(squaresTable);

int inputInt(){
    Console.WriteLine("Введите число"); 
    bool isNum = int.TryParse(Console.ReadLine(), out int num);
    if (isNum){
        return num;
    }
    else {
        Console.WriteLine("Вы ввели некорректное значение");
        return -1;
    }
}

int[] GetTableOfSquares(int num){
    int[] arr = new int[num];
    for(int i = 0; i < num; i++){
        arr[i] = (int)Math.Pow(i + 1, 2);//(int) - приводим double к типу int
    }
    return arr;
}

void PrintArray(int[] array){
    for(int i = 0; i < array.Length; i++){
        Console.WriteLine(array[i]);
    }
}
*/