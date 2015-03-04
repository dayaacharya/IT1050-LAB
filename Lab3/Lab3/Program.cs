using System;


namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Tell me your gender? : (M/f) ");
            string gender = Console.ReadLine().ToLower();
            Console.Write("Tell me your eye color? ");
            string eyeColor = Console.ReadLine().ToLower();
            bool isMale = gender == "m";
            bool isFemale = gender == "f";

            if (isMale && eyeColor == "blue")
            {

                Console.WriteLine("Hello" + "Joe");
            }

            if (isMale && eyeColor == "brown")
            {

                Console.WriteLine("Hello" + "Dave");
            }

            if (isMale && eyeColor == "green")
            {

                Console.WriteLine("Hello" + "John");
            }


            if (isFemale && eyeColor == "blue")
            {

                Console.WriteLine("Hello" + "Sally");
            }

            if (isFemale && eyeColor == "brown")
            {

                Console.WriteLine("Hello" + "Jane");
            }

            if (isFemale && eyeColor == "green")
            {

                Console.WriteLine("Hello" + "Phoebe");

            }

            Console.ReadLine();
        }
    }
}




