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