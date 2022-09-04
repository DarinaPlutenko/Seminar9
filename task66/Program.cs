// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите число M: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());

int SumMToN(int m, int n)
{
    if (m > n) return 0;
    return m + SumMToN(m + 1, n);
}
if (numberM < numberN)
{
    int sum = SumMToN(numberM, numberN);
    Console.WriteLine($"Сумма нутарльных элементов в промежутке от {numberM} до {numberN} составляет {sum}");
}
else Console.WriteLine("Число M должно быть меньше N");
