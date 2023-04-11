/* Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых 
лежат в отрезке [10,99]. 
Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5 */

int[] FillArray (int length, int minValue, int maxValue)
{
    int [] result = new int[length];
    Random rand = new Random();
    for (int i = 0; i < length; i++)
        result[i] = rand.Next(minValue, maxValue + 1);
    return result;
} 

int GetCount (int[] array, int min, int max)
{
    int count = 0;
    
    for (int i = 0; i < array.Length; i++)
        if (array[i] >= min && array[i] <= max)
           count++;
       
    return count;
}


int[] array = FillArray (12, 0, 100);
int count = GetCount (array, 10, 99);
Console.Clear();
Console.WriteLine(string.Join(", ", array));
Console.WriteLine($"Количество чисел в заданном интервале = {count}");