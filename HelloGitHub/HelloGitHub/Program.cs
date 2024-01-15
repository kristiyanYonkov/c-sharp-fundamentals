namespace HelloGitHub
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, GitHub!");

            Employee employeeOne = new Employee("Georgi", "Parvano", 58, "President", "Sofia", "Public Affairs");
            employeeOne.DisplayEmployeeInfo();

            Console.WriteLine();

            Company companyOne = new Company("BitSerious", 1888, "Belgrade", true);
            companyOne.DisplayCompanyInfo();

            Console.WriteLine();

            Vehicle vehicleOne = new Vehicle("Volvo XC90", "Petrol", "automatic", 2024);
            vehicleOne.DisplayVehicleInfo();
        }

    }
}
