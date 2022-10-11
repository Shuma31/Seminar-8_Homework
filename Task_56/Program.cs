// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

void Task_56()
{
    Console.Write("Введите размер массива: ");
    int numbers = Convert.ToInt32(Console.ReadLine());
    int [,] array = new int [numbers, numbers];
    CreateArray(numbers, numbers);
    PrintArray(array);

    int minSumLine = 0;
    int sumLine = SumLineElements(array, 0);
    for (int i = 1; i < array.GetLength(0); i++)
    {
        int tempSumLine = SumLineElements(array, i);
        if (sumLine > tempSumLine)
        {
            sumLine = tempSumLine;
            minSumLine = i;
        }
    }

    Console.WriteLine($"\n{minSumLine + 1} - строкa с наименьшей суммой ({sumLine}) элементов ");

    int SumLineElements(int[,] array, int i)
    {
        int sumLine = array[i,0];
         for (int j = 1; j < array.GetLength(1); j++)
        {  
             sumLine += array[i,j];
        }
        return sumLine;
    }

     int [,] CreateArray(int column, int line)
    {
        for (int i = 0; i < column; i++)
        {
            for (int j = 0; j < line; j++)
            {
                array [i, j] = new Random().Next(0, 10);
            }
        }
        return array;
    }
    void PrintArray(int [,] inArray)
    {
        for (int i = 0; i < inArray.GetLength(0); i++)
        {
            for (int j = 0; j < inArray.GetLength(1); j++)
            {
                Console.Write($"{inArray[i,j]}\t");
            }
            Console.WriteLine();
        }
    }

}
Task_56();
    