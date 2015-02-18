using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace version2
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName;
            string middleInitial;
            string lastName;
            string fullName;
            int age;
            bool isCitizen;
            bool canVote;
            int heightFeet;
            double heightInches;
            double totalHeightCm;

            Console.Write("First Name     : ");
            firstName = Console.ReadLine();
            Console.Write("Middle Initial : ");
            middleInitial = Console.ReadLine();
            Console.Write("Last Name      : ");
            lastName = Console.ReadLine();
            fullName = firstName + " " + middleInitial + ". " + lastName;

            Console.Write("Age            : ");
            age = int.Parse(Console.ReadLine());
            Console.Write("Height Feet    : ");
            heightFeet = int.Parse(Console.ReadLine());
            Console.Write("Extra Inches   : ");
            heightInches = double.Parse(Console.ReadLine());
            double totalInches = heightFeet * 12 + heightInches;
            totalHeightCm = 2.54 * totalInches;

            Console.Write("Citizen?       : ");
            isCitizen = bool.Parse(Console.ReadLine());
            bool isOldEnoughToVote = age >= 18;
            canVote = isCitizen && isOldEnoughToVote;

            Console.WriteLine();
            Console.WriteLine("Your Full Name Is    ---> " + fullName);
            Console.WriteLine("Your Height in CM Is ---> " + totalHeightCm);
            Console.WriteLine("Your Voter Status Is ---> " + canVote);
            Console.ReadKey();

        }
    }
}
