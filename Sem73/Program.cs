
// Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.

Start();
void Start()
{
    Console.Clear();
    int rows = SetNumber("m");
    int columns = SetNumber("n");
    Console.WriteLine();
    int[,] matrix = GetRandomMatrix(rows, columns, 2, 9);
    PrintMatrix(matrix);
    Console.WriteLine();
    GetPower(matrix);
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
            array[i, j] = rand.Next(min, max+1);
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
int[,] GetPower(int [,] array)
{
    
   
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
           if (i%2 == 0 && j%2 == 0)
            array[i, j] = array[i,j] * array[i,j];
        }
    }
    return array;
}