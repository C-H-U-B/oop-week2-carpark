using System;

namespace parking_problem
{
    class Program
    {
        static void Main(string[] args)
        {
            customer popo = new customer(5,1);
            customer pupu = new customer(24,2);
            customer papa = new customer(18 ,3);
            
            
            Console.WriteLine(papa.CalculateCharges());
        }
    }
}