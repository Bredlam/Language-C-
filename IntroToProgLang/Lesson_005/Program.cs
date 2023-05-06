Console.Clear();

#region Задача 

    #region Degining Methods
    
    #endregion    
#endregion

// УРОК 5. ЛЕКЦИЯ
// На уроке была теория о том как правильно писать код с точки зрения чистоты кода и общепринятых правил при взаимодействии
// программистов. Суть - код читается чаще чем пишется поэтому писать нужно так чтобы читать было легко.

// УРОК 5. СЕМИНАР
#region Задача 31 Преподаватель разобрал задачу
// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
// Найдите сумму отрицательных и положительных элементов массива.
// По этой задаче преподаватель пытался донести мысль, что нужно стараться инструкции выводить в методы т.к.
// работа с методами дает больше возможстей при дальнейшем изменении кода по сравнению с тем если нам
// придется работать с некими командами привязанными например к определенным классам напрямую. В качестве примера
// я создал два метода и перенес туда инструкции печати массива и вычислений из массива

int[] array01 = GetArray01(12, -9, 9);
PrintArray01(array01);
int positiveSum = GetPositiveSum(array01);
int negativeSum = GetNegativeSum(array01);
PrintNegativeAndPositiveSumOfArray(positiveSum, negativeSum);

    #region Defining Methods
    // Метод возвращает массив заполенный случайными числами
    int[] GetArray01(int size, int minValue, int maxValue)
    {
        int[] res = new int[size]; // Cоздаем массив и размер массива определяем входящим аргументом

        for (int i = 0; i < size; i++)
        {
            res[i] = new Random().Next(minValue, maxValue + 1); // Класс Random() и его метод .Next
        }
        return res;
    }

    // Метод вычисляет сумму положительных чисел в массиве и возвращает получившийся результат
    int GetPositiveSum(int[] array)
    {
        int positiveSum = 0;
        foreach (int element in array)  // foreach (пер."для каждого") - удобно использовать этот цикл когда нет нужды 
                                        // привязываться к индексам, но нужно перебрать все элементы коллекции. Также 
                                        // этот цикл работает только на считывание т.е. не позволяет изменить коллекцию.
        {
            if (element > 0) positiveSum += element;
        }
        return positiveSum;

    }

    // Метод вычисляет сумму отрицательных чисел в массиве и возвращает получившийся результат
    int GetNegativeSum(int[] array)
    {
        int negativeSum = 0;
        foreach (int element in array)
        {
            negativeSum += element < 0 ? element : 0;   // тут мы используем тернарный оператор, если element < 0 то            
                                                        // вернется ИСТИНА т.е. element
                                                        // иначе вернется ЛОЖЬ т.е. 0
        }
        return negativeSum;
    }

    // Метод выводит на печать массив. По рекомендации преподавателя иструкция была обернута в метод
    void PrintArray01(int[] array)
    {
        Console.WriteLine(String.Join(" ", array)); // Используя метод .Join из класса String мы можем вывести значения массива передав
                                                    // массив в метод в качестве второго аргумента, а первым аргументом у нас выступает
                                                    // разделитель " " т.е. пробел в нашем случае
    }

    // Метод выводит на печать результат вычислений. По рекомендации преподавателя инструция была обернута в метод
    void PrintNegativeAndPositiveSumOfArray(int positiveSum, int negativeSum)
    {
        Console.WriteLine($"Positive sum = {positiveSum}, Negative sum = {negativeSum} ");
        Console.WriteLine("Задача 31. Разобрали с преподавателем");
        Console.WriteLine();
    }
    #endregion
#endregion

#region Задача 32
// Напишите программу замены элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот
// Например: [-4,-8,8,2] -> [4,8,-8,-2]
int[] array02 = {-6,-8,8,2};
int[] array03 = ReversingPolarityOfNumbersInArray(array02);
PrintArray02(array03);

    #region Degining Methods
        int [] ReversingPolarityOfNumbersInArray(int [] array)
        {            
            for (int i = 0; i < array.Length; i++)
            {
                array[i] *= -1;
            }
            return array;
        }

        void PrintArray02(int[] array)
        {
            Console.WriteLine("Перевернутый массив");
            Console.WriteLine(String.Join(",", array));
            Console.WriteLine("Задача 32.");
            Console.WriteLine();
        }            
    #endregion
#endregion

#region Задача 33
// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// Например: 4; массив [6,7,19,345,3] -> нет
// Мои добавления/уточнения к задаче:
// - проверяемое число задает пользователь
// - массив генерируется рандомно
// У меня получился какой-то лотерейный автомат - повезет ли или не повезет.
int userNum = UserInputNumber();
int[] array04 = GenerateRandomArray01();
bool result01 = FoundNumberInArray(userNum, array04);
PrintResult01(result01, array04);

    #region Degining Methods
        int UserInputNumber()
        {
            while (true)
            {
                Console.Write("Введите число которое надо найти в массиве: ");
                if(int.TryParse(Console.ReadLine(), out int userUnput)) return userUnput;
            }
        }
        int[] GenerateRandomArray01()
        {
            var tempRandom = new Random();
            int[] array = new int[tempRandom.Next(5,11)]; // Создали массив с рандомной длиной в диапазоне [5,11)
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = tempRandom.Next(1,100);
            }
            return array;
        }
        bool FoundNumberInArray(int num, int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if(array[i] == num) return true;                
            }
            return false;
        }
        void PrintResult01(bool result, int[] array)
        {
            Console.WriteLine($"[{String.Join(",", array)}] -> {result}");
            Console.WriteLine("Задача 33.");
            Console.WriteLine();
        }            
    #endregion
#endregion

#region Задача 35
// Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке
// [10,99]. Например: [5,18,123,6,2] -> 1 
int[] array05 = GenerateRandomArray02();
int result02 = FoundRangeOfNumberInArray(array05);
PrintResult02(result02, array05);

    #region Degining Methods
        int [] GenerateRandomArray02()
        {
            int[] array = new int[10]; // По задаче длина массива 123, но я поставил поменьше чтобы можно было посмотреть содержимое
                                        // массива
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = new Random().Next(1,1000);
            }
            return array;
        }
        int FoundRangeOfNumberInArray(int[] array)
        {
            int collector = 0;
            foreach (int el in array)
            {
                collector += el > 9 && el < 100 ? 1 : 0;
            }
            return collector;
        }
        void PrintResult02(int result, int[] array)
        {
            Console.WriteLine($"Массив: [{String.Join(",", array)}] Количество элементов в массиве -> {result}");
            Console.WriteLine("Задача 35.");
            Console.WriteLine();
        }
    #endregion
#endregion

#region Задача 37
// Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.
// Результат запишите в новом массиве. Например: [1,2,3,4,5] -> [5,8,3]
int[] array06 = {1,2,3,4,5,6,7};
int[] array07 = ProductOfArrayNumbers(array06);
PrintArray03(array07);

    #region Degining Methods
    int[] ProductOfArrayNumbers(int[] array)
    {
        int lehgthArray = array.Length % 2 == 0 ? array.Length / 2 : (array.Length + 1) / 2;
        int[] arrayResult = new int[lehgthArray];
        if(array.Length % 2 == 0)
            for (int i = 0; i < lehgthArray; i++)
            {
                arrayResult[i] = array[i] * (array[array.Length-1] - i);
            }
        else
        {
            for (int i = 0; i < lehgthArray-1; i++)
            {
                arrayResult[i] = array[i] * (array[array.Length-1] - i);
            }
            arrayResult[lehgthArray-1] = array[lehgthArray-1];
        }
        return arrayResult;
    }
    void PrintArray03(int[] array)
    {
        Console.WriteLine($"{String.Join(",", array)}");
        Console.WriteLine("Задача 37.");
        Console.WriteLine();
    }
            
    #endregion
#endregion

#region Домашняя задача 34
// Задайте массив заполненный случайными положительными трехзначными числами. Напишите программу, которая покажет количество четных
// чисел в массиве. Например: [345, 897, 568, 234] -> 2

    #region Degining Methods
        
    #endregion
#endregion

#region Домашняя задача 36
// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечетных позициях.
// Например: [3,7,23,12] -> 19
    
    #region Degining Methods
        
    #endregion
#endregion

#region Домашняя задача 38
// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// Например: [3,7,22,2,78] -> 76
    
    #region Degining Methods
        
    #endregion
#endregion

#region Задача 

    #region Degining Methods
    
    #endregion    
#endregion