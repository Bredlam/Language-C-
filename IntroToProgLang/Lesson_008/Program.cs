Console.Clear();

#region Задача 

    #region Degining Methods
    
    #endregion
#endregion

// // УРОК 8. ЛЕКЦИЯ. 

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
                if (i != 0) break; // отсечка для того чтобы не проходить лишний раз циклы
                {                        
                    for (int j = 0; j < array.GetLength(1); j++)
                    {                            
                        int temp = array[i,j];
                        array[i,j] = array[array.GetLength(0)-1,j];
                        array[array.GetLength(0)-1,j] = temp;
                    }
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
int[,] getFreqArray = GetFrecquency(turnOutArray);
PrintArray(getFreqArray);

    #region Degining Methods
        int FindMinInArray(int[,] array)
        {
            int result = array[0,0];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if(result > array[i,j]) result = array[i,j];
                }
            }
            return result;
        }
        int FindMaxInArray(int[,] array)
        {
            int result = array[0,0];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if(result < array[i,j]) result = array[i,j];
                }
            }
            return result;
        }
        int FindNumberCount(int[,] array, int numAraay)
        {
            int num = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if(numAraay == array[i,j]) num ++;
                }
            }
            return num;
        }
        int[,] GetFrecquency(int[,] array)
        {   
            int min = FindMinInArray(array);
            int max = FindMaxInArray(array);
            int[,] newArray = new int[max - min + 1, 2];
            for (int i = 0; i < newArray.GetLength(0); i++)
            {
                newArray[i,0] = min;
                min ++;
                newArray[i,1] = FindNumberCount(array, newArray[i,0]);
            }
            return newArray;
        }        
    #endregion
Console.WriteLine();
#endregion

#region Задача № 59
Console.WriteLine("Задача 59");
// Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, на пересечении
// которых расположен наименьший элемент массива.

    #region Degining Methods
        
    #endregion
//Console.WriteLine();
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
int rows01 = GetParameters01("Введите количество строк в массиве -> ","Ошибка ввода! ");
int colums01 = GetParameters01("Введите количество столбцов в массиве -> ","Ошибка ввода! ");
int[,] arrayTD01 = CreateRandomArray01(rows01, colums01, 1, 9);
PrintArray01(arrayTD01);
int[,] resultArray = GetminMaxArray(arrayTD01);
PrintArray01(resultArray);

    #region Degining Methods
        int GetParameters01(string userMessage, string errorMsg)
        {
            while (true)
            {
                Console.Write(userMessage);
                if(int.TryParse(Console.ReadLine(), out int usr)) 
                    return usr;
                Console.WriteLine(errorMsg);
            }
        }
        int[,] CreateRandomArray01(int rows, int colums, int minValue, int maxValue)
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
        int[,] GetminMaxArray(int[,] array)
        {
            int temp = array[0,0];                        
            Restart:
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    // если включить эту часть кода то упорядочен будет весь массив 
                    // if(i < array.GetLength(0)-1 && array[i,array.GetLength(1)-1] < array[i+1,0])
                    // {
                    //     temp = array[i,array.GetLength(1)-1];
                    //     array[i,array.GetLength(1)-1] = array[i+1,0];
                    //     array[i+1,0] = temp;
                    //     goto Restart;   
                    // } 
                    for (int j = 0; j < array.GetLength(1)-1; j++)
                    {                        
                        if(array[i,j] < array[i,j+1])
                        {                            
                            temp = array[i,j+1];
                            array[i,j+1] = array[i,j];
                            array[i,j] = temp;
                            goto Restart;
                        }                        
                    }
                }            
            return array; 
                      
        }
        void PrintArray01(int[,] array)
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

#region Домашняя задача № 56
Console.WriteLine("Домашняя задача № 56");
// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
int userNum = GetParameters02("Введите число которое определит количество строк и столбцов в массиве -> ","Ошибка ввода! ");
int[,] arrayTD02 = CreateRandomArray02(userNum, 1, 9);
int[] columSum = FindColumSummArray(arrayTD02);
int resColum = FindColumMinSum(columSum);
PrintArray02(arrayTD02, columSum);
Console.WriteLine($"Строка {resColum} с минимальной суммой");

    #region Degining Methods
        int GetParameters02(string userMessage, string errorMsg)
        {
            while (true)
            {
                Console.Write(userMessage);
                if(int.TryParse(Console.ReadLine(), out int usr)) 
                    return usr;
                Console.WriteLine(errorMsg);
            }
        }
        int[,] CreateRandomArray02(int num, int minValue, int maxValue)
        {
            var rnd = new Random();
            int[,] array = new int[num, num];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i,j] = rnd.Next(minValue, maxValue + 1);
                }
            }
            return array;
        }
        int[] FindColumSummArray(int[,] array)
        {
            int[] columsSumArray = new int [array.GetLength(0)];            
            for (int i = 0; i < array.GetLength(0); i++)
            {                
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    columsSumArray[i] += array[i,j];
                }                     
            }            
            return columsSumArray;
        }
        int FindColumMinSum(int[] array)
        {
            int colum = Array.IndexOf(array, array.Min());
            return colum;
        }
        void PrintArray02(int[,] arrayTD, int[] array)
        {
            for (int i = 0; i < arrayTD.GetLength(0); i++)
            {
                Console.Write($"{i}: sum {array[i]} <--");
                for (int j = 0; j < arrayTD.GetLength(1); j++)
                {
                    Console.Write(String.Format("{0,3}", arrayTD[i,j]));
                }
                Console.WriteLine();            
            }
            Console.WriteLine();
        }
    #endregion
Console.WriteLine();
#endregion

#region Домашняя задача № 58
Console.WriteLine("Домашняя задача № 58");
// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц
// Матричное произведение. Каждый элемент результирующей матрицы равен сумме произведений элементов исходных матриц
int [,] firstMatrix = GetMatrixFromConsole("1-й матрицы", 1, 9);
int [,] secondMatrix = GetMatrixFromConsole("2-й матрицы", 1, 9);
int [,] resultMatrix  = GetProductUsersMatrix(firstMatrix, secondMatrix);
PrintArray04(firstMatrix);
PrintArray04(secondMatrix);
PrintArray04(resultMatrix);

    #region Degining Methods
        int[,] GetMatrixFromConsole(string name, int minValue, int maxValue)
        {
            Console.Write($"Количество строк матрицы {name} -> ");
            int n = int.Parse(Console.ReadLine() ?? "");
            Console.Write($"Количество столбцов матрицы {name} -> ");
            int m = int.Parse(Console.ReadLine() ?? "");
    
            var matrix = new int[n, m];
            for (var i = 0; i < n; i++)
            {
                for (var j = 0; j < m; j++)
                {                
                    matrix[i, j] = new Random().Next(minValue, maxValue + 1);
                }
            }
    
            return matrix;
        }
        int[,] GetProductUsersMatrix(int[,] array01, int[,] array02)
        {
            if(array01.GetLength(1) != array02.GetLength(0))
            {
                throw new Exception("Умножение не возможно. Число столбцов матрицы 1 не совпадает с числом строк матрицы 2");
                
            }
            int[,] resArray = new int[array01.GetLength(0), array02.GetLength(1)];
            for (int i = 0; i < array01.GetLength(0); i++)
            {
                for (int j = 0; j < array02.GetLength(1); j++)
                {
                    resArray[i,j] = 0;
                    for (int q = 0; q < array01.GetLength(1); q++)
                    {
                        resArray[i,j] += array01[i,q] * array02[q,j];
                    }
                }                
            }
            return resArray;
        }
        void PrintArray04(int[,] arrayTD)
        {
            for (int i = 0; i < arrayTD.GetLength(0); i++)
            {                
                for (int j = 0; j < arrayTD.GetLength(1); j++)
                {
                    Console.Write(String.Format("{0,3}", arrayTD[i,j]));
                }
                Console.WriteLine();            
            }
            Console.WriteLine();
        }
    #endregion
Console.WriteLine();
#endregion

#region Домашняя задача № 60
Console.WriteLine("Домашняя задача № 60");
// Сформируйте трехмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет
// построчно выводить массив, добавляя индексы каждого элемента.
// Генерировать число, проверять есть ли оно уже и если есть то перегенерировать новое число.
int sizeArray = GetParameters04("Введите размер трехмерного массива (не больше 4) -> ", "Ошибка! ");
int [,,] arrayNonRepeatNum = CreateRandomArray03(sizeArray, 10, 100);
PrintArray03(arrayNonRepeatNum);

    #region Degining Methods
        int GetParameters04(string userMessage, string errorMsg)
        {
            while (true)
            {
                Console.Write(userMessage);
                if(int.TryParse(Console.ReadLine(), out int usr))  
                    if(usr <= 4) return usr;
                Console.WriteLine(errorMsg);
            }
        }
        int[,,] CreateRandomArray03(int num, int minValue, int maxValue)
        {
            var rnd = new Random();
            int contains = 0;
            int[,,] array = new int[num, num, num];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    for (int q = 0; q < array.GetLength(2); q++)
                    {                        
                        while (FindRepitValue(array, contains))
                        {
                            contains = rnd.Next(minValue, maxValue + 1);                            
                        }   
                        array[i,j,q] = contains;                        
                    }                    
                }
            }
            return array;
        }
        bool FindRepitValue(int[,,] array, int findNum)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    for (int q = 0; q < array.GetLength(2); q++)
                    {
                        if(array[i,j,q] == findNum) return true;
                    }
                }
            }
            return false;            
        }
        void PrintArray03(int[,,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {                
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    for (int q = 0; q < array.GetLength(2); q++)
                    {
                        Console.Write($"{String.Format("{0,4}", array[i,j,q])} :({i},{j},{q})");
                    }                    
                    Console.WriteLine();
                }
                Console.WriteLine();
            }            
        }
    #endregion
Console.WriteLine();
#endregion

#region Домашняя задача № 62
Console.WriteLine("Домашняя задача № 62");
// Заполните спирально массив 4 на 4 (улитка)
int userNum01 = GetParameters05("Введите число которое определит количество строк и столбцов в массиве -> ","Ошибка ввода! ");
int startValue = GetParameters05("Введите число которое начальное значение чисел в массиве (голову улитки) -> ","Ошибка ввода! ");
int[,] evidence = CreateSpiralArray(userNum01, startValue);
 PrintArray05(evidence);
        
    #region Degining Methods
        int GetParameters05(string userMessage, string errorMsg)
        {
            while (true)
            {
                Console.Write(userMessage);
                if(int.TryParse(Console.ReadLine(), out int usr)) 
                    return usr;
                Console.WriteLine(errorMsg);
            }
        }
        int[,] CreateSpiralArray(int num, int startValue)
        {
            int row02 = num;
            int colums02 = num;
            int stV = startValue;            
            int[,] array = new int[row02,colums02]; 
            //Заполняю внешний перимерт
            for (int j = 0; j < colums02; j++) 
            {
                array[0,j] = stV;
                stV++;
            }
            for (int i = 1; i < row02; i++) 
            {
                array[i,colums02-1] = stV;
                stV++;
            }
            for (int j = colums02 - 2; j >= 0; j--) 
            {
                array[row02-1,j] = stV;
                stV++;
            }
            for (int i = row02 - 2; i > 0; i--) 
            {
                array[i,0] = stV;
                stV++;
            }
 
            // Внешний периметр заполнен, определяю внутренний периметр
            int c = 1;
            int d = 1;
 
            while (stV < row02 * colums02) 
            { 
                //Движение вправо
                while (array[c,d+1] == 0) 
                {
                    array[c, d] = stV;
                    stV++;
                    d++;
                } 
                // Движение вниз
                while (array[c+1,d] == 0) 
                {
                    array[c,d] = stV;
                    stV++;
                    c++;
                } 
                // Движение влево
                while (array[c,d-1] == 0) 
                {
                    array[c,d] = stV;
                    stV++;
                    d--;
                } 
                // Движение вверх
                while (array[c-1,d] == 0) 
                {
                    array[c,d] = stV;
                    stV++;
                    c--;
                }
            } 
            // Решаю проблему центральной незаполненной ячейки
            for (int i = 0; i < row02; i++) 
            {
                for (int j = 0; j < colums02; j++) 
                {
                    if (array[i,j] == 0) 
                    {
                        array[i,j] = stV;
                    }
                }
            }
            return array;
        }
        void PrintArray05(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++) 
            {
                for (int j = 0; j < array.GetLength(1); j++) 
                {
                    Console.Write(String.Format("{0,3}", array[i,j]));                    
                }
                Console.WriteLine("");
            }
        }
    #endregion
Console.WriteLine();
#endregion