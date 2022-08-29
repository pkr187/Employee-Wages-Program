using System;

namespace EmployeeWage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //constants
            int IS_PART_TIME = 1;
            int IS_FULL_TIME = 2;
            int EMP_RATE_PER_Hrs = 20;
            //variable
            int empHrs = 0;
            int empWage = 0;
            Random random = new Random();
            //computation
            int empcheck = random.Next(0, 2);
            if (empcheck == IS_PART_TIME)
            {
                empHrs = 4;
            }
            else if (empcheck == IS_FULL_TIME)
            {
                empHrs = 8;
            }
            else
            {
                empHrs = 0;
            }
            empWage = empHrs * EMP_RATE_PER_Hrs;
            Console.WriteLine("Emp Wage : " + empWage!);
        }
    }
}