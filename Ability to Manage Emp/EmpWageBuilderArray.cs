namespace Ability_to_Manage_Emp
{
    internal class EmpWageBuilderArray
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
        private int numofcompany = 0;
            private companyEmpWage[] companyEmpWagArray;
        public EmpWageBuilderArray()
        {
            this.companyEmpWagArray = new companyEmpWage[5];
        }
            public void addCompanyEmpWage(string company, int empRatePerHour, int numofWorkingDays, int maxHoursPerMonth)
            {
                companyEmpWagArray[this.numofcompany ] = new companyEmpWage(company, empRatePerHour, numofWorkingDays, maxHoursPerMonth);
                numofcompany ++;
            }
            public void  computeEmpWage()
            {
                for (int i = 0; i < numofcompany ; i++)
                {
                    companyEmpWagArray[i].setTotalEmpWage(this.computeEmpWage(this.companyEmpWagArray[1]));
                    Console.WriteLine(this.companyEmpWagArray[i].tostring());
                }
            }
            private int computeEmpWage(companyEmpWage companyEmpWage)
            {
                //variable
                int empHrs = 0, totaEmpHrs = 0, totaworkingdays = 0;
                //computation
                while (totaEmpHrs  <= companyEmpWage.maxHoursPerMonth && totaworkingdays < companyEmpWage.numofWorkingDays)
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
                    totaEmpHrs  += empHrs;
                    Console.WriteLine("days#:" + totaworkingdays + " + Emp Hrs : " + empHrs);
                }
                return totaEmpHrs = companyEmpWage.empRatePerHour;
            }
    }
}
