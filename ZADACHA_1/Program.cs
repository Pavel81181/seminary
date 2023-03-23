System.Console.WriteLine("Enter number");
string strNum = Console.ReadLine();
int num = Convert.ToInt32(strNum);
//int sqr = num * num;
double sqr = Math.Pow(num,2);
Console.WriteLine($"sqr = {sqr}");
