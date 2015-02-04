
namespace example2
{
    class person
    {
        public string FirstName;
        public string LastName;

        public string GetFullName()
        {
            return this.FirstName + " " + this.LastName;
        }
     }
}