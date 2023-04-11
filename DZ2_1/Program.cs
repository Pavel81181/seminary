//Программа для демонстрации второй цифры трехзначного числа


Console.Clear();
Console.Write("Введите трехзначное число ");
int num = int.Parse(Console.ReadLine());
if (num<100 || num>999)
{
    Console.WriteLine("Вы ввели не трехзначное число ");
}
else
{
int num1 = num/100;
int num2 = (num-num1*100)/10;
Console.WriteLine(num2);
int num3 = num/10%10;
Console.WriteLine(num3);
}