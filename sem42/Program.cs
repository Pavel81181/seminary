/* Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5 */

int SetNumber(string text ="")
{
    Console.Write($"Enter number {text}: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}
int count = 0;
int num = SetNumber();
for (; num!=0; num = num/10)
{
   count++;
}
Console.Write($"В числе  {count} цифр ");
