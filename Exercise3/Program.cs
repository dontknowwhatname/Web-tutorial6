using System;

public class LabExercise3
{
    public static void Main()
    {
        int i = 0;
        do
        {
            Console.Write(i + (i < 10 ? "," : ""));
            i++;
        } while (i <= 10);
        Console.WriteLine();
    }
}
