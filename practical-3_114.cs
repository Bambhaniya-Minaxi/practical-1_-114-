using System;
using System.Collections.Generic;

class InvalidExpenseException : Exception
{
    public InvalidExpenseException(string message) : base(message)
    {
    }
}
class Expense
{
    public string Category { get; set; }
    public double Amount { get; set; }
    public string Description { get; set; }
    public Expense(string category, double amount, string description)
    {
        Category = category;
        Amount = amount;
        Description = description;
    }
    public override string ToString()
    {

        return "Category: " + Category +
                       ", Amount: $" + Amount +
                       ", Description: " + Description;
    }
}
class ExpenseTracker
{
    static List<Expense> expenses = new List<Expense>();
    static void AddExpense()
    {
        try
        {
            Console.Write("Enter category: ");
            string category = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(category))
                throw new InvalidExpenseException("Category cannot be empty.");

            Console.Write("Enter amount: ");
            double amount = Convert.ToDouble(Console.ReadLine());

            if (amount <= 0)
                throw new InvalidExpenseException(
                    "Amount must be greater than 0.");

            Console.Write("Enter description: ");
            string description = Console.ReadLine();

            expenses.Add(new Expense(category, amount, description));

            Console.WriteLine("Expense added successfully!");
        }
        catch (FormatException)
        {
            Console.WriteLine("Please enter a valid amount.");
        }
        catch (InvalidExpenseException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
    static void ViewExpenses()
    {
        if (expenses.Count == 0)
        {
            Console.WriteLine("No expenses found.");
            return;
        }
        Console.WriteLine("\n--- Expense List ---");
        foreach (Expense e in expenses)
        {
            Console.WriteLine(e);
        }
    }

    static void CalculateTotal()
    {
        double total = 0;
        foreach (Expense e in expenses)
        {
            total += e.Amount;
        }
        Console.WriteLine("Total Expenses: $" + total);
    }
    static void Main()
    {
        while (true)
        {
            try
            {
                Console.WriteLine("\n===== EXPENSE TRACKER =====");
                Console.WriteLine("1. Add Expense");
                Console.WriteLine("2. View Expenses");
                Console.WriteLine("3. Calculate Total");
                Console.WriteLine("4. Exit");
                Console.Write("Enter choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        AddExpense();
                        break;
                    case 2:
                        ViewExpenses();
                        break;
                    case 3:
                        CalculateTotal();
                        break;
                    case 4:
                        Console.WriteLine("Thank you!");
                        return;
                    default:
                        Console.WriteLine("Invalid choice!");
                        break;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter a valid number.");
            }
        }
    }
}






