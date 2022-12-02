// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Clear();

Console.Write("Введите первое число: ");
int n1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int n2 = int.Parse(Console.ReadLine());
Console.Write("Введите третье число: ");
int n3 = int.Parse(Console.ReadLine());

if (n1 > n2 & n1 > n3)
{
    Console.WriteLine($"Max = {n1}");
}
if (n2 > n1 & n2 > n3)
{
    Console.WriteLine($"Max = {n2}");
}
if (n3 > n1 & n3 > n2)
{
    Console.WriteLine($"Max = {n3}");
}
