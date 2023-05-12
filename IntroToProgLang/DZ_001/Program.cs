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