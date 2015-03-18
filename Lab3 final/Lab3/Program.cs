using System;


namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("How many children..... :");
            int childnumber = int.Parse(Console.ReadLine());


            Console.Write("How many adults....... :");
            int adultnumber = int.Parse(Console.ReadLine());

            Console.Write("How many seniors...... :");
            int seniorsnumber = int.Parse(Console.ReadLine());

            Console.Write("Drink or stuff(y/n).............:");
            string Drink = Console.ReadLine().ToLower();


            Console.Write("how many smallsoda.....:");
            int smallsodanumber = int.Parse(Console.ReadLine());

            Console.Write("how many popcorn.......:");
            int popcornnumber = int.Parse(Console.ReadLine());

            Console.Write("How many hotdog.........:");
            int hotdognumber = int.Parse(Console.ReadLine());

            Console.Write("how many largesoda......:");
            int largesodanumber = int.Parse(Console.ReadLine());

            Console.Write("How many candy..........:");
            int candynumber = int.Parse(Console.ReadLine());

            Console.Write("evening(y/n) :");
            Console.ReadLine();

            bool evening = Console.ReadLine().ToLower().StartsWith("Y");

            double pricetotal = 0;
            double concessiontotal = 0;


            if (evening)
            {
                pricetotal = adultnumber * 10.99;
                pricetotal = childnumber * 6.99;
                pricetotal = seniorsnumber * 8.50;
            }
                       
            if (evening)
            {
                concessiontotal = hotdognumber * 3.99;
                concessiontotal = smallsodanumber * 3.50;
                concessiontotal = largesodanumber * 5.99;
                concessiontotal = popcornnumber * 4.50;
                concessiontotal = candynumber * 1.99;

            }
            else
            {
                pricetotal = childnumber * 3.99;
                pricetotal = adultnumber * 5.99;
                pricetotal = seniorsnumber * 4.50;
            }

            int discountcal = childnumber + adultnumber + seniorsnumber;

            if (discountcal > 3)
            {
                pricetotal = pricetotal - 2; 
            }

            Console.WriteLine(pricetotal + concessiontotal + discountcal +".");
            Console.ReadKey();



        }
    }
}
    

