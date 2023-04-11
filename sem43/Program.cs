//Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
void FillArray (int [] array)
{
   int lentgh = array.Length;
   Random rand = new Random ();
   for(int i = 0; i < lentgh; i++) 
   {
    array[i] = rand.Next(2);
   }
}
void PrintArray (int [] array)
{
    int lentgh = array.Length;
   for(int i = 0; i < lentgh; i++) 
   {
    Console.Write(array [i] + " ");
   }
}
int [] array = new int[8];  
FillArray(array);
PrintArray(array);