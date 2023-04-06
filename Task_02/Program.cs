
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите число 1: ");
        string value1 = Console.ReadLine();

        Console.WriteLine("Введите число 2: ");
        string value2 = Console.ReadLine();
        
         Console.WriteLine("Введите число 3: ");
        string value3 = Console.ReadLine();

        int Num1 = Convert.ToInt32(value1);

        int Num2 = Convert.ToInt32(value2);

        int Num3 = Convert.ToInt32(value3);

        if (Num1>Num2 && Num1 > Num3)
        {
            Console.WriteLine($"Число {Num1} максимальное");

        }

        else if (Num2 > Num1 && Num2 > Num3)
        {
            Console.WriteLine($"Число {Num2} максимальное");

        }
        else
        { 
            Console.WriteLine($"Число {Num3} максимальное");
        }
        Console.ReadKey();
       /// return;

    }
}