// Показать натуральные числа от M до N, N и M заданы,Найти сумму элементов от M до N, N и M заданыwh
int m = InputInt("Введите M:");
int n = InputInt("Введите N:");
Console.WriteLine($"Сумма элементов от {m} до {n} = {CountNaturalSum(m, n)}");

int InputInt(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}

int CountNaturalSum(int m, int n)
{
    if (m == n)
        return n;
    return n + CountNaturalSum(m, n - 1);
}
while (m<=n)
{
    Console.Write(m+",");
    m=m+1;
}