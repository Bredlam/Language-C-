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