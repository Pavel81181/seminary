//Программа для определения выходного дня

Console.Clear();
Console.Write("Введите число: ");
int dayNum = Convert.ToInt32(Console.ReadLine());
string dayName;

switch (dayNum) 
{
    case 1: dayName = "Рабочий";
            break;
    case 2: dayName = "Рабочий";
            break;
    case 3: dayName = "Рабочий";
            break; 
    case 4: dayName = "Рабочий";
            break;
    case 5: dayName = "Рабочий";
            break;
    case 6: dayName = "Выходной";
            break;
    case 7: dayName = "Выходной";
            break;
    default: dayName = "Ошибка";    
            break;                          
}
Console.WriteLine(dayName);