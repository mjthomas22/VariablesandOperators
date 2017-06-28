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
            //string donorname = "";
            //string donoraddress = "";
            //string donoremail = "";
            //string fiscalyear = "";

            //Console.Writeline("donors name");
            //donorname = console.readline();

            //console.writeline("donors address");
            //donoraddress = console.readline();

            //console.writeline("donors email");
            //donoremail = console.readline();

            //console.writeline("fiscal year");
            //fiscalyear = console.readline();

            //console.writeline("how many quarters?");
            //double quarters = double.parse(console.readline()) * .25;

            //console.writeline("how many ones?");
            //int ones = int.parse(console.readline());

            //console.writeline("how many fives?");
            //int fives = int.parse(console.readline()) * 5;

            //console.writeline("how many tens?");
            //int tens = int.parse(console.readline()) * 10;

            //console.writeline("how many twenties?");
            //int twenties = int.parse(console.readline()) * 20;

            //console.writeline("how many fifties?");
            //int fifties = int.parse(console.readline()) * 50;

            //console.writeline("how many hundreds?");
            //int hundreds = int.parse(console.readline()) * 100;


            //console.writeline("name of donor: " + donorname);
            //console.writeline("donor's address: " + donoraddress);
            //console.writeline("donor's email: " + donoremail);
            //console.writeline("fiscal year: " + fiscalyear);
            //double donationamount = (quarters + ones + fives + tens + twenties + fifties + hundreds);
            //console.writeline("donatated amount:$ " + donationamount);

            //Types of shirts
            double superSwim;
            double theShark;
            double babyBubble;

            Console.WriteLine("Welcome to the swim team fundraiser!");

            //How many shirts
            Console.WriteLine("How many Super Swim shirts would you like?");
            superSwim = double.Parse(Console.ReadLine());

            Console.WriteLine("How many Be the Shark shirts would you like?");
            theShark = double.Parse(Console.ReadLine());

            Console.WriteLine("How many Baby Bubble shirts would you like?");
            babyBubble = double.Parse(Console.ReadLine());

            //Reciept

            Console.WriteLine("Thank you for your support!");
            Console.WriteLine("You purchased " +(superSwim +theShark+ babyBubble) +" Shirts");
            

            // Total and taxes

            double subTotal = ((superSwim * 15.00) + (theShark * 17.50) + (babyBubble * 4.75));
            double taxes = (subTotal * .08)+subTotal;

            Console.WriteLine("Subtotal ${0}", subTotal);
            Console.WriteLine("8% Taxes");
            Console.WriteLine("Grand Total ${0}", taxes);





        }
    }
}
