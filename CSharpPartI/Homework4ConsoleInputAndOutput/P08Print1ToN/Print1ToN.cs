using System;

class Print1ToN
{
    static void Main()
    {
        Console.WriteLine("Please enter an integer number.");
        int number = GetN();
        sbyte add = 1;
        if (number < 1)
        {
            add = -1;
        }
        int currentValue = 1;
        while (true)
        {
            Console.Write(currentValue);
            if (currentValue == number)
            {
                Console.WriteLine();
                break;
            }
            else
            {
                Console.Write(", ");
            }

            currentValue += add;
        }
    }

    static int GetN()
    {
        int number;
        while (!int.TryParse(Console.ReadLine(), out number))
        {
            Console.WriteLine("Please enter a valid integer number.");
        }
        return number;
    }
}

