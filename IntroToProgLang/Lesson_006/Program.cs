Console.Clear();

#region Задача 

    #region Degining Methods
    
    #endregion    
#endregion

// УРОК 6. ЛЕКЦИЯ Как не нужно писать код. Принципы и антипаттерны
#region Правльно написанный код где мы избегаем магических чисел и магических констант 
Console.WriteLine("Код из лекции № 1. Ставим на указанную позицию на экране заданный текст"); 
string caption = "Интенсив C#. Демо текст";
int screenWidthPosition = (Console.WindowWidth - caption.Length) / 2; // получаем в переменную позицию курсора по ширине терминала
int screenHeightPosition = Console.WindowHeight / 2; // получаем в переменную позицию курсора по высоте терминала
DrawText(caption, screenWidthPosition, screenHeightPosition);

    #region Degining Methods
        void DrawText(string message, int left, int top)
        {
            Console.SetCursorPosition(left, top); // определяем положение курсора
            Console.WriteLine(message);
        }
    #endregion
Console.WriteLine();     
#endregion

#region Задача
Console.WriteLine("Код из лекции № 2. Получаем умноженные на 2 координаты из предоставленной строки"); 
// Есть строка в которой находятся координаты или парные координаты точек фигуры. Задача: увеличить 
// каждую из координат ровно в два раза и показать пользователю конечный ответ

//using System.Linq; // берем дополнительный модуль Ling. Помним что using должно предшествовать любым другим элементам
                   // пространства имен кроме объявления внешних псеводнимом. Поэтому в данном случае если хочу 
                   // чтобы эта строка работала - закомментирую весь код выше этой строки
                   // ... хм, и без этого модуля вроде все работает, нахрена брал - не знаю :))

string text = "(1,2) (2,3) (4,6) (6,7)" // технически можем сразу избавится от символов скобки используя метод - .Replace()
              .Replace("(", "")         // в который в качестве первого аргумента "подсунем" открывающую скобку, а в качестве
                                        // второго аргумента - то на что мы эту скобку заменяем
              .Replace(")", "");        // повторяем, но уже с закрывающей скобкой

// далее у нас будет та самая неявная типизация
var data = text.Split(" ")  // у нашей строки есть такой метод - .Split() позволяющий сделать разбивку с учетом 
                            // символа разделителя в данном случае как символ разделитель укажем пробел ... 
               .Select(item => item.Split(',')) // ... дальше мы можем в каждом конкретном элементе можем сделать выборку т.е. по факту
                                                // разбить каждый элемент и получить на основе него массив из двух чисел в строковом
                                                //  представлении т.е. 1-е "число" это будет координата по Х, 2-е "число", координата по У
               .Select(e => (x: int.Parse(e[0]), y: int.Parse(e[1]))) // ... также можем сделать еще одну выборку где мы массив координат
                                                                 //  превратим в кортеж чисел, при этом мы будем делать "разбор строки"
                                                                 //  т.к. на текущем этапе входящие данные это массив строк и заодно сразу
                                                                 // определить координату Х - х: ...
                                                                 // определить координату У - у: ...
               .Where(e => e.x % 2 == 0  // ... при желании можем добавить условие которое проверяет кортеж чисел на факт того что
                        && e.y % 2 == 0) // числа по координатам кратные и делает выборку чисел соответствующих условию                                         
               .Select(point => (point.x * 2, point.y * 2)) // ... далее мы прямо тут можем умножить получившийся кортеж чисел на
                                                            // нужный нам множитель, сейчас это у нас "магическое число" - 2
               .ToArray();  // и сразу же превращаем полученный набор данных в массив кортежей с помощью метода - .ToArray()
for (int i = 0; i < data.Length; i++)
{
    Console.WriteLine(data[i]);     
}

    #region Degining Methods
    
    #endregion
Console.WriteLine();     
#endregion

//УРОК 6. СЕМИНАР. 
#region Задача 39 Преподаватель разобрал задачу
Console.WriteLine("Задача 39. Перевернуть одномерный массив"); 
// Напишите программу, которая перевернет одномерный массив (последний элемент будет на первом месте, а первый на последнем и т.д.)
// Например: [1,2,3,4,5] -> [5,4,3,2,1]
int[] array01 = GetArray(10, 0, 10);
Console.WriteLine(String.Join(" ", array01));

int[] reversArray = GetReversArray01(array01);
Console.WriteLine(string.Join(" ", reversArray));

GetReversArray02(array01);
Console.WriteLine(string.Join(" ", array01));

    #region Degining Methods
        int[] GetArray(int size, int minValue, int maxValue)
        {
            int[] res = new int[size];
            for (int i = 0; i < size; i++)
            {
                res[i] = new Random().Next(minValue, maxValue + 1);
            }
            return res;
        }
        int[] GetReversArray01(int[] array) // 1-й вариант исполнения создания перевернутого массива. Данный вариант целесообразен
                                            // если нам нужно сохранить первоисточник-массив или нам нужна копия
        {
            int[] result = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                result[i] = array[array.Length-1 - i];
            }
            return result;
        }
        void GetReversArray02(int[] array)  // 2-й вариант исполнения создания перевернутого массива. Данный вариант целесообразен
                                            // если нам не нужно сохранять первоисточник и копия не нужна
        {
            for (int i = 0; i < array.Length / 2; i++)
            {
                int temp = array[i];
                array[i] = array[array.Length-1 - i];
                array[array.Length-1 - i] = temp;
            }
        }
    #endregion
    System.Console.WriteLine();
#endregion

#region Задача 40
Console.WriteLine("Задача 40. Может ли существовать треугольник с заданными длинами сторон"); 
// Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
// В помощь: теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.
int userNum01 = ControlInputUserNumber01("Введите первую сторону: ");
int userNum02 = ControlInputUserNumber01("Введите вторую сторону: ");
int userNum03 = ControlInputUserNumber01("Введите третью сторону: ");
bool result01 = CalculateExistenceTrigon(userNum01, userNum02, userNum03);
PrintPesult01(result01);

    #region Degining Methods
        int ControlInputUserNumber01(string userMessage)
        {
            while (true)
            {
                Console.Write(userMessage);
                if(int.TryParse(Console.ReadLine(), out int angleTrigon))
                    return angleTrigon;
                Console.WriteLine("Ошибка! Введите целое число!");
            }
        }
        bool CalculateExistenceTrigon(int angleTrigon01, int angleTrigon02, int angleTrigon03) // метод проверяет теорему о неравенстве треугольника
        {
            return angleTrigon01 < angleTrigon02 + angleTrigon03 && // можно сразу логические выражения писать с командой возвращения
                angleTrigon02 < angleTrigon01 + angleTrigon03 &&
                    angleTrigon03 < angleTrigon01 + angleTrigon02;

        }
        void PrintPesult01(bool result)
        {
            Console.WriteLine(result);
        }    
    #endregion
    System.Console.WriteLine();
#endregion

#region Задача 42
Console.WriteLine("Задача 42. Преобразование десячичного числа в двоичное"); 
// Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// Например: 45 -> 101101
int userNum04 = ControlInputUserNumber02("Введите целое число: ");

string result02 = GetBinaryNum(userNum04);
int num = GetConvert(userNum04);

PrintResult02(result02, num);

    #region Degining Methods
        int ControlInputUserNumber02(string userMessage)
        {
            while (true)
            {
                Console.Write(userMessage);
                if(int.TryParse(Console.ReadLine(), out int angleTrigon))
                    return angleTrigon;
                Console.WriteLine("Ошибка! Введите целое число!");
            }
        }
        // Мой "выстраданный" вариант получение двоичного числа из десятичного
        string GetBinaryNum(int num)
        {   
            // блок получает двоичную последовательность но в перевернутом порядке + мы сознательно добавляем 
            // контрольный начальный знак "1" чтобы можно сделать преобразование в число для дальнейших манипуляций
            string temp = "1";
            while (num != 0)
            {
                temp += num % 2 == 0 ? "0" : "1";
                num /= 2;
            }            
            // блок переворачивает последовательность убирая контрольную начальную цифру 1
            int temp01 = int.Parse(temp);
            string temp02 = String.Empty;
            while (temp01 > 1)
            {
                temp02 += temp01 % 2 == 0 ? "0" : "1";
                temp01 /= 10;
            }
            return temp02;
        }
        // Вариант более красивый от преподавателя (который знает математику) перевода десятичного числа в двоичное
        int GetConvert(int num)
        {
            int p = 0; // это номер степени
            int result = 0; // переменная будет накапливать ответ
            while (num > 0)
            {
                result += num % 2 * (int) Math.Pow(10, p); // сделали прямое приведение вещественного числа к целому
                num /= 2;
                p ++;
            }
            return result;
        }        
        void PrintResult02(string num01 = "None", int num02 = -1) // завел необязательные параметры
        {
            if(num01 != "None")
                Console.WriteLine($"Десятичное целое число - {userNum04} преобразовано в двоичное - {num01}. Мой вариант :))");
            if(num02 != -1)
                Console.WriteLine($"Десятичное целое число - {userNum04} преобразовано в двоичное - {num01}. Вариант препода!!!");                
        }        
    #endregion
    System.Console.WriteLine();
#endregion

#region Задача 44
Console.WriteLine("Задача 44. Вывод чисел Фибоначи не используя рекурсию"); 
// Не используя рекурсию, выведите первые N чисел Фибонначи. Дано: первые два числа Фибонначи: 0 и 1.
// Например:
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8
int lengthArray = ControlUserinput("Введите диапазон Фибаначи: ");
int[] arrayFibbonachi = CreateArrayFibbonachi(lengthArray);
PrintResult03(arrayFibbonachi);

    #region Degining Methods
        int ControlUserinput(string userMessage)
        {
            while (true)
            {
                Console.Write(userMessage);
                if(int.TryParse(Console.ReadLine(), out int lehgthArray))
                    return lehgthArray;
                System.Console.WriteLine("Ошибка! Введите целое число!");
            }
        }
        int[] CreateArrayFibbonachi(int lehgthArray)
        {
            int[] array = new int[lehgthArray];
            array[0] = 0;
            array[1] = 1;
            for (int i = 2; i < array.Length; i++)
            {
                array[i] = array[i-1] + array[i-2];
            }
            return array;
        }
        void PrintResult03(int[] array)
        {
            Console.WriteLine($"Числа Фибоначи - {String.Join(",", array)}");                        
        }
    #endregion
    Console.WriteLine();
#endregion

#region Задача 45
Console.WriteLine("Задача 45. Создаем копию массива с помощью поэлементного копирования"); 
// Напишите программму, которая будет создавать копию заданного массива с помощью поэлементного копирования.
int[] testArray = {1,6,12,15,22,17,56};
int[] copyArray = GetCopyOfArray(testArray);
PrintArray01(copyArray);

    #region Degining Methods
    int[] GetCopyOfArray(int[] array)
    {
        int[] newArray = new int[array.Length];
        for (int i = 0; i <array.Length; i++)
        {
            newArray[i] = array[i];
        }
        return newArray;
    }
    void PrintArray01(int[] array)
    {
        Console.WriteLine($"Копия массива - {String.Join(",", array)}");        
    }
    #endregion
    Console.WriteLine();
#endregion

#region Домашняя задача 41
Console.WriteLine("Домашняя задача 41"); 
// Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввел пользователь.
// Например: 0,7,8,-2,-2 -> 2
int length = Prompt01("Введите количество элементов > ");
int[] array02 = InputArray(length);
PrintArray02(array02);
Console.WriteLine($"Количество чисел больше 0 - {CountPositiveNumbers(array02)}");

    #region Degining Methods
    int Prompt01(string message)
    {
        Console.Write(message);
        string value = Console.ReadLine() ?? "";
        int result = Convert.ToInt32(value);
        return result;
    }
    int[] InputArray(int length)
    {
        int[] array = new int[length];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = Prompt01($"Введите {i + 1}-й элемент > ");
        }
        return array;
    }
    void PrintArray02(int[] array)
    {
        Console.WriteLine($"Получившийся массив - [{String.Join(",", array)}]");
    }
    int CountPositiveNumbers(int[] array)
    {
        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if(array[i] > 0)
                count++;
        }
        return count;
    }
    #endregion
    Console.WriteLine();
#endregion

#region Домашняя задача 43
Console.WriteLine("Домашняя задача 43"); 
// Напишите программу, которая найдет точку пересечения двух прямых, заданных уравнениями:
// у = к1 * х + b1
// у = к2 * х + b2
// Значения k1 b1 k2 b2 задаются пользователем
// Например: k1=5 b1=2 k2=9 b2=4 -> (-0,5; -0,5)
const int COEFFICIENT = 0;
const int CONSTANT = 1;
const int X_COORD = 0;
const int Y_COORD = 1;
const int LINE1 = 1;
const int LINE2 = 2;

double[] lineData1 = InputLineData(LINE1);
double[] lineData2 = InputLineData(LINE2);

if(ValidateLines(lineData1, lineData2))
{
    double[] coord = FindCoords(lineData1, lineData2);
    Console.Write($"Точка пересечений уравнений у={lineData1[COEFFICIENT]} * x + {lineData1[CONSTANT]} и у={lineData2[COEFFICIENT]} * x + {lineData2[CONSTANT]} ");
    Console.WriteLine($" имеет координаты ({coord[X_COORD]},{coord[Y_COORD]})");}

    #region Degining Methods
    // Ввод числа
    double Prompt02(string message)
    {
        Console.Write(message);
        string value = Console.ReadLine() ?? "";
        double result = Convert.ToDouble(value); // преобразуем строку в вещественное число
        return result;
    }
    // Ввод данных по прямой
    double[] InputLineData(int numberOfLine)
    {
        double[] lineData =new double[2];
        lineData[COEFFICIENT] = Prompt02($"Введите коэффициен для {numberOfLine} прямой > ");
        lineData[CONSTANT] = Prompt02($"Введите константу для {numberOfLine} прямой > ");
        return lineData;
    }
    // Поиск координат
    double[] FindCoords(double[] lineData1, double[] lineData2)
    {
        double[] coord = new double[2];
        coord[X_COORD] =    (lineData1[CONSTANT] - lineData2[CONSTANT]) / 
                            (lineData2[COEFFICIENT] - lineData1[COEFFICIENT]);
        coord[Y_COORD] = lineData1[CONSTANT] * coord[X_COORD] + lineData1[CONSTANT];
        return coord;
    }
    bool ValidateLines(double[] lineData1, double[] lineData2)
    {
        if(lineData1[COEFFICIENT] == lineData2[COEFFICIENT])
        {
            if(lineData1[CONSTANT] == lineData2[CONSTANT])
            {
                Console.WriteLine("Прямые совпадают");
                return false;
            }
            else
            {
                Console.WriteLine("Прямые параллельны");
                return false;
            }
        }
        return true;
    }
    #endregion    
    Console.WriteLine();
#endregion