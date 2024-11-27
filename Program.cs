using System;

public class Program
{
    public static void Main(string[] args)
    {
        // Define the maximum possible interest rate
        int maximumInterest = 50;
        decimal principal;

        // Input deposit amount
        while (true)
        {
            Console.Write("Enter the deposit amount: ");
            string principalInput = Console.ReadLine();

            if (decimal.TryParse(principalInput, out principal) && principal >= 0)
                break;

            Console.WriteLine("The deposit cannot be negative. Please try again.");
        }

        decimal interest;

        // Input interest rate
        while (true)
        {
            Console.Write("Enter the interest rate: ");
            string interestInput = Console.ReadLine();

            if (decimal.TryParse(interestInput, out interest) && interest > 0 && interest <= maximumInterest)
                break;

            Console.WriteLine($"The interest rate cannot be negative or exceed {maximumInterest}. Please try again.");
        }

        int duration;

        // Input deposit term
        while (true)
        {
            Console.Write("Enter the number of years: ");
            string durationInput = Console.ReadLine();

            if (int.TryParse(durationInput, out duration) && duration > 0)
                break;

            Console.WriteLine("The term must be a positive number. Please try again.");
        }

        // Display the entered values
        Console.WriteLine();
        Console.WriteLine($"Deposit = {principal}");
        Console.WriteLine($"Interest rate = {interest}%");
        Console.WriteLine($"Term = {duration} years");
        Console.WriteLine();

        // Calculation for each year
        for (int year = 1; year <= duration; year++)
        {
            decimal interestPaid = principal * (interest / 100);
            principal += interestPaid;
            principal = decimal.Round(principal, 2); // Round to two decimal places
            Console.WriteLine($"{year}-year: {principal} currency units");
        }

        // Wait for the user to end the program
        Console.WriteLine("Press <Enter> to exit the program...");
        Console.ReadLine();
    }
}
