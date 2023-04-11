/* Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел 
от 1 до N.

5 -> 1, 4, 9, 16, 25.
2 -> 1,4 */
Console.Clear ();
Console.Write("Введите число N: ");
string strNumN = Console.ReadLine();
int numN = Convert.ToInt32(strNumN);
int count = 1;


Console.WriteLine($"Квадраты чисел от 1 до {numN}:");
while (count <= numN)
{
    
       //Console.Write($"{count*count}  ");
    Console.Write($" {Math.Pow((count), 2)} ");
count++;
}
Console.WriteLine();



Console.WriteLine("Vvedite chislo 1");
int input1 =int.Parse(Console.ReadLine());
for (int i = 1; i <= input1; i++)
{   
    Console.Write ($" {i*i}");
}
Console.WriteLine();
