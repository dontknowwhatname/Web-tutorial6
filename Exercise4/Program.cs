using System;

public class Exercise4
{
    public static void Main()
    {
        Console.WriteLine("Integers from 0 to 100 that are divisible by 3 and 4:");
        for (int i = 0; i <= 100; i++)
        {
            if (i % 3 == 0 && i % 4 == 0)
            {
                Console.Write(i + " ");
            }
        }
        Console.WriteLine();
    }
}
