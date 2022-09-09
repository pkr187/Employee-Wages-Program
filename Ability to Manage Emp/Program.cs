namespace Ability_to_Manage_Emp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EmpWageBuilderArray empWageBuilder = new EmpWageBuilderArray();
            empWageBuilder.addCompanyEmpWage("DMart", 20, 2, 50);
            empWageBuilder.addCompanyEmpWage("Reliance", 100, 4, 20);
            empWageBuilder.computeEmpWage();


        }
    }
}