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
   
        public virtual double payment() {
            return Hours * ValuePerHour;
        }

        public override string ToString() {
            StringBuilder sb = new StringBuilder();
            sb.Append(Name);
            sb.Append(" - $");
            sb.Append(payment());
            return sb.ToString();
        }
    }
}
