/* Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. 
Выведите полученный массив на экран.
m = 3, n = 4.
0 1 2 3
1 2 3 4
2 3 4 5 */
Start();
void Start()
{
    Console.Clear();
    int rows = SetNumber("m");
    int columns = SetNumber("n");
    Console.WriteLine();
    int[,] matrix = GetMatrix(rows, columns);
    PrintMatrix(matrix);
    Console.WriteLine();
}

int SetNumber(string text = "")
{
    Console.Write($"Enter number {text}: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}
int[,] GetMatrix(int rows, int columns)
{
    int[,] array = new int[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = i + j;
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
            Console.Write($" {matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}