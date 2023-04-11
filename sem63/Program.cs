/* Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
45 -> 101101
3  -> 11
2  -> 10 */

/* Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
Console.Write("Введите основание системы исчисления: ");
int @base = int.Parse(Console.ReadLine());
Console.WriteLine(ChangeBase(num, @base));
string ChangeBase(int num, int @base)
{
    int[] array = new int[32];
    for (int i = 31; ; i--)
    {
        array[i] = num % @base;
        num /= @base;
        if (num == 0) break;
    }
    return String.Join("", array);
} */

//Вход: число
// Вывод: перевести в двоичное и записать в массив
using System;       
namespace exp42     
{
    class tr   
    {
        static int setVal()
        {   // ввод числа
            Console.Write("Введите число : ");
            return Convert.ToInt32(Console.ReadLine());
        }

        static int[] numToBinar(int num)
        {
            int[] bin = new int[32];
            int i = 31;
            while (num > 0)
            {
                bin[i] = num % 2;
                num /= 2;
                i --;
            }
            return bin;
        }

        static void outputArray(int n, int[] arr)
            {   // вывод массива случайных чисел
                string text = "[" + string.Join(", ", arr) + "]";
                Console.WriteLine(text);
            }
            
        static void Main(string[] str) 
        {
            //int number = setVal();
            //outputArray(32, numToBinar(number));
            outputArray(32, numToBinar(setVal()));
               
        }
    }
}