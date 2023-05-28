Console.WriteLine("Домашняя задача № 62");
// Заполните спирально массив 4 на 4 (улитка)
int userNum01 = GetParameters05("Введите число которое определит количество строк и столбцов в массиве -> ","Ошибка ввода! ");
int startValue = GetParameters05("Введите число которое начальное значение чисел в массиве (голову улитки) -> ","Ошибка ввода! ");
int[,] evidence = CreateSpiralArray(userNum01, startValue);
 PrintArray05(evidence);
        
    #region Degining Methods
        int GetParameters05(string userMessage, string errorMsg)
        {
            while (true)
            {
                Console.Write(userMessage);
                if(int.TryParse(Console.ReadLine(), out int usr)) 
                    return usr;
                Console.WriteLine(errorMsg);
            }
        }
        int[,] CreateSpiralArray(int num, int startValue)
        {
            int row02 = num;
            int colums02 = num;
            int stV = startValue;            
            int[,] array = new int[row02,colums02]; 
            //Заполняю внешний перимерт
            for (int j = 0; j < colums02; j++) 
            {
                array[0,j] = stV;
                stV++;
            }
            for (int i = 1; i < row02; i++) 
            {
                array[i,colums02-1] = stV;
                stV++;
            }
            for (int j = colums02 - 2; j >= 0; j--) 
            {
                array[row02-1,j] = stV;
                stV++;
            }
            for (int i = row02 - 2; i > 0; i--) 
            {
                array[i,0] = stV;
                stV++;
            }
 
            // Внешний периметр заполнен, определяю внутренний периметр
            int c = 1;
            int d = 1;
 
            while (stV < row02 * colums02) 
            { 
                //Движение вправо
                while (array[c,d+1] == 0) 
                {
                    array[c, d] = stV;
                    stV++;
                    d++;
                } 
                // Движение вниз
                while (array[c+1,d] == 0) 
                {
                    array[c,d] = stV;
                    stV++;
                    c++;
                } 
                // Движение влево
                while (array[c,d-1] == 0) 
                {
                    array[c,d] = stV;
                    stV++;
                    d--;
                } 
                // Движение вверх
                while (array[c-1,d] == 0) 
                {
                    array[c,d] = stV;
                    stV++;
                    c--;
                }
            } 
            // Решаю проблему центральной незаполненной ячейки
            for (int i = 0; i < row02; i++) 
            {
                for (int j = 0; j < colums02; j++) 
                {
                    if (array[i,j] == 0) 
                    {
                        array[i,j] = stV;
                    }
                }
            }
            return array;
        }
        void PrintArray05(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++) 
            {
                for (int j = 0; j < array.GetLength(1); j++) 
                {
                    Console.Write(String.Format("{0,3}", array[i,j]));                    
                }
                Console.WriteLine("");
            }
        }
    #endregion