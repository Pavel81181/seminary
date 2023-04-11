/* Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, 
второй и предпоследний и т.д. Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21 */

int[] FillArray(int length, int minValue, int maxValue)
{
    int[] result = new int[length];
    Random rand = new Random();
    for (int i = 0; i < length; i++)
        result[i] = rand.Next(minValue, maxValue + 1);
    return result;
}

int[] GetNewArray(int[] array)
{
    int size = array.Length % 2 == 0 ? array.Length / 2 : (array.Length / 2) + 1;za
    int[] mult = new int[size];

    for (int i = 0; i < mult.Length; i++)
       mult[i] = array[i] * array[array.Length - 1 - i];
       
    if (array.Length % 2 == 1) mult[size-1] = array[array.Length / 2];
    return mult;
}


int[] array = FillArray(11, 0, 10);
Console.Clear();
Console.WriteLine(string.Join(", ", array));
Console.WriteLine(string.Join(", ", GetNewArray(array)));
