void Program_1_1()
{
    int[] ArrayOfNumbers = new int[20];
    Random randomNumber = new Random();
    for (int i = 0; i < ArrayOfNumbers.Length; i++)
    {
        ArrayOfNumbers[i] = randomNumber.Next(0, 30);       //Filling an array with random numbers(0 - 30)
        Console.Write($"{ArrayOfNumbers[i]} ");
    }
    for (int i = 0, temp = ArrayOfNumbers[0], index = 0; i < ArrayOfNumbers.Length; i++)
    {
        if (ArrayOfNumbers[i] > temp)
        {
            temp = ArrayOfNumbers[i];
            index = i;
        }
        if (i == ArrayOfNumbers.Length - 1)
        {
            ArrayOfNumbers[index] = ArrayOfNumbers[0];
            ArrayOfNumbers[0] = temp;
        }
    }
    Console.WriteLine();
    Console.WriteLine($"Max: {ArrayOfNumbers[0]}");
    foreach (int item in ArrayOfNumbers)
    {
        Console.Write($"{item} ");
    }
    Console.WriteLine();
}
void Program_1_2()
{
    int[] ArrayOfNumbers = new int[10];
    Random randomNumber = new Random();
    for (int i = 0; i < ArrayOfNumbers.Length; i++)
    {
        ArrayOfNumbers[i] = randomNumber.Next(0, 30);         //Filling an array with random numbers(0 - 30)
        Console.Write($"{ArrayOfNumbers[i]} ");
    }
    for (int i = 0, temp = ArrayOfNumbers[0], index = 0; i < ArrayOfNumbers.Length; i++)
    {
        if (ArrayOfNumbers[i] < temp)
        {
            temp = ArrayOfNumbers[i];
            index = i;
        }
        if (i == ArrayOfNumbers.Length - 1)
        {
            ArrayOfNumbers[index] = ArrayOfNumbers[ArrayOfNumbers.Length - 1];
            ArrayOfNumbers[ArrayOfNumbers.Length - 1] = temp;
        }
    }
    Console.WriteLine();
    Console.WriteLine($"Min: {ArrayOfNumbers[ArrayOfNumbers.Length - 1]}");
    foreach(int item in ArrayOfNumbers)
    {
        Console.Write($"{item} ");
    }
    Console.WriteLine();
}
void Program_1_3()
{
    int[] ArrayOfNumbers = new int[15];
    Random randomNumber = new Random();
    for (int i = 0; i < ArrayOfNumbers.Length; i++)
    {
        ArrayOfNumbers[i] = randomNumber.Next(0, 30);       //Filling an array with random numbers(0 - 30)
        Console.Write($"{ArrayOfNumbers[i]} ");
    }
    for (int i = 0, temp = ArrayOfNumbers[0], index = 0; i < ArrayOfNumbers.Length; i++)
    {
        if (ArrayOfNumbers[i] > temp)
        {
            temp = ArrayOfNumbers[i];
            index = i;
        }
        if (i == ArrayOfNumbers.Length - 1)
        {
            ArrayOfNumbers[index] = ArrayOfNumbers[ArrayOfNumbers.Length - 1];
            ArrayOfNumbers[ArrayOfNumbers.Length - 1] = temp;
        }
    }
    Console.WriteLine();
    Console.WriteLine($"Max: {ArrayOfNumbers[ArrayOfNumbers.Length - 1]}");
    foreach (int item in ArrayOfNumbers)
    {
        Console.Write($"{item} ");
    }
    Console.WriteLine();
}
void Program_1_4()
{
    int[] ArrayOfNumbers = new int[25];
    Random randomNumber = new Random();
    for (int i = 0; i < ArrayOfNumbers.Length; i++)
    {
        ArrayOfNumbers[i] = randomNumber.Next(0, 30);   //Filling an array with random numbers(0 - 30)
        Console.Write($"{ArrayOfNumbers[i]} ");
    }
    for (int i = 0, temp = ArrayOfNumbers[0], index = 0; i < ArrayOfNumbers.Length; i++)
    {
        if (ArrayOfNumbers[i] < temp)
        {
            temp = ArrayOfNumbers[i];
            index = i;
        }
        if (i == ArrayOfNumbers.Length - 1)
        {
            ArrayOfNumbers[index] = ArrayOfNumbers[0];
            ArrayOfNumbers[0] = temp;
        }
    }
    Console.WriteLine();
    Console.WriteLine($"Min: {ArrayOfNumbers[0]}");
    foreach (int item in ArrayOfNumbers)
    {
        Console.Write($"{item} ");
    }
    Console.WriteLine();
}
void Program_1_5()
{
    int[] ArrayOfNumbers = new int[16];
    Random randomNumber = new Random();
    for (int i = 0; i < ArrayOfNumbers.Length; i++)
    {
        ArrayOfNumbers[i] = randomNumber.Next(-30, 30);     //Filling an array with random numbers(-30 - 30)
        Console.Write($"{ArrayOfNumbers[i]} ");
    }
    Console.WriteLine();
    for(int i = 0, j = 0; i < ArrayOfNumbers.Length; i++)
    {
        double result = ((Math.Pow(Math.E, ArrayOfNumbers[i]) + 2 * Math.Pow(Math.E, -ArrayOfNumbers[i])) / (Math.Sqrt(5 + Math.Sin(ArrayOfNumbers[i])))) * i;
        Console.Write($"{result} ");
        if (result > 0.1)
        {
            j += 1;
        }
        if (i == ArrayOfNumbers.Length - 1)                         
        {
            Console.WriteLine($"\ndi > 0.1: {j} елементов");        
        }
    }
    Console.WriteLine();
}
void Program_1_6()
{
    int[] ArrayOfNumbers = new int[25];
    for (int i = 1; i < ArrayOfNumbers.Length + 1; i++)
    {
        ArrayOfNumbers[i - 1] = i;                          //Filling an array
        Console.Write($"{ArrayOfNumbers[i - 1]} ");
    }
    Console.WriteLine();
    foreach (int item in ArrayOfNumbers)
    {
        double result = (5 * item + Math.Cos(item) * Math.Cos(item)) / 2.35;
        Console.WriteLine($"{result} ");
    }
    Console.WriteLine("\n");
}
void Program_1_7()
{
    int[] ArrayOfNumbers = new int[18];
    double[] NewArrayOfNumbers = new double[18];
    Random randomNumber = new Random();
    for (int i = 0; i < ArrayOfNumbers.Length; i++)
    {
        ArrayOfNumbers[i] = randomNumber.Next(-30, 30);     //Filling an array with random numbers(-30 - 30)
        Console.Write($"{ArrayOfNumbers[i]} ");
    }
    Console.WriteLine();
    Console.Write("Новый массив: ");
    for (int i = 0; i < ArrayOfNumbers.Length; i++)
    {
        NewArrayOfNumbers[i] = 0.13 * ArrayOfNumbers[i] * 3 - 2.5 * ArrayOfNumbers[i];
        Console.Write($"{NewArrayOfNumbers[i], 2} ");
    }
    Console.WriteLine();
    Console.Write("Негативные елементы: ");
    foreach (double item in NewArrayOfNumbers)
    {
        if (item < 0)
        {
            Console.Write($"{item} ");
        }
    }
    Console.WriteLine("\n");
}
void Program_1_8()
{
    int[] ArrayOfNumbers = new int[10];
    double[] NewArrayOfNumbers = new double[10];
    Console.Write("Первый массив: ");
    for (int i = 0; i < ArrayOfNumbers.Length; i++)
    {
        if (i % 2 != 0)
        {
            ArrayOfNumbers[i] = 2 * i + 1;                          //Filling an array
        }
        else
        {
            ArrayOfNumbers[i] = 2 * i - 1;
        }
        if (ArrayOfNumbers[i] > 2.5)
        {
            NewArrayOfNumbers[i] = 2.5 * ArrayOfNumbers[i];
        }
        else
        {
            NewArrayOfNumbers[i] = 2.5 / ArrayOfNumbers[i];
        }
        Console.Write($"{ArrayOfNumbers[i]} ");
    }
    Console.WriteLine();
    Console.Write("Второй массив: ");
    foreach (int item in NewArrayOfNumbers)
    {
        Console.Write($"{item} ");
    }
    Console.WriteLine("\n");
}
void Program_1_9()
{
    double[] ArrayOfNumbers = new double[25];
    Random randomNumber = new Random();
    for (int i = 0; i < ArrayOfNumbers.Length; i++)
    {
        ArrayOfNumbers[i] = randomNumber.Next(-30, 30);                //Filling an array with random numbers(-30 - 30)
        Console.Write($"{ArrayOfNumbers[i]} ");
        if (ArrayOfNumbers[i] < 0)
        {
            ArrayOfNumbers[i] = Math.Pow(ArrayOfNumbers[i], 2);
        }
        else if (ArrayOfNumbers[i] > 0)
        {
            ArrayOfNumbers[i] += 7;
        }
    }
    Console.WriteLine();
    foreach (int item in ArrayOfNumbers)
    {
        Console.Write($"{item} ");
    }
    Console.WriteLine("\n");
}
void Program_1_10()
{
    int[] ArrayOfNumbers = new int[30];
    Random randomNumber = new Random();
    for (int i = 0; i < ArrayOfNumbers.Length; i++)
    {
        ArrayOfNumbers[i] = randomNumber.Next(0, 50);       //Filling an array with random numbers(0 - 50)
        Console.Write($"{ArrayOfNumbers[i]} ");
    }
    Console.WriteLine();
    for (int i = 0, result = 0; i < ArrayOfNumbers.Length; i++)
    {
        if (ArrayOfNumbers[i] % 5 == 0)
        {
            result += ArrayOfNumbers[i];
        }
        if (i == ArrayOfNumbers.Length - 1)
        {
            Console.WriteLine($"Сумма елементов кратных пяти: " + result);
        }
    }
}
void Program_1_11()
{
    int[] ArrayOfNumbers = new int[30];
    Random randomNumber = new Random();
    for (int i = 0; i < ArrayOfNumbers.Length; i++)
    {
        ArrayOfNumbers[i] = randomNumber.Next(-50, 50);       //Filling an array with random numbers(-50 - 50)
        Console.Write($"{ArrayOfNumbers[i]} ");
    }
    Console.WriteLine();
    for (int i = 0, result = 0; i < ArrayOfNumbers.Length; i++)
    {
        if (ArrayOfNumbers[i] % 2 != 0 && ArrayOfNumbers[i] < 0)
        {
            result += ArrayOfNumbers[i];
        }
        if (i == ArrayOfNumbers.Length - 1)
        {
            Console.WriteLine($"Сумма елементов: " + result);
        }
    }
    Console.WriteLine();
}
void Program_1_12()
{
    int[] ArrayOfNumbers = new int[30];
    Random randomNumber = new Random();
    for (int i = 0; i < ArrayOfNumbers.Length; i++)
    {
        ArrayOfNumbers[i] = randomNumber.Next(-50, 50);       //Filling an array with random numbers(-50 - 50)
        Console.Write($"{ArrayOfNumbers[i]} ");
    }
    Console.WriteLine();
    for (int i = 0, result = 0; i < ArrayOfNumbers.Length; i++)
    {
        if (Math.Abs(ArrayOfNumbers[i]) < Math.Pow(i, 2))
        {
            result += ArrayOfNumbers[i];
        }
        if (i == ArrayOfNumbers.Length - 1)
        {
            Console.WriteLine($"Сумма елементов: " + result);
        }
    }
    Console.WriteLine();
}
void Program_1_13()
{
    int[] ArrayOfNumbers = new int[30];
    Random randomNumber = new Random();
    for (int i = 0; i < ArrayOfNumbers.Length; i++)
    {
        ArrayOfNumbers[i] = randomNumber.Next(-50, 50);       //Filling an array with random numbers(-50 - 50)
        Console.Write($"{ArrayOfNumbers[i]} ");
    }
    Console.WriteLine();
    for (int i = 0, j = 0, result = 0; i < ArrayOfNumbers.Length; i++)
    {
        if (ArrayOfNumbers[i] % 5 == 0 && ArrayOfNumbers[i] % 7 != 0)
        {
            j += 1;
            result += ArrayOfNumbers[i];
        }
        if (i == ArrayOfNumbers.Length - 1)
        {
            Console.WriteLine($"Сумма елементов: " + result);
            Console.WriteLine($"Количество елементов: " + j);
        }
    }
    Console.WriteLine();
}
void Program_1_14()
{
    double[] ArrayOfNumbers = new double[25];
    Random randomNumber = new Random();
    for (int i = 0; i < ArrayOfNumbers.Length; i++)
    {
        ArrayOfNumbers[i] = randomNumber.Next(-50, 50);       //Filling an array with random numbers(-50 - 50)
        Console.Write($"{ArrayOfNumbers[i]} ");
    }
    Console.WriteLine();
    for (int i = 0, x1 = 0, x2 = 0; i < ArrayOfNumbers.Length; i++)
    {
        if (ArrayOfNumbers[i] < 0)
        {
            x1 += 1;
        }
        else if (ArrayOfNumbers[i] >= 1 && ArrayOfNumbers[i] <= 12)
        {
            x2 += 1;
        }
        if (i == ArrayOfNumbers.Length - 1)
        {
            Console.WriteLine($"Количество негативный елементов: " + x1);
            Console.WriteLine($"Количество [1, 12]: " + x2);
        }
    }
    Console.WriteLine();
}
void Program_1_15()
{
    int[] ArrayOfNumbers = new int[35];
    Random randomNumber = new Random();
    for (int i = 0, sum = 0, mul = 1, result = 0; i < ArrayOfNumbers.Length; i++)
    {
        ArrayOfNumbers[i] = randomNumber.Next(-50, 50);       //Filling an array with random numbers(-50 - 50)
        Console.Write($"{ArrayOfNumbers[i]} ");
        if (ArrayOfNumbers[i] % 2 == 0 && ArrayOfNumbers[i] < 3)
        {
            sum += ArrayOfNumbers[i];
        }
        else if (ArrayOfNumbers[i] % 2 != 0 && ArrayOfNumbers[i] > 1)
        {
            mul *= ArrayOfNumbers[i];
        }
        if (i == ArrayOfNumbers.Length - 1)
        {
            result = sum + mul;
            Console.WriteLine($"\nРезультат: " + result);
        }
    }
    Console.WriteLine();
}
void Program_2_1()
{
    int[,] ArrayOfNumbers = new int[10, 10];
    Random randomNumber = new Random();
    for (int i = 5, rows = ArrayOfNumbers.GetUpperBound(0) + 1, result = 0; i < rows; i++)
    {
        for (int j = 5, columns = ArrayOfNumbers.GetUpperBound(1) + 1; j < columns; j++)
        {
            ArrayOfNumbers[i, j] = randomNumber.Next(-2, 3);       //Filling an array with random numbers(-2 - 3)
            if (i == j)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write($"{ArrayOfNumbers[i, j]}\t");
                Console.ResetColor();
            }
            else if (j > i && ArrayOfNumbers[i, j] > 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write($"{ArrayOfNumbers[i, j]}\t");
                Console.ResetColor();
                result += ArrayOfNumbers[i, j];
            }
            else
            {
                Console.Write($"{ArrayOfNumbers[i, j]}\t");
            }
        }
        Console.WriteLine();
        if (i == rows - 1)
        {
            Console.WriteLine($"Результат: " + result);
        }
    }
}
void Program_2_2()
{
    int[,] ArrayOfNumbers = new int[10, 10];
    Random randomNumber = new Random();
    for (int i = 0, rows = ArrayOfNumbers.GetUpperBound(0) + 1; i < rows; i++)
    {
        for (int j = 0, columns = ArrayOfNumbers.GetUpperBound(1) + 1; j < columns; j++)
        {
            ArrayOfNumbers[i, j] = randomNumber.Next(-2, 3);        //Filling an array with random numbers(-2 - 3)
            if (ArrayOfNumbers[i, j] < 0)
            {
                Console.Write($"{ArrayOfNumbers[i, j] = 0} ");
            }
            else
            {
                Console.Write($"{ArrayOfNumbers[i, j]} ");
            }
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
void Program_2_3()
{
    int[,] ArrayOfNumbers = new int[10, 10];
    Random randomNumber = new Random();
    for (int i = 0, rows = ArrayOfNumbers.GetUpperBound(0) + 1; i < rows; i++)
    {
        for (int j = 0, columns = ArrayOfNumbers.GetUpperBound(1) + 1; j < columns; j++)
        {
            ArrayOfNumbers[i, j] = randomNumber.Next(-2, 3);        //Filling an array with random numbers(-2 - 3)
            if (j > i)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write($"{ArrayOfNumbers[i, j] = 0} ");
                Console.ResetColor();
            }
            else if (ArrayOfNumbers[i, j] < 0)
            {
                Console.Write($"{ArrayOfNumbers[i, j] = 0} ");
            }
            else if (ArrayOfNumbers[i, j] > 0)
            {
                Console.Write($"{ArrayOfNumbers[i, j] = 1} ");
            }
            else
            {
                Console.Write($"{ArrayOfNumbers[i, j]} ");
            }
        }
        Console.WriteLine();
    }
}
void Program_2_4()
{
    Console.WriteLine();
    int[,] ArrayOfNumbers = new int[10, 10];
    Random randomNumber = new Random();
    for (int i = 0, rows = ArrayOfNumbers.GetUpperBound(0) + 1; i < rows; i++)
    {
        int max = 0, min = 0;
        for (int j = 0, columns = ArrayOfNumbers.GetUpperBound(1) + 1; j < columns; j++)
        {
            ArrayOfNumbers[i, j] = randomNumber.Next(-20, 20);        //Filling an array with random numbers(-50 - 50)
            if (ArrayOfNumbers[i, j] > max)
            {
                max = ArrayOfNumbers[i, j];
            }
            else if (ArrayOfNumbers[i, j] < min)
            {
                min = ArrayOfNumbers[i, j];
            }
            if (j == ArrayOfNumbers.GetUpperBound(1))
            {
                ArrayOfNumbers[i, 0] = min;
                ArrayOfNumbers[i, 9] = max;
                for (int k = 0, columns1 = ArrayOfNumbers.GetUpperBound(1) + 1; k < columns1; k++)
                {
                    Console.Write($"{ArrayOfNumbers[i, k]}\t");
                }
            }
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
void Program_2_5()
{
    int[,] ArrayOfNumbers = new int[10, 10];
    Random randomNumber = new Random();
    for (int i = 0, rows = ArrayOfNumbers.GetUpperBound(0) + 1; i < rows; i++)
    {
        int max = 0;
        for (int j = 0, columns = ArrayOfNumbers.GetUpperBound(1) + 1; j < columns; j++)
        {
            ArrayOfNumbers[i, j] = randomNumber.Next(-20, 21);        //Filling an array with random numbers(-2 - 3)
            if (ArrayOfNumbers[i, j] % 5 == 0 && ArrayOfNumbers[i, j] != 0)
            {
                if (ArrayOfNumbers[i, j] < 0 && max == 0)
                {
                    max = ArrayOfNumbers[i, j];
                }
                if (ArrayOfNumbers[i, j] > max)
                {
                    max = ArrayOfNumbers[i, j];
                }
                Console.Write($"{ArrayOfNumbers[i, j]} ");
            }
            if (j == columns - 1)
            {
                Console.WriteLine($"MAX={max}");
            }
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
void Program_2_6()
{
    int[,] TempArrayOfNumbers = new int[10, 10];
    int[,] ArrayOfNumbers = new int[10, 10];
    Random randomNumber = new Random();
    for (int i = 0, rows = ArrayOfNumbers.GetUpperBound(0) + 1, colMax = 0, J = 0; i < rows; i++)
    {
        J = 0;
        int colMaxTemp = 0;
        for (int j = 0, columns = ArrayOfNumbers.GetUpperBound(1) + 1; j < columns; j++)
        {
            ArrayOfNumbers[i, j] = randomNumber.Next(-1, 2);       //Filling an array with random numbers(-2 - 2)
            if (ArrayOfNumbers[i, j] > 0)
            {
                TempArrayOfNumbers[i, J] = ArrayOfNumbers[i, j];
                colMaxTemp += 1;
                J++;
            }
            else TempArrayOfNumbers[i, J] = 0;
        }
        if (colMaxTemp > colMax)
        {
            colMax = colMaxTemp;
        }
        if (i == rows - 1)
        {
            int[,] NewArrayOfNumbers = new int[10, colMax];
            for (int I = 0, Rows = NewArrayOfNumbers.GetUpperBound(0) + 1; I < Rows; I++)
            {
                J = 0;
                for (int Columns = NewArrayOfNumbers.GetUpperBound(1) + 1; J < Columns; J++)
                {
                    NewArrayOfNumbers[I, J] = TempArrayOfNumbers[I, J];
                    Console.Write($"{NewArrayOfNumbers[I, J]} ");
                }
                Console.WriteLine();
            }
        }
    }
    /*test
    Console.WriteLine();
    for (int I = 0, Rows = TempArrayOfNumbers.GetUpperBound(0) + 1; I < Rows; I++)
    {
        for (int J = 0, Columns = TempArrayOfNumbers.GetUpperBound(1) + 1; J < Columns; J++)
        {
            Console.Write($"{TempArrayOfNumbers[I, J]} ");
        }
        Console.WriteLine();
    }
    Console.ReadLine();*/
}
void Program_2_7()
{
    Console.WriteLine();
    int[,] ArrayOfNumbers = new int[10, 10];
    Random randomNumber = new Random();
    for (int i = 0, rows = ArrayOfNumbers.GetUpperBound(0) + 1, temp = 0, index = 0; i < rows; i++)
    {
        temp = 0;
        for (int j = 0, columns = ArrayOfNumbers.GetUpperBound(1) + 1; j < columns; j++)
        {
            if (temp == 0) temp = ArrayOfNumbers[i, j];
            ArrayOfNumbers[i, j] = randomNumber.Next(-50, 51);       //Filling an array with random numbers(-50 - 51)
            if (ArrayOfNumbers[i, j] > temp)
            {
                temp = ArrayOfNumbers[i, j];
                index = j;
            }
            if (j == columns - 1)
            {
                ArrayOfNumbers[i, index] = ArrayOfNumbers[i, i];
                ArrayOfNumbers[i, i] = temp;
                for (j = 0, columns = ArrayOfNumbers.GetUpperBound(1) + 1; j < columns; j++)
                    Console.Write($"{ArrayOfNumbers[i, j]}\t");
            }
        }
        Console.WriteLine();
    }
}
void Program_2_8()
{
    Console.WriteLine("");
    int[,] ArrayOfNumbers = new int[10, 10];
    int[] ArrayOfIndex = new int[4];
    Random randomNumber = new Random();
    for (int i = 0, rows = ArrayOfNumbers.GetUpperBound(0) + 1, min = 0, max = 0; i < rows; i++)
    {
        for (int j = 0, columns = ArrayOfNumbers.GetUpperBound(1) + 1; j < columns; j++)
        {
            ArrayOfNumbers[i, j] = randomNumber.Next(-50, 51);       //Filling an array with random numbers(-50 - 51)
            if (ArrayOfNumbers[i, j] > max)
            {
                max = ArrayOfNumbers[i, j];
                ArrayOfIndex[0] = i;
                ArrayOfIndex[1] = j;
            }
            else if (ArrayOfNumbers[i, j] < min)
            {
                min = ArrayOfNumbers[i, j];
                ArrayOfIndex[2] = i;
                ArrayOfIndex[3] = j;
            }
            Console.Write($"{ArrayOfNumbers[i, j]}\t");
        }
        if (i == rows - 1)
        {
            Console.WriteLine("\n");
            ArrayOfNumbers[ArrayOfIndex[2], ArrayOfIndex[3]] = max;
            ArrayOfNumbers[ArrayOfIndex[0], ArrayOfIndex[1]] = min;
            for (i = 0; i < rows; i++)
            {
                for (int j = 0, columns = ArrayOfNumbers.GetUpperBound(1) + 1; j < columns; j++)
                {
                    if (ArrayOfIndex[0] == i && ArrayOfIndex[1] == j || ArrayOfIndex[2] == i && ArrayOfIndex[3] == j)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write($"{ArrayOfNumbers[i, j]}\t");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.Write($"{ArrayOfNumbers[i, j]}\t");
                    }
                }
                Console.WriteLine();
            }
        }
        Console.WriteLine();
    }
}
void Program_2_9()
{
    Console.WriteLine("");
    int[,] ArrayOfNumbers = new int[24, 7];
    double[,] newArrayOfNumbers = new double[25, 8];
    int[] sumCol = new int[7];
    Random randomNumber = new Random();
    for (int i = 0, rows = ArrayOfNumbers.GetUpperBound(0) + 1; i < rows; i++)
    {
        int columns = ArrayOfNumbers.GetUpperBound(1) + 1;
        double sumRow = 0;
        for (int j = 0; j < columns; j++)
        {
            ArrayOfNumbers[i, j] = randomNumber.Next(1, 6);       //Filling an array with random numbers(1 - 6)
            newArrayOfNumbers[i, j] = ArrayOfNumbers[i, j];
            newArrayOfNumbers[rows, j] += ArrayOfNumbers[i, j];     //Считаем сумму всех столбцов
            newArrayOfNumbers[i, columns] += ArrayOfNumbers[i, j];      //Считаем сумму всех рядов
            sumRow += ArrayOfNumbers[i, j];
            Console.Write($"{newArrayOfNumbers[i, j]}\t");
        }
        Console.Write($"{Math.Round(newArrayOfNumbers[i, columns] / columns, 1)}"); //Выводим среднее ареф. рядов
        Console.WriteLine();
        if (i == rows - 1)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write($"{Math.Round(newArrayOfNumbers[rows, j] / rows, 1)}\t"); //Выводим среднее ареф. столбцов
            }
        }
    }
    Console.WriteLine();
}
void Program_2_10()
{
    Console.WriteLine();
    int[,] ArrayOfNumbers = new int[10, 10];
    Random randomNumber = new Random();
    for (int i = 0, rows = ArrayOfNumbers.GetUpperBound(0) + 1, maxSum = 0, minSum = 0, maxSumIndex = 0, minSumIndex = 0, temp; i < rows; i++)
    {
        temp = 0;
        for (int j = 0, columns = ArrayOfNumbers.GetUpperBound(1) + 1; j < columns; j++)
        {
            ArrayOfNumbers[i, j] = randomNumber.Next(1, 11);        //Filling an array with random numbers(-2 - 3)
            temp += ArrayOfNumbers[i, j];
            if (temp > maxSum && j == columns - 1)
            {
                maxSum = temp;
                maxSumIndex = i;
            }
            if (temp < minSum && j == columns - 1 || temp < maxSum + 1 && i == 0)
            {
                minSum = temp;
                minSumIndex = i;
            }
        }
        if (i == rows - 1)
        {
            for (int j = 0, columns = ArrayOfNumbers.GetUpperBound(1) + 1; j < columns; j++)
            {
                Console.Write($"{ArrayOfNumbers[maxSumIndex, j]} \t");
            }
            Console.WriteLine($"\nМаксимальная сумма: {maxSum}");
            for (int j = 0, columns = ArrayOfNumbers.GetUpperBound(1) + 1; j < columns; j++)
            {
                Console.Write($"{ArrayOfNumbers[minSumIndex, j]} \t");
            }
            Console.WriteLine($"\nМинимальная сумма: {minSum}");
        }
    }
    Console.WriteLine();
}
void Program_2_11()
{
    Console.WriteLine();
    int[,] ArrayOfNumbers = new int[24, 12];
    int[] SortedRow = new int[12];
    Random randomNumber = new Random();
    for (int i = 0, rows = ArrayOfNumbers.GetUpperBound(0) + 1, count = 0, rowIndex = 0; i < rows; i++)
    {
        int tempCount = 0;
        for (int j = 0, columns = ArrayOfNumbers.GetUpperBound(1) + 1; j < columns; j++)
        {
            ArrayOfNumbers[i, j] = randomNumber.Next(-2, 9);       // Filling an array with random numbers(-2 - 3)
            SortedRow[j] = ArrayOfNumbers[i, j];    // Заполняем строку с которой будем работать
        }
        Array.Sort(SortedRow);  // Сортируем нашу строку
        for (int j = 0, columns = SortedRow.Length; j < columns; j++)
        {
            int tempCountElem = 0;  // Создаём переменную для подсчёта текущего елемента
            for (int J = j; J < columns; J++)
            {
                if (SortedRow[j] == SortedRow[J])
                {
                    tempCountElem++;
                    // Считаем кол-во совпадений
                }
                else if (tempCountElem == 1)
                {
                    break;
                    // Если у елемента нету пары - завершаем цыкл
                    // tempCountElem не будет никуда присвоено, т.к. элемент SortedRow[j] не совпадает ни с каким другим
                    // При следующей итерации внешнего цыкла, tempCountElem обнулится
                }
                else
                {
                    tempCount += tempCountElem;     // Если пар больше нету, обновляем сумму совпадений в текущей строке
                    j += tempCountElem - 1;     // Пропускаем проверенные элементы 
                    break;
                }
            }
        }
        if (tempCount > count)
        {
            count = tempCount;      // Запоминаем количество совпадений
            rowIndex = i;   // Запоминаем строку с найбольшим кол-вом совпадений
        }
        if (i == rows - 1)
        {
            for (int j = 0, columns = ArrayOfNumbers.GetUpperBound(1) + 1; j < columns; j++)
            {
                Console.Write($"{ArrayOfNumbers[rowIndex, j]} \t");
            }
            Console.WriteLine($"\nМаксимальное количество совпадений: {count}");
        }
    }
    Console.WriteLine();
}
void Program_2_12()
{
    Console.WriteLine();
    int[,] ArrayOfNumbers = new int[10, 10];
    int[] SortedRow = new int[10];
    Random randomNumber = new Random();
    for (int i = 0, rows = ArrayOfNumbers.GetUpperBound(0) + 1, count = 0, rowIndex = 0; i < rows; i++)
    {
        int tempCount = 0;
        for (int j = 0, columns = ArrayOfNumbers.GetUpperBound(1) + 1; j < columns; j++)
        {
            ArrayOfNumbers[i, j] = randomNumber.Next(0, 5);       // Filling an array with random numbers(-2 - 3)
            SortedRow[j] = ArrayOfNumbers[i, j];
        }
        Array.Sort(SortedRow);  // Сортируем нашу строку
        int tempCountElem = 0;
        for (int j = 0, columns = SortedRow.Length; j < columns; j++)
        {
            if (SortedRow[j] == 0)
            {
                tempCountElem++;
            }
            else
            {
                tempCount += tempCountElem;
                j += tempCountElem - 1;
                break;
            }
        }
        if (tempCount > count)
        {
            count = tempCount;
            rowIndex = i;
        }
        if (i == rows - 1)
        {
            for (int j = 0, columns = ArrayOfNumbers.GetUpperBound(1) + 1; j < columns; j++)
            {
                Console.Write($"{ArrayOfNumbers[rowIndex, j]} \t");
            }
            Console.WriteLine($"\nМаксимальное количество нулей: {count}");
        }
    }
    Console.WriteLine();
}
void Program_2_13()
{
    Console.WriteLine();
    int[,] ArrayOfNumbers = new int[10, 10];
    int[] RowArrray = new int[10];
    Random randomNumber = new Random();
    for (int i = 0, rows = ArrayOfNumbers.GetUpperBound(0) + 1; i < rows; i++)
    {
        bool alternation = false;
        for (int j = 0, columns = ArrayOfNumbers.GetUpperBound(1) + 1; j < columns; j++)
        {
            ArrayOfNumbers[i, j] = randomNumber.Next(0, 2);       // Filling an array with random numbers(-2 - 3)
            RowArrray[j] = ArrayOfNumbers[i, j];
        }
        int tempValue = RowArrray[0];
        for (int j = 1, columns = RowArrray.Length; j < columns; j++)
        {
            if (RowArrray[j - 1] == 0 && RowArrray[j] == 1|| RowArrray[j - 1] == 1 && RowArrray[j] == 0)
            {
                if (j == columns - 1) alternation = true;
            }
            else
            {
                break;
            }
        }
        if (alternation == true)
        {
            for (int j = 0, columns = ArrayOfNumbers.GetUpperBound(1) + 1; j < columns; j++)
            {
                Console.Write($"{ArrayOfNumbers[i, j]} \t");
            }
            Console.WriteLine($"\nНомер рядка: {i}");
        }
    }
    Console.WriteLine();
}
void Program_2_14() 
{
    int i = 0, j = 0;
    int n = 11;
    int value = n * n - 1;
    int[,] ArrayOfNumbers = new int[11, 11];
    while (n != 0)
    {
        int k = 0;
        do { ArrayOfNumbers[i, j++] = value--; } while (++k < n - 1);
        for (k = 0; k < n - 1; k++) ArrayOfNumbers[i++, j] = value--;
        for (k = 0; k < n - 1; k++) ArrayOfNumbers[i, j--] = value--;
        for (k = 0; k < n - 1; k++) ArrayOfNumbers[i--, j] = value--;

        ++i; ++j; n = n < 2 ? 0 : n - 2;
    }
    for (int I = 0, rows = ArrayOfNumbers.GetUpperBound(0) + 1; I < rows; I++)
    {
        for (int J = 0, columns = ArrayOfNumbers.GetUpperBound(1) + 1; J < columns; J++)
        {
            Console.Write($"{ArrayOfNumbers[I, J]}\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
void Program_2_15()
{
    Console.WriteLine();
    int[,] ArrayOfNumbers = new int[10, 10];
    Random randomNumber = new Random();
    int sum = 0;
    for (int i = 0, rows = ArrayOfNumbers.GetUpperBound(0) + 1, temp = 0; i < rows; i++)
    {
        for (int j = 0, columns = ArrayOfNumbers.GetUpperBound(1) + 1; j < columns; j++)
        {
            ArrayOfNumbers[i, j] = randomNumber.Next(0, 21);       // Filling an array with random numbers(0 - 2)
            temp = j == 0 ? ArrayOfNumbers[i, j] : temp;
            if ((i + 1) % 2 == 0)
            {
                Console.Write($"{ArrayOfNumbers[i, j]}\t");
                if (ArrayOfNumbers[i, j] < temp)
                {
                    temp = ArrayOfNumbers[i, j];
                }
            }
            else break;     // Если рядок не парный - останавливаем цикл, переходим на след. ряд.
            if (j == columns - 1) sum += temp;
        }
        Console.WriteLine();
    }
    Console.WriteLine($"Сумма: {sum}");
}
void Program_3_1()
{
    char[] line = Console.ReadLine().ToCharArray();
    int sum_0 = 0, sum_1 = 0; 
    foreach (char item in line)
    {
        if (item == '0') sum_0++;
        else if (item == '1') sum_1++;
    }
    Console.WriteLine($"Кол-во нулей: {sum_0}| Кол-во единиц: {sum_1}");
}
void Program_3_2()
{
    string[] line = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
    Console.WriteLine(line.Length);
}
void Program_3_3()
{
    char[] line = Console.ReadLine().ToCharArray();
    int sum = 0;
    foreach (char item in line) if (item == ',' || item == '.' || item == '!' || item == '?' || item == ':' || item == ';' || item == '-') sum++;
    Console.WriteLine("Сума: " + sum);
}
void Program_3_4()
{
    char[] line = Console.ReadLine().ToCharArray();
    foreach (char item in line) if (item == '1' || item == '2' || item == '3' || item == '4' || item == '5' || item == '6' || item == '7' || item == '8' || item == '9' || item == '0') Console.WriteLine(item);
}
void Program_3_5()
{
    string[] line = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
    int count = 0;
    foreach (string item in line) count = Convert.ToInt32(item) % 2 == 0 ? count + 1 : count;
    Console.WriteLine("Кол-во парных чисел: " + count);
}
void Program_3_6()
{
    // Для русского алфавита
    char[] line = Console.ReadLine().ToCharArray();
    double sumV = 0, sumO = 0;
    foreach (char item in line)
    {
        if (item == 'а' || item == 'а' || item == 'у' || item == 'о' || item == 'и' || item == 'ы' || item == 'э') sumV++;
        else sumO++;
    }
    if (sumV / sumO < sumO / sumV) Console.WriteLine($"Гласные:Согласные = {sumV / sumO * 100.0}:{100 - (sumV / sumO * 100.0)}");
    else Console.WriteLine($"Гласные:Согласные = {100 - (sumO / sumV * 100.0)}:{sumO/ sumV * 100.0}");
}
void Program_3_7()
{
    char[] line = Console.ReadLine().ToCharArray();
    foreach (char item in line) if (char.IsUpper(item)) Console.WriteLine(item);
}
void Program_3_8()
{
    string[] line = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
    foreach (string item in line)
    {
        int iterator = 0;
        foreach (char letters in item)
        {
            if (iterator++ == 0) Console.Write(char.ToUpper(letters));
            else Console.Write(letters);
        }
        Console.WriteLine();
    }
}
void Program_3_9()
{
    string[] line = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
    foreach (string item in line)
    {
        int iterator = 0;
        foreach (char letters in item)
        {
            if (iterator++ != 0) Console.Write(letters);
        }
        Console.WriteLine();
    }
}
void Program_3_10()
{
    // Тупае задание
    string[] line = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
    for (int i = 0; i < line.Length; i++)
    {
        for (int j = 0; j < line[i].Length; j++)
        {
            Console.Write(line[i][i]);
        }
        Console.WriteLine();
    }
}
void Program_3_11()
{
    string[] line = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
    foreach (string item in line)
    {
        for (int i = 0; i < item.Length; i++)
        {
            if (i == 0) Console.Write(item[item.Length - 1]);
            else if (i == item.Length - 1) Console.Write(item[0]);
            else Console.Write(item[i]);
        }
        Console.WriteLine();
    }
}
void Program_3_12()
{
    string latin = "abcdefghijklmnopqrstuvwxyz";
    string[] line = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
    foreach (string item in line)
    {
        foreach (char letter in item)   
        {
            if (latin.Contains(char.ToLower(letter))) Console.Write('+');
            else Console.Write(letter);
        }
        Console.WriteLine();
    }
}
void Program_3_13()
{
    string[] line = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
    foreach (string item in line)
    {
        foreach (char letter in item)
        {
            if (letter == 'А') Console.Write('*');
            else Console.Write(letter);
        }
        Console.WriteLine();
    }
}
void Program_3_14()
{
    string line = Console.ReadLine().Replace(" ", "");
    bool palindrom = false;
    for (int i = 0, j = line.Length; i > line.Length; i++, j--)
    {
        palindrom = line[i] == line[j] ? true : false;
    }
    Console.WriteLine(palindrom);
}
void Program_3_15()
{
    string[] line = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
    int count = 0, iterator = 0;
    for (int i = 0; i < line.Length; i++)
    {
        if (count < line[i].Length)
        {
            count = line[i].Length;
            iterator = i;
        }
    }
    Console.WriteLine(line[iterator]);
}
int i = 0;
while (i++ < 100000000) Console.Write(i);

