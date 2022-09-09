namespace AbilitytoSave
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EmpWageBuilderObject dMart = new EmpWageBuilderObject("DMart", 20, 2, 10);
            EmpWageBuilderObject reliance  = new EmpWageBuilderObject("Reliance", 20, 2, 10);
            dMart.ComputeEmpWage();
            Console.WriteLine(dMart.toString());
            reliance.ComputeEmpWage();
            Console.WriteLine(reliance.toString());
        }
    }
}