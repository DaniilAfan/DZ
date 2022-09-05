// // Задача 50. Напишите программу, которая
// на вход принимает позиции элемента в двумерном массиве,
//  и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> такого числа в массиве нет
int m = new Random().Next(1, 10);
int n = new Random().Next(1, 10);
int[,] numbers = new int[m, n];
FillArrayRandomNumbers(numbers);
PrintArray(numbers);

void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(-100, 100) ;
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}
Console.WriteLine("Введите номер строки элемента, который вы хотите найти");
int line =Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер столбца элемента, который вы хотите найти");
int colum =Convert.ToInt32(Console.ReadLine());
if (line>numbers.GetLength(0) || colum>numbers.GetLength(1))
{
    Console.WriteLine("элемента с таким индексом не существует");
}
else
{
    int a= numbers[line,colum];
    Console.WriteLine(a);
}
