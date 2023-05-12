Console.Clear();

#region Задача 

    #region Degining Methods
    
    #endregion
#endregion

// УРОК 7. ЛЕКЦИЯ

// УРОК 7. СЕМИНАР
// На уроке начал практиковать применение общих методов для всех задач
#region Задача 46
// Console.WriteLine("Задача 46");
// // // Задайте двумерный массив размером m*n, заполненный случайными целыми числами.
// // // m = 3, n = 4
// // // 1, 4, 8, 19
// // // 5, -2, 33, -2
// // // 77, 3, 8, 1
// int rows = GetParameters("Введите количество строк массива: ","Ошибка!");
// int colums = GetParameters("Введите количество столбцов массива: ", "Ошибка!");
// int[,] arrayTD = CreateTwoDimensionalArray(rows, colums);
// arrayTD = FillArrayTDRandomNum(arrayTD, 0, 10);
// PrintArrayTD(arrayTD);

//     #region Degining Methods
//         // метод получающий целое значение от пользователя
//         int GetParameters(string userMsg, string errorMsg)
//         {
//             while (true)
//             {
//                 Console.Write(userMsg);
//                 if(int.TryParse(Console.ReadLine(), out int userPam))
//                     return userPam;
//                 Console.WriteLine(errorMsg);
//             }
//         }
//         // метод создающий двумерный целочисленный массив
//         int[,] CreateTwoDimensionalArray(int rows, int colums)
//         {
//             int[,] arrayTD = new int[rows, colums];
//             return arrayTD;
//         }
//         // метод заполняющий двумерный массив рандомными числами
//         int[,] FillArrayTDRandomNum(int[,] arrayTD, int minValue, int maxValue)
//         {            
//             for (int i = 0; i < arrayTD.GetLength(0); i++) // метод .GetLength(0) определяющий движение цикла по строке двумерного массива
//             {
//                 for (int j = 0; j < arrayTD.GetLength(1); j++) // метод .GetLength(1) определяющий движение цикла по колонке двумерного массива
//                 {
//                     arrayTD[i,j] = new Random().Next(minValue, maxValue + 1);                    
//                 }                
//             }
//             return arrayTD;
//         }
//         // метод выводящий в консоль данные массива для пользователя
//         void PrintArrayTD(int[,] arrayTD)
//         {
//             for (int i = 0; i < arrayTD.GetLength(0); i++)
//             {
//                 for (int j = 0; j < arrayTD.GetLength(1); j++)
//                 {
//                     Console.Write($" {arrayTD[i,j]}");
//                 }
//                 Console.WriteLine();
//             }
//         }
//     #endregion
// Console.WriteLine();
#endregion

#region Задача 48
// Console.WriteLine("Задача 48");
// // // Задайте двумерный массив размера m*n, каждый элемент в массиве находится по формуле: Аmn = m+n.
// // // Выведите полученный массив на экран
// // // m = 3, n = 4
// // // 0 1 2 3
// // // 1 2 3 4
// // // 2 3 4 5
//  arrayTD = FillTwoDimensionalArray(arrayTD);
//  PrintArrayTD(arrayTD);

//     #region Degining Methods
//         int[,] FillTwoDimensionalArray(int[,] arrayTD)
//         {
//             for (int i = 0; i < arrayTD.GetLength(0); i++)
//             {
//                 for (int j = 0; j < arrayTD.GetLength(1); j++)
//                 {
//                     arrayTD[i,j] = i + j;
//                 }
//             }
//             return arrayTD;
//         }
//     #endregion
// Console.WriteLine();
#endregion

#region Задача 49
// Console.WriteLine("Задача 49");
// // Задайте двумерный массив. Найдите элементы, у которых оба индекса нечетные, и замените эти элементы на их квадраты
// arrayTD = FillArrayTDRandomNum(arrayTD, 1, 10);
// PrintArrayTD(arrayTD);
// arrayTD = CalculateOddIndexOfTwoDimensionalArray(arrayTD);
// PrintArrayTD(arrayTD);

//     #region Degining Methods
//         int[,] CalculateOddIndexOfTwoDimensionalArray(int[,] arrayTD)
//         {
//             for (int i = 0; i < arrayTD.GetLength(0); i++)
//             {
//                 for (int j = 0; j < arrayTD.GetLength(1); j++)
//                 {
//                     if(i % 2 != 0 && j % 2 != 0)
//                         arrayTD[i,j] = arrayTD[i,j] * arrayTD[i,j];
//                 }
//             }
//             return arrayTD;
//         }
//     #endregion
// Console.WriteLine();
// #endregion

// #region Задача 51
// // Console.WriteLine("Задача 51");
// // // Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1,1) и т.д.)
// arrayTD = FillArrayTDRandomNum(arrayTD, 1, 10);
// PrintArrayTD(arrayTD);
// int userNum = FindSumElementsInMainDiagonalOfTwoDimensionalArray(arrayTD);
// PrintNumResult("Результат: ", userNum);

//     #region Degining Methods
//         int FindSumElementsInMainDiagonalOfTwoDimensionalArray(int[,] arrayTD)
//         {
//             int sum = 0;
//             for (int i = 0; i < arrayTD.GetLength(0); i++)
//             {
//                 for (int j = 0; j < arrayTD.GetLength(1); j++)
//                 {
//                     if(i == j) sum += arrayTD[i,j];
//                 }
//             }
//             return sum;
//         }
//         void PrintNumResult(string userMsg, int num)
//         {
//             Console.WriteLine($"{userMsg}, {num}");
//         }
//     #endregion
// Console.WriteLine();
#endregion

#region Домашняя задача 47
Console.WriteLine("Задача 47");
// Задайте двумерный массив размера m*n, заполненный случайными вещественными числами
int rows01 = GetParameters01("Введите количество строк массива: ","Ошибка!");
int colums01 = GetParameters01("Введите количество столцов массива: ","Ошибка!");
double[,] arrayTD01 = CreateTwoDimensionalDoubleArray(rows01, colums01);
arrayTD01 = FillArrayTDRandomDoubleNum(arrayTD01, 0, 10);
PrintDoubleArrayTD(arrayTD01);

    #region Degining Methods
        int GetParameters01(string userMsg, string errorMsg)
        {
            while (true)
            {
                Console.Write(userMsg);
                if(int.TryParse(Console.ReadLine(), out int userPam))
                    return userPam;
                Console.WriteLine(errorMsg);
            }
        }
        double[,] CreateTwoDimensionalDoubleArray(int rows, int colums)
        {
            double[,] arrayTD = new double[rows, colums];
            return arrayTD;
        }
        double[,] FillArrayTDRandomDoubleNum(double[,] arrayTD, int minValue, int maxValue)
        {   
            var rand = new Random();
            for (int i = 0; i < arrayTD.GetLength(0); i++) // метод .GetLength(0) определяющий движение цикла по строке двумерного массива
            {
                for (int j = 0; j < arrayTD.GetLength(1); j++) // метод .GetLength(1) определяющий движение цикла по колонке двумерного массива
                {
                    arrayTD[i,j] = Math.Round((rand.NextDouble() * rand.Next(minValue,maxValue + 1)), 1); // Используются методы рандома для дробных чисел и для
                                                                                                     // целых чисел, также используется метод округления, в данном
                                                                                                     // случае указано округлять до 1 знака дроби 
                }
            }
            return arrayTD;
        }
        void PrintDoubleArrayTD(double[,] arrayTD)
        {
            for (int i = 0; i < arrayTD.GetLength(0); i++)
            {
                for (int j = 0; j < arrayTD.GetLength(1); j++)
                {
                    //Console.Write($" {arrayTD[i,j]}");
                    Console.Write(String.Format("{0,3} | ", arrayTD[i,j]));
                }
                Console.WriteLine();
            }
        }
    #endregion
Console.WriteLine();
#endregion

#region Домашняя Задача 50
Console.WriteLine("Задача 50");
// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого
// элемента или же указание, что такого элемента нет.
int count = GetParameters02("Введите значение максимального количества строк и столбцов в массиве -> ", "Ошибка!");
int[,] arrayTD02 = GetRandomArray(count);
PrintArrayTD03(arrayTD02);
int row = GetParameters02("Введите номер искомой строки -> ", "Ошибка!");
int colum = GetParameters02("Введите номер искомого стобца -> ", "Ошибка!");
FindNumInArray(arrayTD02, row, colum);

    #region Degining Methods
        int GetParameters02(string userMsg, string errorMsg)
        {
            while (true)
            {
                Console.Write(userMsg);
                if(int.TryParse(Console.ReadLine(), out int userPam))
                    return userPam;
                Console.WriteLine(errorMsg);
            }
        }
        int[,] GetRandomArray(int count)
        {
            var rnm = new Random();
            int[,] arrayTD = new int[rnm.Next(1,count+1),rnm.Next(1,count+1)];
            for (int i = 0; i < arrayTD.GetLength(0); i++)
            {
                for (int j = 0; j < arrayTD.GetLength(1); j++)
                {
                    arrayTD[i,j] = rnm.Next(0,count+1);
                }                
            }
            return arrayTD;
        }
        void PrintArrayTD03(int[,] arrayTD)
        {
            for (int i = 0; i < arrayTD.GetLength(0); i++)
            {
                for (int j = 0; j < arrayTD.GetLength(1); j++)
                {                    
                    Console.Write(String.Format("{0,3} | ", arrayTD[i,j]));
                }
                Console.WriteLine();
            }
        }
        void FindNumInArray(int[,] arrayTD, int row, int colum)
        {
            int count = 0;
            if(row < arrayTD.GetLength(0) && colum < arrayTD.GetLength(1))
            {
                for (int i = 0; i < arrayTD.GetLength(0); i++)
                {
                    for (int j = 0; j < arrayTD.GetLength(1); j++)
                    {
                        count = arrayTD[row, colum];
                    }
                }
            Console.WriteLine($"Значение элемента по адресу [{row},{colum}] = {count}");
            }
            else
            {
                Console.WriteLine($"Значение элемента по адресу [{row},{colum}] отсутствует");
            }
        }
    #endregion
Console.WriteLine();
#endregion

#region Домашняя Задача 52
Console.WriteLine("Задача 52");
// // Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
int rows03 = GetParameters03("Введите количество строк массива: ","Ошибка!");
int colums03 = GetParameters03("Введите количество столбцов массива: ", "Ошибка!");
int[,] arrayTD03 = CreateTwoDimensionalArray02(rows03, colums03, 0, 10);
PrintArrayTD02(arrayTD03);
double[] result = GetAverageInColumsArray(arrayTD03);
PrintArray(result, colums03);

    #region Degining Methods
        int GetParameters03(string userMsg, string errorMsg)
        {
            while (true)
            {
                Console.Write(userMsg);
                if(int.TryParse(Console.ReadLine(), out int userPam))
                    return userPam;
                Console.WriteLine(errorMsg);
            }
        }
        int[,] CreateTwoDimensionalArray02(int rows, int colums, int minValue, int maxValue)
        {
            int[,] arrayTD = new int[rows, colums];
            for (int i = 0; i < arrayTD.GetLength(0); i++) // метод .GetLength(0) определяющий движение цикла по строке двумерного массива
            {
                for (int j = 0; j < arrayTD.GetLength(1); j++) // метод .GetLength(1) определяющий движение цикла по колонке двумерного массива
                {
                    arrayTD[i,j] = new Random().Next(minValue, maxValue + 1);                    
                }                
            }
            return arrayTD;
        }
        double[] GetAverageInColumsArray(int[,] arrayTD)
        {
            double[] result = new double[arrayTD.GetLength(1)];
            for (int i = 0; i < arrayTD.GetLength(1); i++)
            {
                for (int j = 0; j < arrayTD.GetLength(0); j++)
                {
                    result[i] += arrayTD[j,i];
                }                
                result[i] = Math.Round(result[i] / arrayTD.GetLength(0), 1);
            }
            return result;
        }
        void PrintArrayTD02(int[,] arrayTD)
        {
            for (int i = 0; i < arrayTD.GetLength(0); i++)
            {
                for (int j = 0; j < arrayTD.GetLength(1); j++)
                {
                    Console.Write(String.Format("{0,3} | ", arrayTD[i,j])); // String.Format позволяет "красиво" вывести значения массива                    
                }
                Console.WriteLine();
            }
        }
        void PrintArray(double[] array, int colums)
        {
        Console.Write($" Среднее арифметическое по {colums} колонкам = [{String.Join(" | ", array)}]");            
        }        
    #endregion
Console.WriteLine();
#endregion