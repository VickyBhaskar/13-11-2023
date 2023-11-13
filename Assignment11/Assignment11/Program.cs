using System;
namespace SalaryCalculationSystem;
internal class Program
{
    static void Main(string[]args)
    {
        Console.WriteLine("Employee Salary Calculation System");

        // Choose the type of employee
        Console.WriteLine("Choose Employee Type:");
        Console.WriteLine("1. HR");
        Console.WriteLine("2. Admin");
        Console.WriteLine("3. Software Developer");

        if (!int.TryParse(Console.ReadLine(), out int employeeType))
        {
            Console.WriteLine("Invalid input for employee type. Please enter a valid number.");
            return;
        }

        // Call the CalculateSalary method based on the chosen employee type
        switch (employeeType)
        {
            case 1:
                if (GetInput(out int hrWorkingHours, "Enter working hours") &&
                    GetInput(out int hrWorkingDays, "Enter number of working days"))
                {
                    double hrSalary = CalculateSalary(hrWorkingHours, hrWorkingDays);
                    Console.WriteLine($"Monthly Salary for HR: ${hrSalary}");
                }
                break;

            case 2:
                if (GetInput(out int adminWorkingHours, "Enter working hours") &&
                    GetInput(out int adminWorkingDays, "Enter number of working days") &&
                    GetInput(out int projectHandles, "Enter number of project handles"))
                {
                    double adminSalary = CalculateSalary(adminWorkingHours, adminWorkingDays, projectHandles);
                    Console.WriteLine($"Monthly Salary for Admin: ${adminSalary}");
                }
                break;

            case 3:
                if (GetInput(out int devWorkingHours, "Enter working hours") &&
                    GetInput(out int devWorkingDays, "Enter number of working days") &&
                    GetInput(out int devProjectHandles, "Enter number of project handles") &&
                    GetInput(out int devExtras, "Enter extra tasks"))
                {
                    double devSalary = CalculateSalary(devWorkingHours, devWorkingDays, devProjectHandles, devExtras);
                    Console.WriteLine($"Monthly Salary for Software Developer: ${devSalary}");
                }
                break;

            default:
                Console.WriteLine("Invalid choice");
                break;
        }
        Console.ReadKey();
    }

    // Method to calculate monthly salary with optional parameters
    static double CalculateSalary(int workingHours, int workingDays, int projectHandles = 0, int extras = 0)
    {
        return workingHours * workingDays * 100 + projectHandles * 3000 + extras * 2000;
    }

    // Method to get input from the user 
    static bool GetInput(out int result, string prompt)
    {
        Console.Write($"{prompt}: ");
        if (int.TryParse(Console.ReadLine(), out result))
        {
            return true;
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
            return false;
        }
    }
}
