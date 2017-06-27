using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace varandoperators
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("What is the name on your reservation");
            string reserveName = Console.ReadLine();

            Console.WriteLine("How many people are in your party");
            int numberOfPeople = int.Parse(Console.ReadLine());

            double amountEach = 13.53d;
            double totalBill = numberOfPeople * amountEach;
           
            Console.WriteLine("Reservation Name : {0}",reserveName);
            Console.WriteLine("Total Bill : ${0}", totalBill);

            String donorName = "";
            String donorAddress = "";
            String donorEmail = "";
            String fiscalYear = "";

            Console.WriteLine("Donors Name");
            donorName = Console.ReadLine();

            Console.WriteLine("Donors Address");
            donorAddress = Console.ReadLine();

            Console.WriteLine("Donors Email");
            donorEmail = Console.ReadLine();

            Console.WriteLine("Fiscal Year");
            fiscalYear = Console.ReadLine();

            Console.WriteLine("How many quarters?");
            double quarters = double.Parse(Console.ReadLine()) * .25;

            Console.WriteLine("How many ones?");
            int ones = int.Parse(Console.ReadLine());

            Console.WriteLine("How many fives?");
            int fives = int.Parse(Console.ReadLine()) * 5;

            Console.WriteLine("How many tens?");
            int tens = int.Parse(Console.ReadLine()) * 10;

            Console.WriteLine("How many twenties?");

            Console.WriteLine(donorName);
            Console.WriteLine(donorAddress);
            Console.WriteLine(donorEmail);
            Console.WriteLine(fiscalYear);
            double donationAmount = (quarters + ones + fives + tens);
            Console.WriteLine("$" + donationAmount);

        }
    }
}
