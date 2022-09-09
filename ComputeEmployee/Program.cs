namespace ComputeEmployee
{
    internal class Program
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
        public const int EMP_RATE_PER_Hrs = 20;
        public const int NUM_OF_WORKING_DAYS = 2;
        public const int MAX_HRS_IN_MONTH = 10;
        public static int ComputeEmpWage()
        {
            int totalEmpHrs = 0;
            //variable
            int empHrs = 0, totaEmpHrs = 0, totaworkingdays = 0;
            int totaEmpHr = 0;
            //computation
            while (totaEmpHr <= MAX_HRS_IN_MONTH && totaworkingdays < NUM_OF_WORKING_DAYS)
            {
                totaworkingdays++;
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
                totaEmpHr += empHrs;
                Console.WriteLine("days#:" + totaworkingdays + " + Emp Hrs : " + empHrs);
            }
            int totalEmpWage = totalEmpHrs * EMP_RATE_PER_Hrs;
            Console.WriteLine("Total Emp Wage : " + totalEmpWage);
            return totalEmpHrs;
        }
        static void main(String[] args)
        {
            ComputeEmpWage();
        }
    }
}