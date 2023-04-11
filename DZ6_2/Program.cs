/* Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) */


double SetNumber(string text ="")
{
    Console.Write(text);
    double num = Convert.ToDouble(Console.ReadLine());
    return num;
}

Console.Clear();
double Kef1 = SetNumber($"Введите коэффициент 1:  ");
double const1 = SetNumber($"Введите константу 1:  ");
double Kef2 = SetNumber($"Введите коэффициент 2:  ");
double const2 = SetNumber($"Введите константу 2:  ");

bool Proverka (double Kef1, double Kef2, double const1, double const2)
{
    if (Kef1 == Kef2)
    {
        if (const1 == const2)
        {
            Console.WriteLine("Прямые совпадают");
        }
        else
        {
            Console.WriteLine("Прямые параллельны");
        }
        return false;
    }
    return true;
}

if (Proverka (Kef1, Kef2, const1,const2))
{
double x = (const2 - const1) / (Kef1 - Kef2);
double y = Kef1 * x + const1;
Console.WriteLine($" Координаты точки пересечения прямых ({x}, {y})");
}

