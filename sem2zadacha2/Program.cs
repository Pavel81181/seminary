

//Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.

//34, 5 -> не кратно, остаток 4 
//16, 4 -> кратно

Console.Write("Введите первое число");
int numb1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число");
int numb2 = int.Parse(Console.ReadLine());
Console.WriteLine(numb1);
Console.WriteLine(numb2);
int dif = numb1 % numb2;

if ( dif == 0)
{
    Console.WriteLine("Число 2 кратно числу 1");
}
else 
{
    Console.WriteLine($"Число 2 не кратно числу 1, остаток {dif}");
}

