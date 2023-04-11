/* Габиль Асланов 20:47
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

A (3,6); B (2,1) -> 5,09 
A (7,-5); B (1,-1) -> 7,21 */
//AB = √(xb - xa)2 + (yb - ya)2


Console.WriteLine("Enter X1");
double X1 = double.Parse(Console.ReadLine());
Console.WriteLine("Enter Y1");
double Y1 = double.Parse(Console.ReadLine());
Console.WriteLine("Enter X2");
double X2 = double.Parse(Console.ReadLine());
Console.WriteLine("Enter Y2");
double Y2 = double.Parse(Console.ReadLine());

double AB = Math.Sqrt((X2 - X1)*(X2 - X1) + (Y2 - Y1)*(Y2 - Y1));

Console.WriteLine(AB);
