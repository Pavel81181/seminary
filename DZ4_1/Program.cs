/* Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16 */

int SetNumber(string text ="")
{
    Console.Write($"Enter number {text}: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}
int Pow(int numA, int numB) 

{
    int PW = numA;
    for (int i = 1; i < numB; i++)
    {
        PW = PW * numA;
    }
    return PW;
}

bool Proverka(int numB)
{
    if (numB < 0)
    {
        Console.WriteLine("Число В не может быть меньше 0");
        return false;
    }
    
        return true;
}

Console.Clear();
int numA = SetNumber("A");
int numB = SetNumber("B");
if (Proverka (numB))
{
    Console.WriteLine($"Число {numA} в степени {numB} = {Pow(numA, numB)} ");
}