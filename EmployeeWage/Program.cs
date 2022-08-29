using System;

namespace EmployeeWage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //constants
            int IS_FULL_TIME = 1;
            Random random = new Random();
            //Computation
            int empcheck = random.Next(0, 2);
            if (empcheck == IS_FULL_TIME)
            {
                Console.WriteLine("Employee is present");
            }
            else
            {
                Console.WriteLine("Employee is absent");
            }
        }
    }
}