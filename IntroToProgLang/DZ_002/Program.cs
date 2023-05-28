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