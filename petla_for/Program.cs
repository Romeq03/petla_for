using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Function Calculator: y = sqrt(3^2) * x");

        for (int x = 0; x <= 10; x++)
        {
            double y = Math.Sqrt(3 * 3) * x;
            Console.WriteLine($"For x = {x}, y = {y}");
        }
    }
}
