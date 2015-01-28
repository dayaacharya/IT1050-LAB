using System;

namespace labsolution
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName;
            char middleInitial;
            string lastName;
            string fullName;
            int age;
            bool iscitizen;
            bool canvote;
            int heightfeet;
            double heightinches;
            double totalheightCm;

            firstName = "Daya";
            middleInitial = 'R';
            lastName = "Acharya";
            fullName = firstName + middleInitial + "." + lastName;

            age = 26;
            heightfeet = 5;
            heightinches = 8;
            double totalinches = heightfeet * 12 + heightinches;
            totalheightCm = 2.54 * totalinches;

            iscitizen = true;
            bool isoldenoughtovote = age >= 18;
            canvote = iscitizen && isoldenoughtovote;

        }
    }
}
