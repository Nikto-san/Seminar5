// Задача 1: Напишите программу, которая на вход
// принимает позиции элемента в двумерном массиве, и
// возвращает значение этого элемента или же указание,
// что такого элемента нет.


System.Console.WriteLine("Введите номер строки: ");
string strOne = Console.ReadLine();
int numOne = Convert.ToInt32(strOne);
System.Console.WriteLine("Введите номер столбца: ");
string strTwo = Console.ReadLine();
int numTwo = Convert.ToInt32(strTwo);

int[,] array = FillArray(4, 4, 1, 10);

PrintArray(array);
Console.WriteLine();

int result = GetElementValue(array, numOne, numTwo);

if (result != -1)
{
    Console.WriteLine($"Значение элемента [{numOne}, {numTwo}]: {result}");
}

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

int GetElementValue(int[,] array, int row, int col)
{
    int numRows = array.GetLength(0);
    int numCols = array.GetLength(1);

    int rowIndex = row - 1;
    int colIndex = col - 1;

    if (row >= 0 && row < numRows && col >= 0 && col < numCols)
    {
        int result = array[rowIndex, colIndex];
        Console.WriteLine($"Значение элемента [{row}, {col}]: {result}");
        return result;  
    }
    else
    {
        Console.WriteLine($"Элемента с позицией [{row}, {col}] не существует.");
        return -1;  
    }
}