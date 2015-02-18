using System;

namespace Lab2final
{
    public class Person
    {
       public string FirstName;
       public string LastName;

       public string GetFullName()
       {
           return this.FirstName + "," + this.LastName;

       }
    }
}
