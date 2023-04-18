/* Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.
Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, если это невозможно, 
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
    ChangeString(matrix);
    PrintMatrix(matrix);
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
void ChangeString(int[,] array)
{

    int tmp;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        tmp = array[0, j];
        array[0, j] = array[array.GetLength(0) - 1, j];
        array[array.GetLength(0) - 1, j] = tmp;
    }
}
