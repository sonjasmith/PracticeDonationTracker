using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Donaton_Tracker
{
    class Program
    {
        static void Main(string[] args)
        {

            //string name = "client";
            //Console.WriteLine(name);

            //string address = "client address";
            //Console.WriteLine(address);

            //string email = "client email";
            //Console.WriteLine(email);

            //string fiscalYear = "year";
            //Console.WriteLine(fiscalYear);

            //string donationAmount = "amount";
            //Console.WriteLine(donationAmount);

            Console.WriteLine("Welcome to Movie Non Profit");
            Console.WriteLine("What is your name?");
            string donorName = Console.ReadLine();
            Console.WriteLine("What is your address?");
            string donorAddress = string.Concat(Console.ReadLine());
            Console.WriteLine("What is your email address?");
            string donorEmail = Console.ReadLine();
            Console.WriteLine("What is the year ?");
            String donorYear = Console.ReadLine();
            //asking for the donation amounts
            Console.WriteLine("How many quarters are you donating?");
            int quarterAmount = int.Parse(Console.ReadLine());
            Console.WriteLine("How many One Dollar Bills are you donating ?");
            int oneDollarAmount = int.Parse(Console.ReadLine());
            Console.WriteLine("How many Five Dollar Bills are you donating ?");
            int fiveDollarAmount = int.Parse(Console.ReadLine());
            Console.WriteLine("How many Ten Dollar bills are you donating ?");
            int tenDollarAmount = int.Parse(Console.ReadLine());
            Console.WriteLine("How many twenty dollar bills are you donating ?");
            int twentyDollarAmount = int.Parse(Console.ReadLine());
            Console.WriteLine("How many fifty dollar bills are you donating ?");
            int fiftyDollarAmount = int.Parse(Console.ReadLine());
            Console.WriteLine("How many hundred dollar bills are you donating ?");
            int hundredDollarAmount = int.Parse(Console.ReadLine());
            //doing the math
            double donationAmount = (oneDollarAmount + fiveDollarAmount * 5 + tenDollarAmount * 10 + twentyDollarAmount * 20 + fiftyDollarAmount * 50 + hundredDollarAmount * 100 + quarterAmount * 0.25);
            //printing out the receipt
            Console.WriteLine("Thank you for your donation! The amount donated is $" + donationAmount);
            Console.WriteLine("Donor name:" + donorName);
            Console.WriteLine("Donor address:" + donorAddress);
            Console.WriteLine("Donor email:" + donorEmail);
            Console.WriteLine("Year of donation:" + donorYear);





        }
    }
}
