// Задача 2: Задайте двумерный массив. Напишите
// программу, которая поменяет местами первую и
// последнюю строку массива.

int[,] array = FillArray(3, 3, 1, 10);

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

void ChangeRows(int[,] matr)
{
    int numRows = matr.GetLength(0);// переменная хранит количество строк
    int numCols = matr.GetLength(1);// переменная хранит количество столбцов

    int[] tempRow = new int[numCols];// переменная для хранания первой строки
    for (int i = 0; i < numCols; i++)
    {
        tempRow[i] = matr[0, i];
    }

    for (int i = 0; i < numCols; i++)
    {
        matr[0, i] = matr[numRows - 1, i];
    }

    for (int i = 0; i < numCols; i++)
    {
        matr[numRows - 1, i] = tempRow[i];
    }
}
ChangeRows(array);
PrintArray(array);