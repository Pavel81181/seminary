/* Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли 
существовать треугольник с сторонами такой длины.
Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон. */
/* int[] array = new int[3];

for (int i = 0; i < 3; i++)
{
    Console.Write("Enter num:");
    array[i] = Convert.ToInt32(Console.ReadLine());
} */

Console.Write("Введите три числа (разделитель пробел): ");
int[] array = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();

bool CheckTriangle(int[] array)
{
    bool result = true;
    for (int i = 0; i < 3; i++)
    {
        result &= array[i] < array[(i + 1) % 3] + array[(i + 2) % 3];
    }
    return result;
}
string msg = CheckTriangle(array) ? "Треугольник реален" : "Треугольник невозможен";
Console.WriteLine(msg);