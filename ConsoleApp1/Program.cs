using System;



class Program

{
    static void Main()

    {
        Console.WriteLine("Введите значение a:");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите значение b:");
        double b = Convert.ToDouble(Console.ReadLine());
        double result;

        if (a > b)
        {
            result = a / b + 1;
        }

        else if (a < b)
        {
            result = (Math.Pow(a, 3) - 5) / a;
        }

        else
        {
            result = -25;
        }

        Console.WriteLine($"Результат уравнения  {result}");

    }
}
