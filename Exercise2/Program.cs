using System;

public class Exercise2
{
    public static void Main()
    {
        int i = 0;
        while (i <= 10)
        {
            Console.Write(i + (i < 10 ? "," : ""));
            i++;
        }
        Console.WriteLine();
    }
}
