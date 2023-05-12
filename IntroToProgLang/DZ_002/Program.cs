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
                Console.WriteLine($"Значение элемента по адресу [{row},{colum}] отсутствует т.к. адрес выходит за пределы массива");
            }
        }
    #endregion
Console.WriteLine();
#endregion