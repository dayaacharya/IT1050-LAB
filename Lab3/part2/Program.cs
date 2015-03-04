using System;


namespace part2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Tell me your gender? : (M/f) ");
            string gender = Console.ReadLine().ToLower();
            Console.Write("Tell me your eye color? ");
            string eyeColor = Console.ReadLine();
            bool isMale = gender == "m";
            bool isFemale = gender == "f";

            if (isMale && eyeColor == "blue")
            {
                Console.WriteLine("Hello" + "Joe");
            }
            
            if (isMale && eyeColor == "Brown")
            {
                Console.WriteLine("Hello" + "Dave");
            }
            
            if (isMale && eyeColor == "Green")
            {
                Console.WriteLine("Hello" + "John");
            }

            if (isFemale && eyeColor == "Blue")
            {
                Console.WriteLine("Hello" + "Sally");
            }

            if (isFemale && eyeColor == "Brown")
            {
                Console.WriteLine("Hello" + "Jane");
            }
            
            if (isFemale && eyeColor == "Green")
            {
                Console.WriteLine("Hello" + "Phoebe");
            }
            
            Console.ReadLine();
        
        }
    }
}
    

