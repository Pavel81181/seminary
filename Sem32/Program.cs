//Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).
/* Console.WriteLine("Enter sector");
int Sect = int.Parse(Console.ReadLine());
if (Sect == 1)
{
   Console.WriteLine("X>0,Y>0"); 
}
else if (Sect == 2)
{
   Console.WriteLine("X>0,Y<0"); 
}
else if (Sect == 3)
{
   Console.WriteLine("X<0,Y<0"); 
}
else if (Sect == 4)
{
   Console.WriteLine("X<0,Y>0"); 
}
else
{
   Console.WriteLine("Wrong number"); 
} */

Console.Write("Enter sector ");
int num = int.Parse(Console.ReadLine());

switch (num){
    case 1: Console.WriteLine("X > 0 and Y > 0"); break;
    case 2: Console.WriteLine("X < 0 and Y > 0"); break;
    case 3: Console.WriteLine("X < 0 and Y < 0"); break;
    case 4: Console.WriteLine("X > 0 and Y < 0"); break;
    Default: Console.WriteLine("Error"); break;
}
