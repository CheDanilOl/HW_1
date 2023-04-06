// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите число:");

        int Num = int.Parse(Console.ReadLine());

        for (int i = 0; i <= Num; i++)
        {
            if (i % 2 = 0)
            {
                Console.WriteLine("{0} ", i);
            }
        }
    }
}