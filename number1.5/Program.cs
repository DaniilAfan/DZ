/*Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 28*/
int size= new Random().Next(1,10);
int[] numbers=new int [size];
Fillarray(numbers);
int count=0;
void Fillarray (int[] array )
{
    for (int i=0; array.Length>i; i++)
    {
    array[i]= new Random().Next(99,1000);
    }
}
for (int i=0; i<numbers.Length; i++)
{
    Console.WriteLine(numbers[i]);
    if (numbers[i]%2==0)
    {
    count=count+1;
    }
}
Console.WriteLine(count);
