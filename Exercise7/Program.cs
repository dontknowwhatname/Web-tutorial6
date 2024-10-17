using System;

class Calculator
{
    static void Main()
    {
        while (true)
        {
            try
            {
                Console.WriteLine("Enter first number:");
                if (!double.TryParse(Console.ReadLine(), out double a))
                {
                    Console.WriteLine("Please enter a valid number!");
                    continue; // 继续循环
                }

                Console.WriteLine("Enter operator (+, -, *, /):");
                if (!char.TryParse(Console.ReadLine(), out char c) || !(c == '+' || c == '-' || c == '*' || c == '/'))
                {
                    Console.WriteLine("Please enter a correct operator: + - * /");
                    continue; // 继续循环
                }

                Console.WriteLine("Enter second number:");
                if (!double.TryParse(Console.ReadLine(), out double b))
                {
                    Console.WriteLine("Please enter a valid number!");
                    continue; // 继续循环
                }

                double result;

                if (c == '+')
                {
                    result = a + b;
                    Console.WriteLine($"{a} + {b} = {result}");
                }
                else if (c == '-')
                {
                    result = a - b;
                    Console.WriteLine($"{a} - {b} = {result}");
                }
                else if (c == '*')
                {
                    result = a * b;
                    Console.WriteLine($"{a} * {b} = {result}");
                }
                else if (c == '/')
                {
                    if (b == 0)
                    {
                        throw new DivideByZeroException("Cannot divide by zero!");
                    }
                    result = a / b;
                    Console.WriteLine($"{a} / {b} = {Math.Round(result, 2)}");
                }
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Input format is incorrect: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("Thank you for using the calculator.");
            }
        }
    }
}
