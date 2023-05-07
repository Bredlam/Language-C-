#region Домашняя задача 36
// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечетных позициях.
// Например: [3,7,23,12] -> 19
    int[] userArray = NewRandomArray("Введите диапазон массива: ", "Ошибка! Введите целое число!");
    int sumOdd = CalculateSummOddPushFromIndex(userArray);
    PrintResult(sumOdd, userArray);

    #region Degining Methods
        int[] NewRandomArray(string userMessage, string errorMsg)
        {
            while (true)
            {
                Console.Write(userMessage);
                if(int.TryParse(Console.ReadLine(), out int lengthArray))
                {
                    int[] array = new int[lengthArray];
                    for (int i = 0; i < array.Length; i++)
                    {
                        array[i] = new Random().Next(1, 20);
                    }
                return array;
                }
                Console.WriteLine(errorMsg);                
            }
        }
        int CalculateSummOddPushFromIndex(int[] array)
        {
            sumOdd = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sumOdd += i % 2 != 0 ? array[i] : 0;
            }
            return sumOdd;
        }
        void PrintResult(int sumOdd, int[] array)
        {
            Console.WriteLine($"В указанном массиве [{String.Join(",", array)}] сумма элементов находящихся на нечетных индексах равна {sumOdd}");
        }
    #endregion
#endregion