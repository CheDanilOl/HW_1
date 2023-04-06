
// Напишите программу, которая на вход принимает число и выдаёт его квадрат (число умноженное на само себя).

// Например:
// 4 -> 16 
// -3 -> 9 
// -7 -> 49

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите целое число");

        string value = Console.ReadLine();

        int Num = Convert.ToInt32(value);


        Console.WriteLine("Квадрат введенного числа " + Num + " = " + Math.Pow(Num, 2));

        Console.WriteLine($"Квадрат введенного числа {Num} = {Math.Pow(Num, 2)}");
    }
}