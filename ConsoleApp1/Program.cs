
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



using System;

class Program
{
    static string accountNumber = Guid.NewGuid().ToString().Substring(0, 8);
    static string name, lastName, sex;
    static int age;
    static decimal balance = 0;

    static void Main(string[] args)
    {
        RegisterUser();
        ShowMenu();
    }

    static void RegisterUser()
    {
        Console.Write("Enter your First Name: ");
        name = Console.ReadLine();
        Console.Write("Enter your Last Name: ");
        lastName = Console.ReadLine();
        Console.Write("Enter your Sex (M/F): ");
        sex = Console.ReadLine();
        Console.Write("Enter your Age: ");
        age = int.Parse(Console.ReadLine());

        Console.WriteLine($"\nUser Registered Successfully!");
        Console.WriteLine($"Account Number: {accountNumber}\n");
    }

    static void ShowMenu()
    {
        while (true)
        {
            Console.WriteLine("1. Deposit");
            Console.WriteLine("2. Withdraw");
            Console.WriteLine("3. Check Balance");
            Console.WriteLine("4. Exit");
            Console.Write("Choose an option: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Deposit();
                    break;
                case 2:
                    Withdraw();
                    break;
                case 3:
                    Console.WriteLine($"Your balance is: {balance}\n");
                    break;
                case 4:
                    Console.WriteLine("Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid choice!\n");
                    break;
            }
        }
    }

    static void Deposit()
    {
        Console.Write("Enter amount to deposit: ");
        decimal amount = decimal.Parse(Console.ReadLine());
        balance += amount;
        Console.WriteLine($"Deposit successful! New balance: {balance}\n");
    }

    static void Withdraw()
    {
        Console.Write("Enter amount to withdraw: ");
        decimal amount = decimal.Parse(Console.ReadLine());
        if (amount > balance)
        {
            Console.WriteLine("Insufficient balance!\n");
        }
        else
        {
            balance -= amount;
            Console.WriteLine($"Withdrawal successful! New balance: {balance}\n");
        }
    }
}
