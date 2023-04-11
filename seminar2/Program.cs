int num = new Random().Next(10, 100);
Console.WriteLine(num);

int num1 = num/10;
int num2 = num%10;

if (num1 > num2)
    {
        Console.WriteLine("Число 1 больше");
     }

else if (num1 < num2)
{
   Console.WriteLine("Число 2 больше");  
   
}