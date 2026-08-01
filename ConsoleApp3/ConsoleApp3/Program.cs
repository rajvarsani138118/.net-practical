using System;

namespace ConsoleApp3
{
    class Expense
    {
        int expenseeId;
        string category;
        double amount;

        public void getExpenseDetails()
        {
            Console.WriteLine("Enter Expense ID:");
            expenseeId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Expense Category:");
            category = Console.ReadLine();
            Console.WriteLine("Enter Amount:");
            amount = Convert.ToDouble(Console.ReadLine());

            // Manual Exception
            if (amount < 0)
            {
                throw new Exception("Amount cannot be negative.");
            }
        }
        public void showExpenseDetails()
        {
            Console.WriteLine("\n---- Expense Details ----");
            Console.WriteLine("Expense ID: " + expenseeId);
            Console.WriteLine("Expense Category: " + category);
            Console.WriteLine("Amount: " + amount);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Expense e = new Expense();

            try
            {
                e.getExpenseDetails();
                e.showExpenseDetails();
            }
            catch (FormatException)
            {
                Console.WriteLine("Format Exception: Please enter valid numeric values.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Manual Exception: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("Program executed successfully.");
            }
            Console.ReadKey();
        }
    }
}