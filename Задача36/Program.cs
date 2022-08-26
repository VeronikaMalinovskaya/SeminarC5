// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.

//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0
int[] array = new int[10];
int len = array.Length;
int index = 0;
int sum = 0;
 for(int i = 0; i<len; i++)
{
    array[i]= new Random().Next(0, 100);
    Console.Write($"{array[i]} ,  ");
}
for (int i = 0; i < len; i++)
{  
   if (array[i] % 2 == 1)
  {
    sum = sum + array[i];
  }
}
Console.WriteLine("Сумма элементов " + sum); 

