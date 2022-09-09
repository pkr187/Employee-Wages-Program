using System.Runtime.CompilerServices;

namespace AbilitytoSave
{
    internal class EmpWageBuilderObject
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FUL_TIME = 2;

        private string Company;
        private int empRatePerHour;
        private int numofWorkingDays;
        private int maxHoursPerMnth;
        private int totalEmpWage;
        public EmpWageBuilderObject (string company,int empRatePerHour,int numofWorkingDays,int maxHoursPerMonth)
        {
            this.Company = company;
            this.empRatePerHour = empRatePerHour;
            this.numofWorkingDays = numofWorkingDays;
            this.maxHoursPerMnth = maxHoursPerMonth;
        }
        public void ComputeEmpWage()
        {
            //variable
            int empHrs = 0, totaEmpHrs = 0, totaworkingdays = 0;
            int totaEmpHr = 0;
            //computation
            while (totaEmpHr <= this.maxHoursPerMnth  && totaworkingdays < this.numofWorkingDays )
            {
                totaworkingdays++;
                Random random = new Random();
                int empcheck = random.Next(0, 3);
                switch (empcheck)
                {
                    case IS_PART_TIME:
                        empHrs = 4;
                        break;
                    case IS_FUL_TIME :
                        empHrs = 8;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                totaEmpHr += empHrs;
                Console.WriteLine("days#:" + totaworkingdays + " + Emp Hrs : " + empHrs);
            }
            totalEmpWage = totaEmpHrs  * this.empRatePerHour;
            Console.WriteLine("Total Emp Wage for the company: " + Company + " is " +totalEmpWage);
        }
        public string toString()
        {
            return "Total Emp Wage for company:" + this.Company  + " is: " + this.totalEmpWage;
        }

    }
}