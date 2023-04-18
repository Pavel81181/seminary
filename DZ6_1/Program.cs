/* Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3 */

int SetNumber(string text ="")
{
    Console.Write(text);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}


int [] FillArray (int length)
{
    int [] array = new int[length]; 
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = SetNumber($"Введите {i+1}-е число: ");
    }
    return array;
}


int GetCount (int [] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count+= 1;
        }
    }
    return count;
}

Console.Clear();
int length = SetNumber($"Введите количество чисел: ");
int[] array = FillArray(length);
Console.WriteLine (String.Join (" ", array));
int result = GetCount(array);
Console.WriteLine($"Количество чисел больше нуля среди введенных = {result}");
