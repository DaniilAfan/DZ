//  Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 4
Console.WriteLine("Введите количество чисел");
int size= Convert.ToInt32(Console.ReadLine());
int[] numbers= new int[size];
Fillarray(numbers);
void Fillarray(int[] array)
{
    Console.WriteLine("Введите числа");
    for (int i=0; i<array.Length; i++)
    array[i]=Convert.ToInt32(Console.ReadLine());
}
int count=0;
for (int i=0; i<numbers.Length; i++)
{
    if (numbers[i]>0)
    {
        count++;
    }

}
Console.WriteLine(count);
