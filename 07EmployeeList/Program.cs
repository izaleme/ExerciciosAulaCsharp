using System;
using System.Globalization;
using System.Collections.Generic;

namespace _07EmployeeList
{
    class Program
    {
        static void Main(string[] args)
        {
            int intIdEmployee = 0;
            string strNameEmployee = string.Empty;
            double doSalaryEmployee = 0.0;
            double doPercentage = 0.0;

            List<Employee> list = new List<Employee>();

            Console.WriteLine("++++ Cadastro de Funcionários ++++\n");
            
            Console.Write("How many employees will be registred? ");
            int intRecords = int.Parse(Console.ReadLine());

            for(int i = 1; i <= intRecords; i++)
            {
                ClearVar();

                //
                Console.WriteLine("\nEmployee #" + i);
                Console.Write("Id: ");
                intIdEmployee = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                strNameEmployee = Console.ReadLine();
                Console.Write("Salary: ");
                doSalaryEmployee = double.Parse(Console.ReadLine());

                // 
                Console.Write("\nEnter the employee id that will have salary increase: ");
                int searchId = int.Parse(Console.ReadLine());

                Employee emp = list.Find(x => x.Id == searchId);

                if (emp != null)
                {
                    Console.Write("Enter the percentage: ");
                    doPercentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    emp.IncreaseSalary(doPercentage);
                }
                else
                {
                    Console.WriteLine("This id does not exist!");
                }

                //
                Console.WriteLine("\nUpdated list of Employees:");
                foreach (Employee obj in list)
                    Console.WriteLine(obj);
            }

            void ClearVar()
            {
                intIdEmployee = 0;
                strNameEmployee = string.Empty;
                doSalaryEmployee = 0.0;
                doPercentage = 0.0;
            }
        }
    }
}
