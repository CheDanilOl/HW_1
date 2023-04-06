
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите число 1: ");
        string value1 = Console.ReadLine();

        Console.WriteLine ("Введите квадрат числа 1: ");
        string value2 = Console.ReadLine();

        int Num1 = Convert.ToInt32(value1);

        int Num2 = Convert.ToInt32(value2);

        if (Num2 == Math.Pow(Num1,2))
        {
            Console.WriteLine($"Число {Num1} является квадратом {Num2}");
        
        }

        else
        {   
            Console.WriteLine("Запустите программу заново.");

        }
        Console.ReadKey();

    }
}