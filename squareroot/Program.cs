using System;

class Program
{
    static void Main()
    {
        try
        {
            Console.WriteLine("Enter a number:");
            double number = double.Parse(Console.ReadLine());

            if (number < 0)
            {
                throw new Exception("Cannot calculate square root of a negative number.");
            }

            double squareRoot = Math.Sqrt(number);
            Console.WriteLine("Square root of {0} is {1}", number, squareRoot);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}
