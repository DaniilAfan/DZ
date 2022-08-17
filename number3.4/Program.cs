/*Напишите программу, которая задаёт массив из N элементов и выводит их на экран.

5 -> [1, 2, 5, 7, 19]

3 -> [6, 1, 33]*/
Console.WriteLine("введите количество элементов массива");
int N= Convert.ToInt32(Console.ReadLine());
int [] a;
a = new int[N];
Random rand = new Random();
for (int i=0; i< a.Length; i++)
{
    a[i]=rand.Next(1, 21);
}
for (int i=0; i< a.Length; i++)
{
    Console.Write(a[i]+" ");
}
