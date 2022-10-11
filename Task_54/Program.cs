// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.

void Task_54()
{
    Console.Write("Введите количество столбцов масcива: ");
    int column = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите количество строк масcива: ");
    int line = Convert.ToInt32(Console.ReadLine());

    int [,] array = new int [column, line];

    CreateArray(column, line);
    PrintArray(array);

    int min = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k] < array[i, k + 1]) 
                {
                    int temp = 0;
                    temp = array[i, k];
                    array[i, k] = array[i, k + 1];
                    array[i, k + 1] = temp;
                }
            }
        }    
    }
    Console.WriteLine();
    Console.WriteLine("Массив с упорядоченными значениями:");
    PrintArray(array);

    int [,] CreateArray(int column, int line)
    {
        for (int i = 0; i < column; i++)
        {
            for (int j = 0; j < line; j++)
            {
                array [i, j] = new Random().Next(-9, 10);
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
Task_54();