/* Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12 */

int SetNumber(string text ="")
{
    Console.Write($"Enter number {text}: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}
int Sum(int number) 

{
    int sum = 0;
    for (; number > 0; number /=10)
    {
        sum += number%10;
    }
    return sum;
}

Console.Clear();
int number = SetNumber();

{
    Console.WriteLine($"Сумма цифр числа {Sum(number)} ");
}