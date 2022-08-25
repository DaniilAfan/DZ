/*Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0*/
int size= new Random().Next(1,10);
int[] numbers= new int[size];
Fillarray(numbers);
int sum=0;
void Fillarray (int[] array )
{
    for (int i=0; array.Length>i; i++)
    {
    array[i]= new Random().Next(-100,1000);
    }
}
for (int i=0; i<numbers.Length; i++)
{
    Console.WriteLine(numbers[i]);
    if (i%2==1)
    { 
        sum+=numbers[i];
    }
}
Console.WriteLine(sum);