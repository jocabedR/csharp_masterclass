namespace InheritanceC2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Employee jocaEmployee = new Employee("Jocabed", "Ríos", 1000000000.00f);
            jocaEmployee.Work();
            jocaEmployee.Pause();

            Boss jocaBoss = new Boss("Jocabed Boss", "Ríos", 10000000000.00f, "Bochito");
            jocaBoss.Work();
            jocaBoss.Pause();
            jocaBoss.Lead();

            Trainee jocaTrainee = new Trainee("Jocabed Boss", "Ríos", 100000000.00f, 40, 0);
            jocaTrainee.Work();
            jocaTrainee.Pause();
            jocaTrainee.Learn();

        }
    }
}