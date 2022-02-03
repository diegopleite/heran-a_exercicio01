using System;
using System.Collections.Generic;
using System.Text;

namespace heranca_exercicio01.Entities {
    class Employee {

        public string Name { get; set; }
        public int Hours { get; set; }
        public double ValuePerHour { get; set; }
        public List<Employee> Employees { get; set; } = new List<Employee>();

        public Employee(string name, int hours, double valuePerHour) {
            Name = name;
            Hours = hours;
            ValuePerHour = valuePerHour;
        }

        public void addEmplyee(Employee employee) {
            Employees.Add(employee);
        }

        public void removeEmployee(Employee employee) {
            Employees.Remove(employee);
        }

        public virtual double payment() {
            return Hours * ValuePerHour;
        }
    }
}
