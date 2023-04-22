/* Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
453 -> 12
45 -> 9 */

Console.Write("Введите число: ");
string strNum = Console.ReadLine();
int num = Convert.ToInt32(strNum);

int SumNumbers(int number)
{
    // if (number == 0) return 0;
    // return (number % 10 + SumNumbers(number / 10));
    return (number == 0) ? 0 : (number % 10 + SumNumbers(number / 10));
}
Console.WriteLine($"Сумма числа {num} равна {SumNumbers(num)}");