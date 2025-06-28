using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount();
            /*
            account.Deposit(500);
            account.GetBalance();
            account.Deposit(2500.0);
            account.GetBalance();
            account.Deposit(350);
            account.GetBalance();

            account.WithDraw(700);
            account.GetBalance();

            account.WithDraw(200);
            account.GetBalance();

            account.WithDraw(2600);
            account.GetBalance();
            */

            string course = "ASP.NET Core MVC with Sql Server";
            Console.WriteLine(course.ToUpper());
            Console.WriteLine(course.ToLower());
            Console.WriteLine(course.Substring(8,4));
            Console.WriteLine(course.Substring(8, 4).ToUpper());
            /*
            Person p1 = new Person();
            p1.Name = "Md. Saiful Islam";
            p1.Age = 23;
            p1.Country = "Bangladesh";

            p1.ShowPersonInfo();

            Person p2 = new Person() { Name="Hasan Mamud",Age=30,Country="Canada"};
            p2.ShowPersonInfo();

            Person p3 = new Person("Moinul Islam",35);
            p3.ShowPersonInfo();*/


            Console.ReadLine();
        }
    }

    class BankAccount
    {
        private double Balance;
        private const double WithdeawalCharge = 2.0; 
        public BankAccount() {}
        public BankAccount(double op_balance) 
        {
            this.Balance = op_balance;
        }

        public void Deposit(double amount)
        {
            this.Balance += amount;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Successfully Deposited.");
        }

        public void WithDraw(double amount)
        {
            double withDrawCharge= amount + WithdeawalCharge;
            if (this.Balance >= amount)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                this.Balance =Balance- withDrawCharge;
                Console.WriteLine($"{amount} Tk Withdrawal Successful.");
                Console.WriteLine($"{WithdeawalCharge} Tk is Taken as Charge.");

                Console.WriteLine($"Your Current Balance {Balance}.");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Sorry ! In sufficient Balance");

            }
            
        }

        public double GetBalance()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"Current Balance = {this.Balance}");
            return this.Balance;
        }
    }

    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Country {  get; set; }

        public Person() { }
        public Person(string name, int age) 
        {
            Name = name;
            Age = age;
            Country = "Bangladesh";
        }
        public Person(string name, int age, string country ) 
        {
            Name = name;
            Age = age;
            Country = country;
        }


        public void ShowPersonInfo()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\t============================================");
            Console.WriteLine();
            Console.WriteLine($"\tPerson Name : {this.Name.ToUpper()}\n");
            Console.WriteLine($"\tPerson age: {this.Age}\n");
            Console.WriteLine($"\tPerson country : {this.Country.ToUpper()} ");

        }
        
    }
}
