// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).



internal partial class Program
{
    private static void Main(string[] args)
    {

        Console.WriteLine("Введите число: ");
        string value1 = Console.ReadLine();

        int Num = Convert.ToInt32(value1);

        if (Num % 2 == 0)
        {
            Console.WriteLine("Введенное число - чётное.");
        }
        else
        {
            Console.WriteLine("Введенное число не четное.");
        }


    }
}