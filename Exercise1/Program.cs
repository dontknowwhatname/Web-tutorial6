using System;

public class Exercise1
{
    public static void Main()
    {
        for (int i = 0; i <= 10; i++)
        {
            Console.Write(i + (i < 10 ? "," : ""));
        }
        Console.WriteLine();
    }
}
