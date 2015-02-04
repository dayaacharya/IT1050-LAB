

namespace example2
{
    class Program
    {
        static void Main(string[] args)
        {
            person Daya = new person();
            person radha = new person();
            person oldest = Daya;

            Daya.FirstName = "Ram";
            Daya.LastName = "Acharya";

            radha.FirstName = "Radha";
            radha.LastName = "Dahal";

            string result1 = Daya.GetFullName();
            string result2 = radha.GetFullName();

        }
    }
}
