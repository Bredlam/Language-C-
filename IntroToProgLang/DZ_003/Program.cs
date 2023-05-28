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