using System;


namespace Lab4_final
{
    class Person
    {
        public int Age;
        public string FirstName;
        public string LastName;
        public Person Spouse;

        public static Person Create(string label)
        {
            Person Ram = new Person();
            Ram.FirstName = Question.AskForString("Whats your FirstName");
            Ram.LastName = Question.AskForString("Whats your LastName");
            Ram.Age = Question.AskForInteger("Whats your Age");
            bool ismarried = Question.AskForBoolean("Are your married?(y/n)");

            if (ismarried)
            {
                Person Spouse = new Person();
                Ram.Spouse.FirstName = Question.AskForString("Whats your FirstName");
                Ram.Spouse.LastName = Ram.LastName;
                Ram.Spouse.Age = Question.AskForInteger("Whats your Age");
                Spouse.Spouse = Ram;
            }
            else
            {
                return Ram;
            }



        }
    }
}
