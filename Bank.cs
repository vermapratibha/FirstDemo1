using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDemo1
{
    //internal class Bank
    //{
    //    private decimal balance;

  
    //    public Bank(decimal initialBalance)
    //    {
    //        if (initialBalance < 0)
    //        {
    //            Console.WriteLine("Initial balance cannot be negative. Setting balance to 0.");
    //            balance = 0;
    //        }
    //        else
    //        {
    //            balance = initialBalance;
    //        }
    //    }

    //    public void Deposit(decimal amount)
    //    {
    //        if (amount > 0)
    //        {
    //            balance += amount;
    //            Console.WriteLine($"Successfully deposited {amount:C}. Current Balance: {balance:C}");
    //        }
    //        else
    //        {
    //            Console.WriteLine("Deposit amount must be positive.");
    //        }
    //    }


    //    public void Withdraw(decimal amount)
    //    {
    //        if (amount > 0 && amount <= balance)
    //        {
    //            balance -= amount;
    //            Console.WriteLine($"Successfully withdrew {amount:C}. Current Balance: {balance:C}");
    //        }
    //        else if (amount > balance)
    //        {
    //            Console.WriteLine("Insufficient balance. Withdrawal failed.");
    //        }
    //        else
    //        {
    //            Console.WriteLine("Withdrawal amount must be positive.");
    //        }
    //    }

        
    //    public void DisplayBalance()
    //    {
    //        Console.WriteLine($"Current Balance: {balance:C}");
    //    }
    //}
    //static void main(String [] args)
    //    {
    //        Console.Write("Enter initial balance: ");
    //        decimal initialBalance = decimal.Parse(Console.ReadLine());
    //        Bank account = new Bank(initialBalance);

            
    //        bool running = true;
    //        while (running)
    //        {
    //            Console.WriteLine("\nChoose an option:");
    //            Console.WriteLine("1. Deposit");
    //            Console.WriteLine("2. Withdraw");
    //            Console.WriteLine("3. Display Balance");
    //            Console.WriteLine("4. Exit");
    //            Console.Write("Enter your choice: ");
    //            int choice = int.Parse(Console.ReadLine());

    //            switch (choice)
    //            {
    //                case 1:
    //                    Console.Write("Enter amount to deposit: ");
    //                    decimal depositAmount = decimal.Parse(Console.ReadLine());
    //                    account.Deposit(depositAmount);
    //                    break;

    //                case 2:
    //                    Console.Write("Enter amount to withdraw: ");
    //                    decimal withdrawAmount = decimal.Parse(Console.ReadLine());
    //                    account.Withdraw(withdrawAmount);
    //                    break;

    //                case 3:
    //                    account.DisplayBalance();
    //                    break;

    //                case 4:
    //                    Console.WriteLine("Thank you for using the banking system. Goodbye!");
    //                    running = false;
    //                    break;

    //                default:
    //                    Console.WriteLine("Invalid choice. Please try again.");
    //                    break;
    //            }
    //        }
    //}
}
