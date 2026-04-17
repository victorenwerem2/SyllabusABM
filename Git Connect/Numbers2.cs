using System;

class Numbers2
{
    static void Main()
    {
        Console.WriteLine("Even Numbers from 1 to 100:");
        for (int i = 1; i <= 100; i++)
        {
            if (i % 2 == 0)
                Console.Write(i + " ");
        }

        Console.WriteLine("\n\nOdd Numbers from 1 to 100:");
        for (int i = 1; i <= 100; i++)
        {
            if (i % 2 != 0)
                Console.Write(i + " ");
        }

        Console.WriteLine("\n\nNumbers from 1 to 100:");
        for (int i = 1; i <= 100; i++)
        {
            Console.Write(i + " ");
        }
    }
}