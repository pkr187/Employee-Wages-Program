namespace AbilitytoCompute
{
    internal class Program
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
        public static int ComputeEmpWage(string company, int empRatePerHrs, int numofWorkingDays, int MaxHoursPerMonth)
        {
            //variable
            int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;
            //computation
            while (totalEmpHrs <= MaxHoursPerMonth && totalWorkingDays < numofWorkingDays)
            {
                totalWorkingDays++;
                Random random = new Random();
                int empcheck = random.Next(0, 3);
                switch (empcheck)
                {
                    case IS_PART_TIME:
                        empHrs = 4;
                        break;
                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                totalEmpHrs += empHrs;
                Console.WriteLine("days#:" + totalWorkingDays + " + Emp Hrs : " + empHrs);
            }
            int totalEmpWage = totalEmpHrs * empRatePerHrs;
            Console.WriteLine("Total Emp Wage for company : " + company + " is: " + totalEmpWage);
            return totalEmpWage;
        }
        static void main(String[] args)
        {
            ComputeEmpWage("DMart", 20, 2, 10);
            ComputeEmpWage("Relience", 20, 4, 10);
        }
    }
}


        
       