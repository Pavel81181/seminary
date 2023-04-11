//Вводим число и находим сумму чисел от 1 до этого числа

int SetNumber(string text ="")
{
    Console.Write($"Enter number {text}: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}
int sum = 0;
int num = SetNumber();
for (int i = 1; i <= num; i++)
{
    sum += i;
}
Console.WriteLine ("Sum = " + sum);

// Инкремент
// Префиксный
int a = 40;
int b = ++a; //b = 41; a = 41
Console.WriteLine ($" a = {a}, b = {b}");

// постфиксный
b = a++; // b = 41, a = 42
Console.WriteLine ($" a = {a}, b = {b}");




