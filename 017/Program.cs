// Задача 3: Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить строку с
// наименьшей суммой элементов.


int[,] array = FillArray(6, 4, 1, 10);

int[,] FillArray(int columns, int rows, int minValue, int maxValue)
{
    int[,] array = new int[rows, columns];
    Random rand = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i,j] = rand.Next(minValue, maxValue + 1);
        }
    }
    return array;
}

void PrintArray (int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i,j] + " ");
        }
        Console.WriteLine();
    }
}
PrintArray(array);
Console.WriteLine();

int SumRow(int[,] array, int row)
{
    int sum = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        sum += array[row,j];
    }
return sum;
}

int FindMinSumRow(int[,] matrix)
{
    int minSum = SumRow(matrix, 0); 
    int minSumRow = 0; 

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int currentSum = SumRow(matrix, i);
        if (currentSum < minSum)
        {
            minSum = currentSum;
            minSumRow = i;
        }
    }
    return minSumRow;
}

int minSumRow = FindMinSumRow(array);

Console.WriteLine($"Строка с наименьшей суммой элементов: {minSumRow + 1}");