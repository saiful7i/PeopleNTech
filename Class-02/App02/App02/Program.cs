using System;
using System.IO;
using System.Net.Sockets;


namespace App03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int score = 0;
            string name = "Test Score";
            bool isPassed = false;

            Console.Write("Please Enter Your Score:");
            score = Convert.ToInt32(Console.ReadLine());

            if (score >= 50)
            {
                isPassed = true;
            }

            if (isPassed == true)
            {
                Console.WriteLine("Congratulation ! ");
            }
            else
            {
                Console.WriteLine("Sorry ! Try again.");
            }

            double purchase;
            double sale;
            double shopRent;
            double emp_salary;
            double stock_value;
            double profit_loss;
            double other_expenses;
            bool isProfitable = false;

            double totalExpenses;
            double totalIncome;

            Console.Write("Please Enter Purchase Amount:");
            purchase = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("Please Enter Sale Amount:");
            sale = Convert.ToDouble(Console.ReadLine());

            Console.Write("Please Enter Shop Rent Amount:");
            shopRent = Convert.ToDouble(Console.ReadLine());

            Console.Write("Please Enter Employee Salary Amount:");
            emp_salary = Convert.ToDouble(Console.ReadLine());

            Console.Write("Please Enter Stock Value Amount:");
            stock_value = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("Please Enter Other Expenses Amount:");
            other_expenses = Convert.ToDouble(Console.ReadLine());

            totalExpenses = purchase-stock_value + shopRent + emp_salary  + other_expenses;

            totalIncome = sale;

            if (sale > totalExpenses)
            {
                profit_loss = totalIncome - totalExpenses;
                isProfitable = true;
            }
            else
            {
                profit_loss = totalExpenses - totalIncome;
            }

            Console.WriteLine($"Total Purchase          : {purchase}");
            Console.WriteLine($"Total Shop Rent         : {shopRent}");
            Console.WriteLine($"Total Employee Salary   : {emp_salary}");
            Console.WriteLine($"Total Other Expenses    : {other_expenses}");
            Console.WriteLine($"Minus Total Stock (-)   : {stock_value}");  
            Console.WriteLine("==============================================");
            Console.WriteLine($"Total Expenses          : {totalExpenses}\n\n");
            Console.WriteLine($"Total Sales             : {sale}");
            Console.WriteLine("==============================================");
            Console.WriteLine($"Net Amount (Profit/Loss): {profit_loss}");
            Console.WriteLine("==============================================");
            if (isProfitable==true)
            {
                Console.WriteLine("Congratulations! Your business is profitable.");
            }
            else
            {
                Console.WriteLine("Unfortunately, your business is not profitable.");
            }


            Console.ReadKey();

        }

    }

}
