using System;


namespace Lab2final
{
    class Program
    {
        static void Main(string[] args)
        {
            Person Tulsi = new Person();
            Tulsi.FirstName = "Tulsi";
            Tulsi.LastName = "Mishra";
            Console.WriteLine(Tulsi.GetFullName());

            Person Radha = new Person();
            Radha.FirstName = "Radha";
            Radha.LastName = "Dahal";
            Console.WriteLine(Radha.GetFullName());

            Pet Hem = new Pet();
            Hem.name = "Hem";
            Hem.age = 3;
            Hem.species = "Chinese";
            Hem.owner = Tulsi;

            Pet Hari = new Pet();
            Hari.name = "Hari";
            Hari.age = 4;
            Hari.species = "German";
            Hari.owner = Radha;

            Pet Sam = new Pet();
            Sam.name = "Sam";
            Sam.age = 5;
            Sam.species = "Pug";
            Sam.owner = Radha;

            Console.WriteLine(Hem.name + "," + Hem.age + "," + Hem.species + "," + Hem.owner.GetFullName());
            Console.WriteLine(Hari.name + "," + Hari.age + "," + Hari.species + "," + Hari.owner.GetFullName());
            Console.WriteLine(Sam.name + "," + Sam.age + "," + Sam.species + "," + Sam.owner.GetFullName());
            Console.ReadLine();
        }
     }
}
