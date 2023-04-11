/* Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33]
 */
int SetNumber(string text ="")
{
    Console.Write($"Enter {text}: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

 
 int [] FillArray (int Length, int minValue, int maxValue)
{
   int [] array = new int [Length];
   Random rand = new Random ();
   for(int i = 0; i < Length; i++) 
   {
            array[i] = rand.Next(minValue, maxValue + 1);
   }
   return array;
}
void PrintArray (int [] array)
{
    Console.Write("[");
       for(int i = 0; i < array.Length; i++) 
   {
    Console.Write(array [i] + " ");
   }
    Console.WriteLine("]");
}
Console.Clear();
int length = SetNumber("Array Length");
int min = SetNumber("MinValue");
int max = SetNumber("MaxValue");
int [] array = FillArray(length, min, max);
PrintArray(array);