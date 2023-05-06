﻿// Console.Clear();
// // Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// // Например: 645 -> 5 ... 78 -> третьей цифры нет ... 32679 -> 6
// #region Задача №?
// int UserInt01;
// Console.Write("Введите целое число: ");
// while (true) // Проверка на ввод целого числа
// {
//     if ((int.TryParse(Console.ReadLine(), out UserInt01))) 
//         break;
//     Console.Write("Ошибка. Введите целое число!:");
// }

// int Сount = 0;
// int TmpInt01 = UserInt01;
// while (TmpInt01 > 0) // Вычисляем сколько знаков в числе
// {
//     Сount++;
//     TmpInt01 /= 10;
// }

// if (Сount >= 3) // Вычисляем 3-ю цифру если число хотя бы трехзначное
// {
//     int TmpInt02 = UserInt01;
//     while (TmpInt02 >= 1000)
//     {
//         TmpInt02 /= 10;
//     }
//     int OstInt01 = TmpInt02 % 10;

//     Console.WriteLine($"{UserInt01} -> {OstInt01}");
// }
// else // Отказ
// {
//     Console.WriteLine($"{UserInt01} -> третьей цифры нет");
// }
// #endregion

// // Напишите программу, которая принимает на вход трехзначное число и на выходе показывает вторую цифру этого числа
// // Например: 456 -> 5 ... 782 -> 8 ... 917 -> 1
// #region Задача №?
// Console.Clear();
// int UserInt02;
// Console.Write("Введите целое трехзначное число: ");
//     while (true)
//     {
//         if ((int.TryParse(Console.ReadLine(), out UserInt02)))
//         {
//             int ControlInt = 0;
//             int coint = UserInt02;
//             while (coint > 0)
//             {
//                 ControlInt++;
//                 coint/=10;
//             }
//             if (ControlInt == 3) break;        
//         }
//         Console.WriteLine("Ошибка. Введите целое трехзначное число!");
//     }

// int OstInt = UserInt02 % 100 / 10;

// Console.WriteLine($"Результат: {OstInt}");
// #endregion

// // Работа с массивами, базовый уровень синтаксиса
// #region Урок №?
// int[] array0 = {1, 12, 31, 4, 15, 16, 17, 18}; // Обозначили массив - array и присвоили/передали в массив значения

// int n = array0.Length; // Передали в переменную - n - значение длины массива (кол-во элементов массива)
// int find = 4; // переменная с искомым значением

// int index = 0; // переменная-счетчик которая будет работать по индексу в массиве

// while (index < n)
// {
//     if (array0[index] == find)
//     {
//         Console.Write($"Указанное значение {find} присутствует в массиве");
//         break; // оператор прерывания        
//     }    
//     index++;
// }

// // Работа с массивами и функциями/методами
// void FillArray(int[] collection) //собственно имя функции/метода и ее параметры/агрументы
// {
//     int Length = collection.Length;
//     int Index1 = 0;
//     while (Index1 < Length)
//     {
//         collection[Index1] = new Random().Next(1, 10); // По указанному индексу кладем случайное число из диапазона 1-10
//         Index1++; // счетчик цикла
//     }
// }

// void PrintArray01(int[] col)
// {
//     int coint = col.Length;
//     int position = 0;
//     while (position < coint)
//     {
//         Console.WriteLine(col[position]);
//         position++;
//     }
// }

// int IndexOf(int[] massiv, int Find01)
// {
//     int N01 = massiv.Length;
//     int coint01 = 0;
//     int SaveBox = -1;   // ввели начальное значение -1 чтобы если нет значений в массиве то выходило это базовое значение
//                         // которое нам точно сообщит что искомого значения в массиве нет

//     while (coint01 < N01)
//     {
//         if (Find01 == massiv[coint01])
//         {
//             SaveBox = coint01;
//             break;            
//         }
//         coint01++;
//     }
//     return SaveBox;
// }

// int[] array = new int[10];  // Определили массив и определи что в массиве будет 10 элементов 
//                             // т.е. - new int[10] - звучит так - создай новый массив с 10-ю элементам ... 
//                             //по умолчанию элементы будут заполнены нулями

// FillArray(array);
// PrintArray01(array);
// Console.Write("Введите значение которое нужно найти в массиве: ");
// int pos = IndexOf(array, int.Parse(Console.ReadLine() ?? ""));
// Console.Write($"Позиция индекса в массиве где находится искомое значение = {pos}");

// // Пример кода: циклический ввод переменной типа double - контроль ввода пользователем правильных данных
// double varA; // память под вещественную (тип double) переменную выделена, но не инициализирована т.к. значение под нее введет пользователь
// while (true) // бесконечный цикл
// {
//     Console.Write("Введите А: ");
//     if (double.TryParse(Console.ReadLine(), out varA))  // в этой строке при вводе данных проверяется тип значения данных которые
//                                                         // вводит пользователь и если при попытке преобразования - .TryParse получившийся
//                                                         // тип значения не подходит под назначенный (в данном случае это double) в условие
//                                                         // оператора if не выполняется и не происходит прерывание - break
//                                                         // и у нас работает бесконечный цикл
//     {
//         break;
//     }
//     Console.WriteLine("Ошибка ввода!");
// }
// Console.WriteLine($"А={varA}");
// #endregion

// // Напишите программу, которая выводит случайное число из отрезка [10, 99]
// // и показывает наибольшую цифру числа, например:
// // 78 -> 8 или 12 -> 2 или 75 -> 7
// int num = new Random().Next(10, 100);
// int a0 = num / 10;
// int a1 = num % 10;
// int max = a0;
// if (max < a1) max = a1;
// Console.WriteLine($"Максимальная цифра в числе {num} -> {max}");

// // Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа
// // Например: 456 -> 46
// int num01 = new Random().Next(100, 1000);
// int a2 = num01 / 100; 
// int a3 = num01 % 10;

// int num02 = a2 * 10 + a3;

// Console.WriteLine($"{num01}->{num02}");

// // Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе
// // число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.
// // Например: 34, 5 -> не кратно, остаток 4 или 16, 4 -> кратно
// Console.Write("Введите первое число: ");
// int UserInt010;
// while (true)
// {
//     if (int.TryParse(Console.ReadLine(), out UserInt010))
//     {
//         break;
//     }
//     Console.WriteLine("Ошибка. Введите целое число!");
// }

// Console.Write("Введите второе число: ");
// int UserInt020;
// while (true)
// {
//     if (int.TryParse(Console.ReadLine(), out UserInt020))
//     {
//         break;
//     }
//     Console.WriteLine("Ошибка. Введите целое число!");
// }

// int Result = UserInt010 % UserInt020;
// if (Result == 0)
// {
//     Console.Write($"{UserInt010}, {UserInt020} -> кратно");
// }
// else
// {
//     Console.Write($"{UserInt01}, {UserInt02} -> не кратно, остаток {Result}");
// }

// // Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно
// // 7 и 23. Например: 14 -> нет; 46 -> нет; 161 -> да
// Console.Write("Введите число: ");
// int UserInt;
// while (true)
// {
//     if (int.TryParse(Console.ReadLine(), out UserInt))
//     {
//         break;
//     }
//     Console.WriteLine("Ощибка.Введите целое число!");
// }

// int ControlInt01 = 7;
// int ControlInt02 = 23;

// if (UserInt / ControlInt01 == ControlInt02 & UserInt / ControlInt02 == ControlInt01)
// {
//     Console.WriteLine("Да");
// }
// else
// {
//     Console.WriteLine("Нет");
// }

// // Напишите программу, которая на вход принимает число N,
// // а на выходе показывает все четные числа от 1 до N
// Console.Clear();
// Console.Write("Введите число: ");
// int UserInt11 = int.Parse(Console.ReadLine() ?? "");

// int count1 = 0;
// int Result11 = UserInt11 % 2;
// while (count1 < UserInt11 - Result11)
// {
//     count1 += 2;
//     Console.Write(count1 + " ");    
// }

// // Рисуем фрактал в терминале указывая в каждой позиции символ +
// Console.Clear();

// int xa = 30, ya = 1,
//     xb = 1, yb = 20,
//     xc = 60, yc = 20;

// Console.SetCursorPosition(xa, ya);

// Console.WriteLine("+");

// Console.SetCursorPosition(xb, yb);
// Console.WriteLine("+");

// Console.SetCursorPosition(xc, yc);
// Console.WriteLine("+");

// int x = xa, y = xb;

// int count = 0;

// while (count < 10000)
// {
//     int what = new Random().Next(0,3); // Т.е. по факту будут выдаваться числа [0;3) - 0 1 2
//     if (what == 0)
//     {
//         x = (x + xa)/2;
//         y = (y + ya)/2;
//     }
//     if (what == 1)
//     {
//         x = (x + xb)/2;
//         y = (y + yb)/2;
//     }
//     if (what == 2)
//     {
//         x = (x + xc)/2;
//         y = (y + yc)/2;
//     }
//     Console.SetCursorPosition(x, y);
//     Console.WriteLine("+");
//     count++; 
// }

// // Напишите программу, которая на вход принимает число и выдает, 
// // является ли число четным т.е. делится ли оно на два без остатка
// Console.Clear();

// Console.Write("Введите число: ");
// int FirstInt = int.Parse(Console.ReadLine() ?? "");

// if (FirstInt % 2 == 0)
// {
//     Console.Write($"Число -> {FirstInt} является четным");
// }
// else
// {
//     Console.Write($"Число -> {FirstInt} НЕ является четным");
// }

// // Используем метод .ToLower() нижнего регистра для унифицации строковых данных во избежание невозможности сравнить
// // данные из-за разных регистров (верхних и нижних) строковых данных
// Console.Write("Введите имя: ");
// string UserName = Console.ReadLine() ?? "";
// string ControlName = "Андрей";
// if (ControlName.ToLower() == UserName.ToLower())
// {
//   Console.Write("Привет, " + ControlName + " ты тут главный!!!");  
// }
// else
// {
//     Console.Write("Привет, незнакомец!");  
// }


// // УРОК 4. Лекция. Рекурсия и двумерные массивы
// Console.Clear();
// TwoDimensionalStringArray();
// void TwoDimensionalStringArray() // Определение метода - пример двумерного строкового массива
// {
//     string[,] table = new string[2, 2]; // двумерный строковой массив, где у нас 2 - строки и 2 - столбцы
//     table[0, 0] = "ДобавленныеДанные"; // пример записи в двумерном массиве по нужному адресу
//     for (int rows01 = 0; rows01 < table.GetLength(0); rows01++) // этот цикл обходит строки
//     {
//         for (int colums01 = 0; colums01 < table.GetLength(1); colums01++) // этот цикл обходит столбцы
//         {
//             Console.Write($"-{table[rows01, colums01]}+ СдМ ");
//         }
//         Console.WriteLine();
//     }
// }

// TwoDimensionalIntegerArray();
// void TwoDimensionalIntegerArray() // Определение метода - пример двумерного числового массива
// {
//     int[,] matrix = new int[4, 4]; // двумерный числовой массив, где у нас 2 - строки, 2 - столбцы
//     matrix[0, 0] = 888; // пример записи в двумерном массиве по нужному адресу
//     for (int rows02 = 0; rows02 < matrix.GetLength(0); rows02++) // этот цикл обходит строки
//     {
//         for (int colums02 = 0; colums02 < matrix.GetLength(1); colums02++) // этот цикл обходит столбцы
//         {
//             if(matrix[rows02, colums02] == 0)
//                 matrix[rows02, colums02] = new Random().Next(100,1000); // не забывай, что вторая цифра не включается в интервал т.е. [100,1000)
//             Console.Write($"{matrix[rows02, colums02]} ");
//         }
//         Console.WriteLine();
//     }
// } 

// // Задача. "Закрасить область". Отрабатываем эффект рекурсии
// int[,] pic = new int[,] // Фиксированные данные поэтому двумерный диапазон не указываем
// {
//  {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
//  {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
//  {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
//  {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
//  {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
//  {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
//  {0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
//  {0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
//  {0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
//  {0, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0 },
//  {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
//  {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
//  {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0 },
//  {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
//  {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
//  {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0 },
//  {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0 },
//  {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0 },
//  {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0 },
//  {0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0 },
//  {0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0 },
//  {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0 },
//  {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// };
// PrintArray02(pic); // Вызов метода
// FullImage(13, 13); // Вызов метода
// PrintArray02(pic); // Вызов метода
// void PrintArray02(int[,] matr) // Определение метода - опрделяем контур картинки
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             if(matr[i,j] == 0) Console.Write(" ");
//             else Console.Write("+");
//         }
//         Console.WriteLine();
//     }
// }
// void FullImage(int row, int col) // Определение метода - закрашиваем картинку
// {
//     if(pic[row, col] == 0)
//     {
//         pic[row, col] = 1;
//         FullImage(row-1,col);
//         FullImage(row,col-1);
//         FullImage(row+1,col);
//         FullImage(row,col+1);
//     }
// }

// // Задача. Вычисление факториала. Отрабатываем эффект рекурсии
// int Factorial01(int n) // Определение метода - вычисление факториала, работаем с типом int
// {
//     if(n == 1) return 1;    // 1! = 1 (читается как: факториал единицы равен единице)
//                             // Кстати, в общем случае 0! = 1
//     else return n * Factorial01(n-1);
// }
// double Factorial02(double n) // Определение метода - вычисление факториала, работаем с типом double
// {
//     if(n == 1) return 1;    // 1! = 1 (читается как: факториал единицы равен единице)
//                             // Кстати, в общем случае 0! = 1
//     else return n * Factorial02(n-1);
// }
// //Console.WriteLine(Factorial(3)); // Вывод на печать + вызов метода
// // ПодЗадача. Вычисление факториала. Отрабатываем проблему при вычислении факториала
// // Проблема в том что тип int (целое число) неспособен вместить в себя значение !17 и поэтому
// // у !17 в коде (при вычисление) появляется уже отрицательное число -288522240 что не есть правильно...
// Console.WriteLine("Вычисляем факториал используя тип значения переменной - int");
// for (int i = 1; i < 40; i++)
// {
//     Console.WriteLine($"Число {i} и его факториал {Factorial01(i)}");
// }
// // ... проблему решает смена типа значения переменной на более "емкий" тип, например, - double
// Console.WriteLine("Вычисляем факториал используя тип значения переменной - double");
// for (double j = 1; j < 40; j++)
// {
//     Console.WriteLine($"Число {j} и его факториал {Factorial02(j)}");
// }

// // Задача. Числа Фибоначчи. Отрабатываем эффект рекурсиию
// // Числа Фибонначи - где каждое следующее число задается через предыдущее число
// // f(1) = 1
// // f(2) = 1
// // f(n) = f(n-1) + f(n-2)
// int Fibonacci01(int n)
// {
//     if(n == 1 || n == 2) return 1;
//     else return Fibonacci01(n-1) + Fibonacci01(n-2);
// }
// for (int i = 1; i < 70; i++)
// {
//     Console.WriteLine($"№ {i} - {Fibonacci01(i)}");
// }
// // 63245986
// // ... здесь есть один маленький момент - уже на 36-й итерации я получаю значительное замедление выполнения рекурсии 
// // и дальше замедление растет в геометрической прогресии ...
// double Fibonacci02(int n)
// {
//     if(n == 1 || n == 2) return 1;
//     else return Fibonacci02(n-1) + Fibonacci02(n-2);
// }
// for (int i = 1; i < 70; i++)
// {
//     Console.WriteLine($"№ {i} - {Fibonacci01(i)}");
// } 


// // ДОМАШНИЕ РАБОТЫ.
// // Задача 25. Напишите цикл, который принимает на вход два числа (А и В) и возводит число А в
// // натуральную степерь В.

// Задача 27. Напишите программу, которая принимает на вход число и выдает сумму цифр в числе.
// Например: 452 -> 11
int ControlUserInput05() // Определение метода - контроль ввода данных пользователя
{
    while (true)
    {
        Console.Write("Введите целое число: ");
        if (int.TryParse(Console.ReadLine(), out int userNum))
            return userNum;
        Console.WriteLine("Ошибка! Введите целое число: ");
    }
}
int SummNumOfTally(int num) // Определение метода - вычисление суммы цифр числа
{
    int result = 0;
    int numLenght = num.ToString().Length;
    for (int i = 0; i < numLenght; i++)
    {
        result += num % 10;
        num /= 10;
    }
    return result;
}
void ResultOutput05(int num, int result) // Определение метода - вывод данных пользователю
{
    System.Console.WriteLine($"{num} -> {result}");
}

int userNum03 = ControlUserInput05();
int userResult04 = SummNumOfTally(userNum03);
ResultOutput05(userNum03, userResult04);

// Задача 29. Напишите программу, которая задает массив из 8 элементов и выводит их на экран.
// -- эту задачу я делать не стал т.к. они зафейлили условие задачи :))))