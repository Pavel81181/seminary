//Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

//5, 25  ->  да
//-4, 16  ->  да
//25, 5  ->  да
//8,9  ->  нет

Console.Clear();
Console.WriteLine("Введите число 1 ");
int numb1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число 2 ");
int numb2 = int.Parse(Console.ReadLine());

if (numb2 < numb1)
{
    if (numb2 * numb2 == numb1)
    {
        Console.WriteLine("Да");
    }
    else
    {
        Console.WriteLine("Нет");
    }
}
else
{
if (numb1 * numb1 == numb2)
    {
        Console.WriteLine("Да");
    }
    else
    {
        Console.WriteLine("Нет");
    }
}