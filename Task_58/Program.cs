// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

void Task_58()
{
    Console.Write("Введите размерность матрицы: ");
    int matrixSize = Convert.ToInt32(Console.ReadLine());
    int [,] matrix1 = new int [matrixSize, matrixSize];
    int [,] matrix2 = new int [matrixSize, matrixSize];
    int [,] matrix3 = new int [matrixSize, matrixSize];

    CreateArray(matrix1);
    Console.WriteLine("Матрица № 1: ");
    PrintArray(matrix1);
    Console.WriteLine();
    CreateArray(matrix2);
    Console.WriteLine("Матрица № 2: ");
    PrintArray(matrix2);
    Console.WriteLine();
    
    for (int i = 0; i < matrixSize; i++)
    {
        for (int j = 0; j < matrixSize; j++)
        {
            for (int k = 0; k < matrixSize; k++)
            {
                matrix3 [i, j] = matrix3[i, j] + matrix1[i, k] * matrix2[j, k];
            }
        }
    }
    Console.WriteLine("Произведение матриц: ");
    PrintArray(matrix3);

     int [,] CreateArray(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array [i, j] = new Random().Next(1, 5);
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
Task_58();