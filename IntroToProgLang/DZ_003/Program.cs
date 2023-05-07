#region Домашняя задача 38
// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементами массива.
// Например: [3,7,22,2,78] -> 76
    double[] userArray = CreateDoubleArray("Задайте длину массива: ", "Ошибка! Введите целое число!");
    double minDiffMax = FoundDifferenceBetweenMinMaxInArray(userArray);
    PrintResult(minDiffMax, userArray);

    #region Degining Methods
        double[] CreateDoubleArray(string userMessage, string errorMsg)
        {
            while (true)
            {
                Console.Write(userMessage);
                if(int.TryParse(Console.ReadLine(), out int lengthArray))
                {
                    double[] array = new double[lengthArray];
                    var rand = new Random();
                    for (int i = 0; i < array.Length; i++)
                    {
                        array[i] = Math.Round(rand.NextDouble() * rand.Next(1,20));
                    }
                    return array;
                }
                Console.WriteLine(errorMsg);
            }
        }
        double FoundDifferenceBetweenMinMaxInArray(double[] array)
        {
            double min = array[0], max = array[0], result = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if(array[i] > max) max = array[i];
                if(array[i] < min) min = array[i];
            }
            result = max - min;
            return result;
        }
        void PrintResult(double minDiffMax, double[] array)
        {
            Console.WriteLine($"В массиве [{String.Join(",", array)}] разница между максимальным и минимальным значениями = {minDiffMax}");
        }
    #endregion
#endregion