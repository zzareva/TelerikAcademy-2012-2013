using System;

class SumAndPrintNNumbers
{
    static void Main()
    {
        Console.WriteLine("Please enter n numbers.");
        uint numberN = GetN();
        float sum = 0f;
        for (byte i = 0; i < numberN; i++)
        {
            Console.WriteLine("Please enter a number.");
            sum += GetNumber();
        }
        Console.WriteLine("Here is the sum: {0}", sum);
    }
    static uint GetN()
    {
        uint number;
        while (!uint.TryParse(Console.ReadLine(), out number))
        {
            Console.WriteLine("Please enter a valid number n.");
        }
        return number;
    }
    static float GetNumber()
    {
        float number;
        while (!float.TryParse(Console.ReadLine(), out number))
        {
            Console.WriteLine("Please enter a valid float number.");
        }
        return number;
    }
}
