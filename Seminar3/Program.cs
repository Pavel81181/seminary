//Задача №17. Напишите программу, которая принимает на вход координаты точки (X и Y), 
//причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.
 Console.WriteLine ("Enter X");
int numX = int.Parse(Console.ReadLine());
Console.WriteLine ("Enter Y");
int numY = int.Parse(Console.ReadLine());
if (numX > 0 && numY > 0)
{
    Console.WriteLine ("Section 1");
}
if (numX < 0 && numY > 0)
{
    Console.WriteLine ("Section 2");
}
if (numX < 0 && numY < 0)

{
    Console.WriteLine ("Section 3");
}
if (numX > 0 && numY < 0)
{
    Console.WriteLine ("Section 4");
} 


