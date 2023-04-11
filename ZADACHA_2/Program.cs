//Задача №1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
//a = 25, b = 5 -> да 
//a = 2, b = 10 -> нет 
//a = 9, b = -3 -> да 
//a = -3 b = 9 -> нет

//Задача №3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
//3 -> Среда 
//5 -> Пятница
System.Console.WriteLine("Enter number1");
string strNum1 = Console.ReadLine();
int num1 = Convert.ToInt32(strNum1);
System.Console.WriteLine("Enter number2");
string strNum2 = Console.ReadLine();
int num2 = Convert.ToInt32(strNum2);
if (num1 == num2 * num2)
{Console.WriteLine("Да");
}
else
{Console.WriteLine("Нет");
}
System.Console.WriteLine("Enter number");
string strNum = Console.ReadLine();
int num = Convert.ToInt32(strNum);
if (num == 1)
{Console.WriteLine("Понедельник");
}
else if (num == 2)
{Console.WriteLine("Вторник");
}
else if (num == 3)
{Console.WriteLine("Среда");
}
else if (num == 4)
{Console.WriteLine("Четверг");
}
else if (num == 5)
{Console.WriteLine("Пятница");
}
else if (num == 6)
{Console.WriteLine("Суббота");
}
else if (num == 7)
{Console.WriteLine("Воскресенье");
}
else
{Console.WriteLine("Вы ввели неправильное число");
}

Console.Write("Введите число: ");
int dayNum = Convert.ToInt32(Console.ReadLine());
string dayName;

switch (dayNum) 
{
    case 1: dayName = "Понедельник";
            break;
    case 2: dayName = "Вторник";
            break;
    case 3: dayName = "Среда";
            break; 
    case 4: dayName = "Четверг";
            break;
    case 5: dayName = "Пятница";
            break;
    case 6: dayName = "Суббота";
            break;
    case 7: dayName = "Воскресенье";
            break;
    default: dayName = "Ошибка";    
            break;                          
}
Console.WriteLine(dayName);