using System;
using System.Collections.Generic;
using System.Text;

namespace heranca_exercicio01.Entities {
    class OutsourcedEmployee : Employee {
        public double AdditionalCharge { get; set; }

        public OutsourcedEmployee(string name, int hours, double valuePerHour, double additionalCharge) : base(name, hours,valuePerHour) {
            AdditionalCharge = additionalCharge;
        }

        public override double payment() {
            double payment = ValuePerHour * Hours;
            double result;
            return result = payment + (payment * (AdditionalCharge/100));
        }
    }
}
