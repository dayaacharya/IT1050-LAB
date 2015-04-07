using System;


namespace Lab4_final
{
    class AverageAge
    {
         private double _sumOfAllAges;
        private int _totalNumberOfPeople;
       
       public double Get()
        {
            return (double)_sumOfAllAges /(double) _totalNumberOfPeople;
       }
       public void AddPerson(Person person)
       {
           _totalNumberOfPeople++;
           _sumOfAllAges += person.Age;
       }
    }
}
