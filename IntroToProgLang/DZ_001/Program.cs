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