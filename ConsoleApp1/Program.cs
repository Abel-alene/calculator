
/*
using System;

class Calculator
{
    static void Main()
    {
        Console.WriteLine("Enter first number:");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter second number:");
        double num2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Choose operation: +, -, *, /, %");
        char operation = Console.ReadLine()[0];

        double result = operation switch
        {
            '+' => num1 + num2,
            '-' => num1 - num2,
            '*' => num1 * num2,
            '/' => num2 != 0 ? num1 / num2 : double.NaN,
            '%' => num1 % num2,
            _   => double.NaN 
        };

        Console.WriteLine($"Result: {result}");
    }
}
*/

/*
using System;

class Calculator
{
    static void Main()
    {
        Console.WriteLine("Enter the first number:");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the second number:");
        double num2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Choose an operation:");
        Console.WriteLine("1. Addition (+)");
        Console.WriteLine("2. Subtraction (-)");
        Console.WriteLine("3. Multiplication (*)");
        Console.WriteLine("4. Division (/)");
        Console.WriteLine("5. Modulus (%)");

        int choice = Convert.ToInt32(Console.ReadLine());
        double result = 0;

        switch (choice)
        {
            case 1:
                result = num1 + num2;
                break;
            case 2:
                result = num1 - num2;
                break;
            case 3:
                result = num1 * num2;
                break;
            case 4:
                if (num2 != 0)
                    result = num1 / num2;
                else
                {
                    Console.WriteLine("Error: Division by zero is not allowed!");
                    return;
                }
                break;
            case 5:
                result = num1 % num2;
                break;
            default:
                Console.WriteLine("Invalid choice! Please run the program again.");
                return;
        }

        Console.WriteLine($"The result is: {result}");
    }
}
*/

using System;

class Calculator
{
    static void Main()
    {
        bool continueCalculating = true;

        while (continueCalculating)
        {
            Console.WriteLine("Enter the first number:");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the second number:");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Choose an operation:");
            Console.WriteLine("1. Addition (+)");
            Console.WriteLine("2. Subtraction (-)");
            Console.WriteLine("3. Multiplication (*)");
            Console.WriteLine("4. Division (/)");
            Console.WriteLine("5. Modulus (%)");

            int choice = Convert.ToInt32(Console.ReadLine());
            double result = 0;

            switch (choice)
            {
                case 1:
                    result = num1 + num2;
                    break;
                case 2:
                    result = num1 - num2;
                    break;
                case 3:
                    result = num1 * num2;
                    break;
                case 4:
                    if (num2 != 0)
                        result = num1 / num2;
                    else
                    {
                        Console.WriteLine("Error: Division by zero is not allowed!");
                        continue;
                    }
                    break;
                case 5:
                    result = num1 % num2;
                    break;
                default:
                    Console.WriteLine("Invalid choice! Please run the program again.");
                    continue;
            }

            Console.WriteLine($"The result is: {result}");

            Console.WriteLine("Do you want to perform another calculation? (y/n):");
            char userChoice = Convert.ToChar(Console.ReadLine().ToLower());

            if (userChoice != 'y')
            {
                continueCalculating = false;
            }
        }

        Console.WriteLine("Goodbye!");
    }
}
