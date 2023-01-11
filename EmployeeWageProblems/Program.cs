namespace EmployeeWageProblems
{
    public class Program
    {
        static void Main(string[] args)
        {
            EmpEageBuilderObject Airtel = new EmpEageBuilderObject("Airtel", 30, 30, 100);
            EmpEageBuilderObject TCS = new EmpEageBuilderObject("TCS", 40, 30, 80);
            EmpEageBuilderObject Wipro = new EmpEageBuilderObject("Wipro", 25, 25, 120);
            EmpEageBuilderObject Cipla = new EmpEageBuilderObject("Cipla", 23, 28, 111);
            Airtel.computeEmpWage();
            Console.WriteLine(Airtel.toString());
            TCS.computeEmpWage();
            Console.WriteLine(TCS.toString());
            Wipro.computeEmpWage();
            Console.WriteLine(Wipro.toString());
            Cipla.computeEmpWage();
            Console.WriteLine(Cipla.toString());
        }
    }
}

