Console.Clear();

#region Задача 

    #region Degining Methods
    
    #endregion
#endregion

// УРОК 8. ЛЕКЦИЯ. 

// УРОК 8. СЕМИНАР. Двумерные массивы. Продолжение
// Не забудь что некоторые методы которые я написал общие для нескольких задач. Сделано для того чтобы не повторяться.
#region Задача № 53
Console.WriteLine("Задача 53");
// Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.
int rows = GetParameters("Введите количество строк в массиве -> ","Ошибка ввода! ");
int colums = GetParameters("Введите количество столбцов в массиве -> ","Ошибка ввода! ");
int[,] arrayTD = CreateRandomArray(rows, colums, 1, 9);
PrintArray(arrayTD);
int[,] editArrayTD = ChangeFirstLastRows(arrayTD);
PrintArray(editArrayTD);

    #region Degining Methods
        int GetParameters(string userMessage, string errorMsg)
        {
            while (true)
            {
                Console.Write(userMessage);
                if(int.TryParse(Console.ReadLine(), out int rows)) 
                    return rows;
                Console.WriteLine(errorMsg);
            }
        }
        int[,] CreateRandomArray(int rows, int colums, int minValue, int maxValue)
        {
            var rnd = new Random();
            int[,] array = new int[rows, colums];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i,j] = rnd.Next(minValue, maxValue + 1);
                }
            }
            return array;
        }
        int[,] ChangeFirstLastRows(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    int temp = array[0,j];
                    array[0,j] = array[array.GetLength(0)-1,j];
                    array[array.GetLength(0)-1,j] = temp;
                }
            }
            return array;
        }
        void PrintArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(String.Format("{0,3}", array[i,j]));
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    #endregion
Console.WriteLine();
#endregion

#region Задача № 55
Console.WriteLine("Задача 55");
// Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, если это
// невозможно, программа должна вывести сообщение для пользователя.
int[,] turnOutArray = ArrayTurnOut(editArrayTD);
PrintArray(turnOutArray);

    #region Degining Methods
        int[,] ArrayTurnOut(int[,] array)
        {
            int[,] newArray = new int[array.GetLength(1), array.GetLength(0)];
            for (int i = 0; i < newArray.GetLength(1); i++)
            {
                for (int j = 0; j < newArray.GetLength(0); j++)
                {
                    newArray[j,i] = array[i,j];
                }
            }
            return newArray;
        }
    #endregion
Console.WriteLine();
#endregion

#region Задача № 57
Console.WriteLine("Задача 57");
// Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том,
// сколько раз встречается элемент входных данных.

    #region Degining Methods

    #endregion
Console.WriteLine();
#endregion

#region Задача № 59
Console.WriteLine("Задача 53");
// Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, на пересечении
// которых расположен наименьший элемент массива.

    #region Degining Methods

    #endregion
Console.WriteLine();
#endregion

#region Задача № 61
Console.WriteLine("Задача 61");
// Вывести первые N строк треугольника Паскаля. Сделать вывод в виде равнобедренного треугольника.

    #region Degining Methods

    #endregion
Console.WriteLine();
#endregion

#region Домашняя задача № 54
Console.WriteLine("Домашняя задача № 54");
// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

    #region Degining Methods

    #endregion
Console.WriteLine();
#endregion

#region Домашняя задача № 56
Console.WriteLine("Домашняя задача № 56");
// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

    #region Degining Methods

    #endregion
Console.WriteLine();
#endregion

#region Домашняя задача № 58
Console.WriteLine("Домашняя задача № 58");
// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц

    #region Degining Methods

    #endregion
Console.WriteLine();
#endregion

#region Домашняя задача № 60
Console.WriteLine("Домашняя задача № 60");
// Сформируйте трехмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет
// построчно выводить массив, добавляя индексы каждого элемента

    #region Degining Methods

    #endregion
Console.WriteLine();
#endregion

#region Домашняя задача № 62
Console.WriteLine("Домашняя задача № 62");
// Заполните спирально массив 4 на 4

    #region Degining Methods

    #endregion
Console.WriteLine();
#endregion