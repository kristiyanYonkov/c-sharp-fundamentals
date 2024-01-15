namespace HelloGitHub
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, GitHub!");

            Employee employeeOne = new Employee("Georgi", "Parvano", 58, "President", "Sofia", "Public Affairs");
            employeeOne.DisplayEmployeeInfo();
        }

    }
}
