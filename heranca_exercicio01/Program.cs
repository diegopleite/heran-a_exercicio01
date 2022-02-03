using heranca_exercicio01.Entities;
using System;
using System.Collections.Generic;

namespace heranca_exercicio01 {
    class Program {
        static void Main(string[] args) {
            Console.Write("Enter the number of Employees: ");
            int n = int.Parse(Console.ReadLine());
            char outsourced;
            List<Employee> listEmployee = new List<Employee>();
            for (int i = 1; i <= n; i++) {
                Console.WriteLine($"Employee #{i} data: ");
                Console.Write("Outsourced (y/n): ");
                outsourced = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.WriteLine("Value Per Hour: ");
                double vHour = double.Parse(Console.ReadLine());
                if (outsourced == 'n' || outsourced == 'N') {
                    Employee emp = new Employee(name, hours, vHour);
                    listEmployee.Add(emp);
                }
                else {
                    Console.WriteLine("Additional Charge: ");
                    double addCharge = double.Parse(Console.ReadLine());
                    OutsourcedEmployee outsourcedEmployee = new OutsourcedEmployee(name, hours, vHour, addCharge);
                    listEmployee.Add(outsourcedEmployee);
                }
            }
            Console.WriteLine("Payments: ");
            foreach (Employee employee in listEmployee) {
                Console.WriteLine(employee.ToString());
            }
        }
    }
}
