using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment11
{
    internal class Program
    {
        static void Main(string[] args)
        {
                Console.WriteLine("Salary Calculation System");

                // Choose Employee Type
                Console.WriteLine("Choose Employee Type:");
                Console.WriteLine("1. HR");
                Console.WriteLine("2. Admin");
                Console.WriteLine("3. Software Developer");

                // Get user input for employee type
                int employeeType = Convert.ToInt32(Console.ReadLine());

                // Call the method to handle salary calculation based on the employee type
                CalculateSalary(employeeType);

                Console.ReadLine(); // Pause to see the result
            }

            static void CalculateSalary(int employeeType)
            {
                // Common inputs for all employee types
                Console.Write("Enter working hours: ");
                int workingHours = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter number of working days: ");
                int numberOfWorkingDays = Convert.ToInt32(Console.ReadLine());

                double salary = 0;

                // Switch based on the employee type
                switch (employeeType)
                {
                    case 1: // HR
                        salary = CalculateHRSalary(workingHours, numberOfWorkingDays);
                        break;

                    case 2: // Admin
                        Console.Write("Enter number of project handles: ");
                        int projectHandles = Convert.ToInt32(Console.ReadLine());
                        salary = CalculateAdminSalary(workingHours, numberOfWorkingDays, projectHandles);
                        break;

                    case 3: // Software Developer
                        Console.Write("Enter number of project handles: ");
                        int devProjectHandles = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Enter number of extras: ");
                        int extras = Convert.ToInt32(Console.ReadLine());

                        salary = CalculateDeveloperSalary(workingHours, numberOfWorkingDays, devProjectHandles, extras);
                        break;

                    default:
                        Console.WriteLine("Invalid employee type");
                        break;
                }

                // Display the calculated salary
                Console.WriteLine($"Monthly salary: ${salary}");
            }

            static double CalculateHRSalary(int workingHours, int numberOfWorkingDays)
            {
                return workingHours * numberOfWorkingDays * 100;
            }

            static double CalculateAdminSalary(int workingHours, int numberOfWorkingDays, int projectHandles)
            {
                return workingHours * numberOfWorkingDays * 100 + projectHandles * 3000;
            }

            static double CalculateDeveloperSalary(int workingHours, int numberOfWorkingDays, int projectHandles, int extras)
            {
                return workingHours * numberOfWorkingDays * 100 + projectHandles * 3000 + extras * 2000;
            }
        

    }
}

