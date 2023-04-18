Start();
void Start()
{
int rows = SetNumber ("rows");
int columns = SetNumber ("col");

int [,] matrix = GetRandomMatrix(rows, columns, 10, 99);
PrintMatrix(matrix);
}
int SetNumber(string text ="")
{
    Console.Write($"Enter number {text}: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int [,] GetRandomMatrix (int rows, int columns, int min, int max)
{
    int [,] array = new int[rows, columns]; 
    var rand = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = rand.Next (min, max+1);
        }
    }
    return  array;
}

void PrintMatrix (int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLongLength(1); j++)
        {
            Console.Write($"{array[i,j]}");
        }
    }
}