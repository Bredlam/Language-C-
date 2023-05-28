// УРОК 3. Методы, циклы, массивы.
Console.Clear();
void Method1() // Войд-метод(процедура) который не принимает аргументов и ничего не возвращает ... а просто исполняет код
{
    Console.WriteLine("МояПодпись");
}
Method1(); // Вызов метода

void Method2(string msg) // Войд-метод(процедура) который принимает аргументы, но ничего не возвращает ... а просто исполняет код
{
    Console.WriteLine(msg);
}
Method2("Текст сообщения"); // Вызов метода с указанием литерала в качестве аргумента
Method2(msg: "Именнованый аргумент"); // Вызов метода с указанием именнованного аргумента

int Method3() // Метод который не принимает аргументы, но возвращает (return) результат своего исполнения
{
    return DateTime.Now.Year;
}
int year = Method3();   // Вызов метода ... раз он возвращает результат исполнения то значит должна быть переменная куда он запишет
                        // возвращаемое значение
Console.WriteLine(year);

string Method4(int count, string text01) // Метод который принимает аргументы и возвращает () результат своего исполнения
{
    int i = 0;
    string result01 = String.Empty; // Положили в переменную пустое значение строкового типа

    while (i < count)
    {
        result01 = result01 + text01;
        i++;
    }
    return result01;
}
string result02 = Method4(10, "+"); // Вызов метода ... раз он возвращает результат исполнения то значит должна быть переменная 
                                    // куда он запишет возвращаемое значение
Console.WriteLine(result02);

string Method5(int count, string text02) // Метод который принимает аргументы и возвращает () результат своего исполнения
{
    string result01 = String.Empty; // Положили в переменную пустое значение строкового типа

    for (int i = 0; i < count; i++) // Первый раз использую цикл for ...
    {
        result01 = result01 + text02;
    }
    return result01;
}
string result03 = Method5(10, "0"); // Вызов метода ... раз он возвращает результат исполнения то значит должна быть переменная 
                                    // куда он запишет возвращаемое значение
Console.WriteLine(result03);

// Задача. Вывести таблицу умножения используя цикл
for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i} x {j} = {i * j}");
    }
    Console.WriteLine();
}

// Задача. Дан текст, в тексте нужно все пробелы заменить черточками, маленькие буквы "к" заменить большими "К"
// а большие "С" заменить маленькими "с".
string oldText = "дан текст нужно пробелы заменить на черточки";
string Replase(string text, char oldValue, char newValue)
{
    string result = String.Empty; // Заводим пустую строку
    int length = text.Length; // Получаем количество символов в строке
    for (int i = 0; i < length; i++)
    {
        if (text[i] == oldValue) result += $"{newValue}";
        else result += $"{text[i]}";
    }
    return result;
}
string newText = Replase(oldText, ' ', '-');
Console.WriteLine(newText);

// Задача. Создать массив, заполнить рандомно цифрами, упорядочить от минимального к максимальному
int[] array = { 1, 5, 4, 3, 2, 6, 7, 1, 1 }; // Создали массив и заполнили значениями
void PrintArray(int[] array) // Метод вывода на экран элементов массива
{
    int count = array.Length; // Получили длину массива
    for (int i = 0; i < count; i++)
    {
        Console.Write(array[i] + ",");
    }
    Console.WriteLine();
}
PrintArray(array);
void SelectionSortMinMax(int[] array) // Метод сортировки массива от меньшего к большему
{
    for (int i = 0; i < array.Length; i++)
    {
        int minPosition = i; // Передали в переменную индекс позиции
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition]) minPosition = j;
        }
        int tempPosition = array[i];
        array[i] = array[minPosition];
        array[minPosition] = tempPosition;
    }
}
SelectionSortMinMax(array);
PrintArray(array);
// ПодЗадача. Создать массив, заполнить рандомно цифрами, упорядочить от максимального к минимальному
void SelectionSortMaxMin(int[] array) // Метод сортировки массива от меньшего к большему
{
    for (int i = 0; i < array.Length; i++)
    {
        int maxPosition = i; // Передали в переменную индекс позиции
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] > array[maxPosition]) maxPosition = j;
        }
        int tempPosition = array[i];
        array[i] = array[maxPosition];
        array[maxPosition] = tempPosition;
    }
}
SelectionSortMaxMin(array);
PrintArray(array);

// Задача. Напишите программу которая принимает на вход координаты точки (Х и У), причем Х ≠ 0 и У ≠ 0 и выдает номер
// четверти плоскости, в которой находится эта точка
void UserInputCoord(ref int X, ref int Y) // Определение метода с передачей параметров по ссылке (ref)
{
    while (true)
    {
        try
        {
            Console.Write("Введите Х: ");
            X = int.Parse(Console.ReadLine() ?? "");
            break;
        }
        catch (Exception exc)
        {
            Console.WriteLine($"Ошибка ввода данных! {exc.Message}");
        }
    }
    while (true)
    {
        try
        {
            Console.Write("Введите Y: ");
            Y = int.Parse(Console.ReadLine() ?? "");
            break;
        }
        catch (Exception exc)
        {
            Console.WriteLine($"Ошибка ввода данных! {exc.Message}");
        }
    }
}
int X = 0, Y = 0;
UserInputCoord(ref X, ref Y); // Вызов метода
if (X > 0 && Y > 0)
    Console.WriteLine("1");
else if (X < 0 && Y > 0)
    Console.WriteLine("2");
else if (X < 0 && Y < 0)
    Console.WriteLine("3");
else if (X > 0 && Y < 0)
    Console.WriteLine("4");
else
    Console.WriteLine("Ошибка! Точка попадает на оси координат!");

// Задача. Напиши программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти
// (Х и У). Например, если четверть - 1 то Х > 0 и У > 0
int NQ = 0;
UnputUserNumberOfQuarter(ref NQ); // Вызов метода
FindQuarter(NQ); // Вызов метода
void UnputUserNumberOfQuarter(ref int NQ) // Определение метода
{
    while (true)
    {
        try
        {
            Console.Write("Введите номер четверти: ");
            NQ = int.Parse(Console.ReadLine() ?? "");
            break;
        }
        catch (System.Exception exc)
        {
            Console.WriteLine($"Ошибка! {exc.Message}"); ;
        }
    }
}
void FindQuarter(int NQ) // Определение метода
{
    if (NQ == 1) Console.Write("Диапазон чисел Х > 0 и У > 0");
    else if (NQ == 2) Console.Write("Диапазон числе Х < 0 и У > 0");
    else if (NQ == 3) Console.Write("Диапазон чисел Х < 0 и У < 0");
    else if (NQ == 4) Console.Write("Диапазон чисел Х > 0 и У < 0");
    else
    {
        Console.WriteLine("Вы можете ввести цифру в диапазоне 1 ... 4");
    }
}

// Задача. Напишите программу, которая принимает на вход координаты двух точек и находит
// расстояние между ними в 2D пространстве.
// А(3, 6); B (2, 1) -> 5,09
// А(7,-5); B (1,-1) -> 7,21 
double[] Coordinates = { 0, 0, 0, 0 };
string XY = string.Empty;
UserControlInput01(ref Coordinates, XY); // Вызов метода
void UserControlInput01(ref double[] Coordinates, string XY) // Определение метода
{
    for (int i = 0; i < Coordinates.Length; i++)
    {
        int g = 1 + i;
        if ((g + 1) % 2 == 0)
            XY = "X";
        else
            XY = "Y";

        Console.Write($"Введите координату {XY} ");

        while (true)
        {
            try
            {
                Coordinates[i] = double.Parse(Console.ReadLine() ?? "");
                break;
            }
            catch (System.Exception exc01)
            {
                Console.WriteLine($"Ошибка! Введите число {exc01.Message}");
            }
        }
    }
}
double SecondPower = 2;
double Result01 = Math.Pow(Coordinates[0] - Coordinates[2], SecondPower);
double Result02 = Math.Pow(Coordinates[1] - Coordinates[3], SecondPower);
double Result03 = Math.Sqrt(Result01 + Result02);
Console.Write($"Итог {Result03}");

// Задача. Напишите программу, которая принимает на вход число (N) и выдает таблицу квадратов чисел от 1 до N
// Например, 5 -> 1, 4, 9, 16, 25
int UserNum01 = 0;
ControlUserNum(ref UserNum01); // Вызов метода
UserCalculations01(UserNum01); // Вызов метода
void ControlUserNum(ref int Num) // Определение метода
{
    while (true)
    {
        try
        {
            Console.Write("Введите число: ");
            Num = int.Parse(Console.ReadLine() ?? "");
            break;
        }
        catch (System.Exception exc02)
        {
            Console.WriteLine($"Ошибка! Введите число {exc02}");
        }
    }
}
void UserCalculations01(int Num) // Определение метода
{
    int st = 2;
    for (int i = 1; i <= Num; i++)
    {
        int Result04 = Convert.ToInt32(Math.Pow(i, st));
        Console.Write($"{Result04}, ");
    }
}

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве
// Например: А(3, 6, 8) / В(2, 1, -7) -> 15,84
Console.Clear();
string[] nameCoordinates = { "x1", "y1", "z1", "x2", "y2", "z2" };
double[] coordinates = { 0, 0, 0, 0, 0, 0 };

UserControlInput02(ref coordinates, nameCoordinates); // Вызов метода
CalculatingLengthVector(coordinates); // Вызов метода

void UserControlInput02(ref double[] coord, string[] nameCoord) // Определение метода - контроль ввода данных        
{
    for (int i = 0; i < coord.Length; i++)
    {
        while (true)
        {
            try
            {
                Console.Write($"Введите координаты {nameCoord[i]}: ");
                coord[i] = double.Parse(Console.ReadLine() ?? "");
                break;
            }
            catch (System.Exception exc)
            {
                Console.WriteLine($"Ошибка! Введите число {exc.Message}");
            }
        }
    }

}
void CalculatingLengthVector(double[] coord) // Определение метода - вычисления расстояния между 2-х точек в 3D пространсте
{
    double result01 = 0;
    for (int i = 0; i < coord.Length - 3; i++)
    {
        double result02 = Math.Pow(coord[i] - coord[i + 3], 2);
        result01 += result02;
    }
    Console.Write($"{(Math.Sqrt(result01)):f2}");
}

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом
// Примеры: 14212 -> нет ... 23432 -> да.
Console.Clear();

int userNum02 = UserControlInput03(); // Вызов метода
CalculationPalindrome(userNum02) // Вызов метода
;
static int UserControlInput03() // Определение метода - контроль ввода пятизначного числа      
{
    while (true)
    {
        Console.Write("Введите целое пятизначное число: ");
        if ((int.TryParse(Console.ReadLine(), out int userInt)))
        {
            int controlInt = 0;
            int coint = userInt;
            while (coint > 0)
            {
                controlInt++;
                coint /= 10;
            }
            if (controlInt == 5)
            {
                return userInt;
            }
        }
        Console.WriteLine("Ошибка. Введите целое пятизначное число!");
    }
}
static void CalculationPalindrome(int num) // Определение метода - вычисление палиандрома
{
    if (num / 10000 == num % 10 && num / 1000 % 10 == num / 10 % 10)
        Console.Write($"{num} -> Да");
    else
        Console.Write($"{num} -> Нет");
}

// Напишите программу, которая принимает на вход число (N) и выдает таблицу кубов чисел от 1 до N
// Например: 5 -> 1, 8, 27, 64, 125
int userNum03 = ControlUserInput(); // Вызов метода
UserCalculations02(userNum03);

static int ControlUserInput() // Определение метода - 
{
    while (true)
    {
        try
        {
            Console.Write("Введите число: ");
            int num = int.Parse(Console.ReadLine() ?? "");
            return num;
        }
        catch (System.Exception exc)
        {
            Console.WriteLine($"Ошибка! Введите число: {exc.Message}");
        }
    }
}
static void UserCalculations02(int num) // Определение метода - 
{
    for (int i = 1; i <= num; i++)
    {
        int result = Convert.ToInt32(Math.Pow(i, 3));
        Console.Write($"{result}, ");
    }
}