Console.Clear();
#region Домашняя задача 34
// Задайте массив заполненный случайными положительными трехзначными числами. Напишите программу, которая покажет количество четных
// чисел в массиве. Например: [345, 897, 568, 234] -> 2

int[] userArray = CreateArrayWithThreeDigitNum("Задайте диапазон массива: ", "Ошибка! Укажите целое число.");

int amountEvenNum = FoundEvenNumbersInArray(userArray);

PrintResult(amountEvenNum, userArray);

    #region Degining Methods
        int[] CreateArrayWithThreeDigitNum(string userMessage, string errorMsg)
        {
            while (true)
            {
                Console.Write(userMessage);
                if(int.TryParse(Console.ReadLine(), out int lengthArray))
                {
                    int[] array = new int[lengthArray];
                    for (int i = 0; i < array.Length; i++)
                    {
                        array[i] = new Random().Next(100, 1000);
                    }
                    return array;
                }
                Console.WriteLine(errorMsg);
            }          
        }
        int FoundEvenNumbersInArray(int[] array)
        {
            int collectorNumbers = 0;
            foreach (int element in array)
            {
                collectorNumbers += element % 2 == 0 ? 1 : 0;
            }
            return collectorNumbers;
        }
        void PrintResult(int amountEvenNum, int[] array) 
        {
            Console.WriteLine($"В указанном массиве [{String.Join(",", array)}] четных чисел - {amountEvenNum}");
        }
    #endregion
#endregion
