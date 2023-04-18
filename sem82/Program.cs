/* Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, если это невозможно, 
программа должна вывести сообщение для пользователя. */

Start();
void Start()
{
    Console.Clear();
    int rows = SetNumber("rows");
    int columns = SetNumber("columns");
    int min = SetNumber("min");
    int max = SetNumber("max");
    Console.WriteLine();
    int[,] matrix = GetRandomMatrix(rows, columns, min, max);
    PrintMatrix(matrix);
    Console.WriteLine();
    int[,] newMatrix = ConvertRowsToColumn(matrix);
    PrintMatrix(newMatrix);
    Console.WriteLine();
}

int SetNumber(string text = "")
{
    Console.Write($"Enter number {text}: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}
int[,] GetRandomMatrix(int rows, int columns, int min, int max)
{
    int[,] array = new int[rows, columns];
    var rand = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = rand.Next(min, max + 1);
        }
    }
    return array;
}
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLongLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}   ");
        }
        Console.WriteLine();
    }
}

int[,] ConvertRowsToColumn(int[,] arr)
{
    int[,] arr2 = new int[arr.GetLength(1), arr.GetLength(0)];
    for (int i = 0; i < arr.GetLength(1); i++)
    {
        for (int j = 0; j < arr.GetLength(0); j++)
        {
            arr2[i, j] = arr[j, i];
        }
    }
    return arr2;
}

