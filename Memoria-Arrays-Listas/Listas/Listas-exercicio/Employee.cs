using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_listas {
    internal class Employee {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }

        public Employee(int id, string name, double salary) {
            this.Name = name;
            this.Id = id;
            this.Salary = salary;
        }

        public void IncreaseSalary(double Percentage) {
            Salary += Salary * (Percentage / 100);
        }
        public override string ToString() {
            return Id
                + ", "
                + Name
                + ", "
                + Salary.ToString("F2");
        }
    }
}
