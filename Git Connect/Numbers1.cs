using System;

class Numbers1
{
    static void Main()
    {
        Console.WriteLine("Prime Numbers from 1 to 100:");
        for (int i = 2; i <= 100; i++)
        {
            bool isPrime = true;

            for (int j = 2; j <= i / 2; j++)
            {
                if (i % j == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            if (isPrime)
                Console.Write(i + " ");
        }

        Console.WriteLine("\n\nMultiples of 8 from 1 to 80:");
        for (int i = 1; i <= 80; i++)
        {
            if (i % 8 == 0)
                Console.Write(i + " ");
        }

        Console.WriteLine("\n\nMultiples of 10 from 1 to 100:");
        for (int i = 1; i <= 100; i++)
        {
            if (i % 10 == 0)
                Console.Write(i + " ");
        }
    }
}