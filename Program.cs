// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.

//[345, 897, 568, 234] -> 2

int[] array = new int[10];

int length = array.Length;
int index = 0;
while (index < length)
{
    array[index]= new Random().Next(100, 1000);
    Console.Write($"{array[index]} , ");
    index++;
}
for (int i =0; i < length; i++)
if (array[i] % 2 == 0)
{ 
    index++;
}
Console.WriteLine();

int QuantityPositive(int[] array)
{
    int quantity = 0;
    for (int i = 0; i<array.Length; i++ )
    {
    if (array[i] % 2 == 1)
    {
      quantity++;
    }
  }
  return quantity;
}
int quantity = QuantityPositive(array);
Console.WriteLine($"Количество чётных чисел в массиве: {quantity}");