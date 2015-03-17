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

            Console.Write("Drink or stuff(Y/N).............:");
            string Drink = Console.ReadLine().ToLower();            
        
    
            Console.Write("Type of Drinks or stuff smallsoda,popcorn,largesoda,candy,hotdog,(y/n).....:");
            Console.ReadLine();           
            

            Console.Write("evening(y/n) :");
            Console.ReadLine();            

            bool evening = Console.ReadLine().ToLower().StartsWith("Y");            

            double pricetotal  = 0;

            if (evening)
            {
              if(Drink == "smallsoda"){  pricetotal = (childnumber * 6.99) + 3.50;}
              if(Drink == "smallsoda"){pricetotal = (adultnumber * 10.99) + 3.50;}
              if(Drink == "smallsoda"){ pricetotal = (seniorsnumber * 8.50) + 3.50;}

            }
            if (evening) 
            {
              if(Drink  == "largesoda"){pricetotal= (childnumber * 6.99) + 5.99;}
              else if (Drink == "largesoda") { pricetotal = (adultnumber * 10.99) + 5.99; }
              else if (Drink == "largesoda") { pricetotal = (seniorsnumber * 8.50) + 5.99; }
                
            }
            if (evening) 
            {
              if(Drink == "popcorn") {pricetotal = (childnumber * 6.99) + 4.50;}
              else if(Drink == "popcorn") {pricetotal = (adultnumber * 10.99) + 4.50;}
              else if (Drink == "Popcorn") { pricetotal = (seniorsnumber * 8.50) + 4.50; }
            }
            if (evening)
            {
                if (Drink == "Candy") { pricetotal = (childnumber * 6.99) + 1.99; }
                else if(Drink=="Candy") {pricetotal = (adultnumber * 10.99) + 1.99;}
                else if (Drink == "Candy") { pricetotal = (seniorsnumber * 8.50) + 1.99; }
            }
            if (evening)
            {
                if (Drink == "hotdog") { pricetotal = (childnumber * 6.99) + 3.99; }
                else if (Drink == "hotdog") { pricetotal = (adultnumber * 10.99) + 3.99;}
                else if (Drink == "hotdog") { pricetotal = (adultnumber * 8.50) + 3.99; }
            }

            else
            {
                pricetotal = childnumber * 3.99;
                pricetotal = adultnumber * 5.99;
                pricetotal = seniorsnumber * 4.50;
            }
            Console.WriteLine(pricetotal + "." );
            Console.ReadKey();

                    

            }
        }
    }
