using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electricity_Bill
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string n="n";
            do
            {
                double unit;
                Console.Write("Please Enter the Unit:");
                unit = Convert.ToDouble(Console.ReadLine());
                //Console.WriteLine($"Unit Type: {CheckUnitType(unit)}");
                string unitType = CheckUnitType(unit);
                Console.WriteLine("=================Electricity Bill Calculator===============");
                CalculateBill(unit, unitType);
                Console.WriteLine("\n=================Electricity Bill Calculator===============");

                Console.Write("Do you want to calculate again? (Y/N): ");
                n = Console.ReadLine();

            } while (n.ToUpper() == "Y");
            
        }

        static string CheckUnitType(double unit)
        {
            
            if (unit > 0 && unit <= 50.0)
            {
                return "L";  //Life Line Unit Price 4.63
            }
            else if(unit > 50.0 && unit <= 75.0)
            {
                return "A";  //1st step Unit Price 5.26
            }
            else if(unit >=76 && unit <= 200)
            {
                return "B";  //2nd step Unit Price 7.20
            }
            else if (unit >= 201 && unit <= 300)
            {
                return "C";  //3rd step Unit Price 7.59
            }
            else if(unit >= 301 && unit <= 400)
            {
                return  "D";  //4th step Unit Price 8.02
            }
            else if(unit >= 401 && unit <= 600)
            {
                return "E";  //5th step Unit Price 12.67
            }
            else if(unit > 600)
            {
                return "F";  //6th step Unit Price 14.61
            }

            else
            {
                return "Invalid Unit";  // If the unit is negative or not a number
            }
        }

        static double CalculateBill(double unit, string unitType)
        {
            double bill = 0.0;
            switch (unitType)
            {
                case "L":
                    bill = unit * 4.63;
                    Console.WriteLine($"Your Unit Type is: Life Line\n");
                    Console.WriteLine($"Life Line Type Bill {unit} * 4.63     = {unit * 4.63}TK");
                    Console.WriteLine($"-------------------------------------------------");
                    Console.WriteLine($"Total Electricity Bill            = {bill}TK");
                    break;
                case "A":
                    bill = unit * 5.26;
                    Console.WriteLine($"Your Unit Type is: 1st Step\n");
                    Console.WriteLine($"1st Step Type Bill {unit} * 5.26    = {unit * 5.26}TK");
                    Console.WriteLine($"-------------------------------------------------");
                    Console.WriteLine($"Total Electricity Bill          = {bill}TK");
                    break;
                case "B":
                    bill = (75*5.26)+((unit-75)*7.20);
                    Console.WriteLine($"Your Unit Type is: 2nd Step\n");
                    Console.WriteLine($"1st Step Bill 75 * 5.26            = {5.26 * 75} TK");
                    Console.WriteLine($"2nd Step Type Bill {unit - 75} * 7.20       = {(unit - 75) * 7.20}TK");
                    Console.WriteLine($"-------------------------------------------------");
                    Console.WriteLine($"Total Electricity Bill             = {bill}TK");
                    break;
                case "C":
                    bill = (75 * 5.26) + (125 * 7.20) + ((unit - 200) * 7.59);
                    Console.WriteLine($"Your Unit Type is: 3rd Step\n");
                    Console.WriteLine($"1st Step Type Bill 75 * 5.26       = {5.26 * 75} TK");
                    Console.WriteLine($"2nd Step Type Bill 125 * 7.20      = {125 * 7.20}TK");
                    Console.WriteLine($"3rd step Type Bill {unit - 200} * 7.59      = {(unit - 200) * 7.59}TK");
                    Console.WriteLine($"-------------------------------------------------");
                    Console.WriteLine($"Total Electricity Bill                = {bill}TK");
                    break;
                case "D":
                    bill = (75 * 5.26) + (125 * 7.20) + (100 * 7.59) + ((unit - 300) * 8.02);
                    Console.WriteLine($"Your Unit Type is: 4th Step\n");
                    Console.WriteLine($"1st Step Type Bill 75 * 5.26       = {5.26 * 75} TK");
                    Console.WriteLine($"2nd Step Type Bill 125 * 7.20      = {125 * 7.20}TK");
                    Console.WriteLine($"3rd Step Type Bill 100 * 7.59      = {100 * 7.59}TK");
                    Console.WriteLine($"4th Step Type Bill {unit - 300} * 8.02      = {(unit - 300) * 8.02}TK");
                    Console.WriteLine($"-------------------------------------------------");
                    Console.WriteLine($"Total Electricity Bill                = {bill}TK");
                    break;
                case "E":
                    bill = (75 * 5.26) + (125 * 7.20) + (100 * 7.59) +(100 * 8.02) + ((unit - 400) * 12.67);
                    Console.WriteLine($"Your Unit Type is: 5th Step\n");
                    Console.WriteLine($"1st Step Type Bill 75 * 5.26       = {5.26 * 75} TK");
                    Console.WriteLine($"2nd Step Type Bill 125 * 7.20      = {125 * 7.20}TK");
                    Console.WriteLine($"3rd Step Type Bill 100 * 7.59      = {100 * 7.59}TK");
                    Console.WriteLine($"4th Step Type Bill 100 * 8.02      = {100 * 8.02}TK");
                    Console.WriteLine($"5th Step Type Bill {unit - 400} * 12.67     = {(unit - 400) * 12.67}TK");
                    Console.WriteLine($"-------------------------------------------------");
                    Console.WriteLine($"Total Electricity Bill                = {bill}TK");
                    break;
                case "F":
                    bill = (75 * 5.26) + (125 * 7.20) + (100 * 7.59) + (100 * 8.02) + (200 * 12.67) + ((unit - 600) * 14.61);
                    Console.WriteLine($"Your Unit Type is: 6th Step\n");
                    Console.WriteLine($"1st Step Type Bill 75 * 5.26       = {5.26 * 75} TK");
                    Console.WriteLine($"2nd Step Type Bill 125 * 7.20      = {125 * 7.20}TK");
                    Console.WriteLine($"3rd Step Type Bill 100 * 7.59      = {100 * 7.59}TK");
                    Console.WriteLine($"4th Step Type Bill 100 * 8.02      = {100 * 8.02}TK");
                    Console.WriteLine($"5th Step Type Bill 200 * 12.67     = {200 * 12.67}TK");
                    Console.WriteLine($"6th Step Type Bill {unit - 600} * 14.61     = {(unit - 600) * 14.61}TK");
                    Console.WriteLine($"-------------------------------------------------");
                    Console.WriteLine($"Total Electricity Bill                = {bill}TK");
                    break;
                default:
                    Console.WriteLine("Invalid Unit Type");
                    break;
            }
            return bill;
        }

    }
}
