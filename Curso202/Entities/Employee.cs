using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso202.Entities
{
    class Employee : IComparable
    {
        public string Name { get; set; }
        public double Salary { get; set; }

        public Employee(string csvEmployee)
        {
            string[] vect = csvEmployee.Split(','); // caractere em utf-16, vírgula.
            Name = vect[0];
            Salary = double.Parse(vect[1]);
        }

        public override string ToString()
        {
            return "Name: "
                + Name + ", "
                + "Salary: " + Salary.ToString("F2");
        }

        public int CompareTo(object? obj)
        {
            if (obj == null) return 0;
            Employee? other = obj as Employee;
            // Aqui estou usando o CompareTo da string.
            return Name.CompareTo(other.Name);
        }

        // Para o método Sort da lista comparar, tenho que ter o método IComparable.
        /* Se o objeto for menor, retorna -1, se for igual retorna 0, se for maior retorna 1.*/




    }
}
