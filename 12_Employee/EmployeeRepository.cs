using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _12_Employee
{
    public class EmployeeRepository
    {
        private long id = 0;
        private List<Employee> employees;

        public EmployeeRepository()
        {
            employees = new List<Employee>();
        }
        public void Clear()
        {
            employees.Clear();
        }

        public int CountEmployees()
        {
            return employees.Count();
        }

        public Employee CreateEmployee(string name, string position)
        {
            Employee emp = new Employee(name, position);
            emp.Id = NextId();
            employees.Add(emp);
            return emp;
        }

        private long NextId()
        {
            id++;
            return id;
        }

        public void SaveEmployee(Employee emp)
        {
            StreamWriter writer = new StreamWriter(NameBuilder(emp.Id));
            writer.WriteLine(emp.Name);
            writer.WriteLine(emp.Type);
            writer.WriteLine(emp.Id);
            writer.Close();
        }

        public Employee LoadEmployee(long id)
        {
            StreamReader reader = new StreamReader(NameBuilder(id));
            Employee emp = new Employee(reader.ReadLine(), reader.ReadLine());
            emp.Id = long.Parse(reader.ReadLine());
            reader.Close();
            return emp;
        }

        public List<Employee> FindAllEmployees()
        {
            return this.employees;
        }

        private string NameBuilder(long id)
        {
            return "emp" + id + ".txt";
        }

      
    }
}
