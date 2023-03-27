// Программа для обзначения третьей цифры числа
Console.Clear();
Console.Write("Введите число ");
int num = int.Parse(Console.ReadLine());
if (num < 100)
{
    Console.WriteLine("3 цифры нет");
}
else
{
    while (num > 999)
    {
        num = num/10;
    }
int num2 = num%10;
Console.WriteLine(num2);
}
