using System.Collections.Generic;

namespace Lab2
{
    internal class Department
    {
        private string title;
        private Employee manager;
        private List<Employee> employees;

        public Department()
        {
            this.title = "Общий отдел";
            this.manager = null;
            this.employees = new List<Employee>();
        }

        public Department(string title)
        {
            this.title = title;
            this.manager = null;
            this.employees = new List<Employee>();
        }

        public Department(string title, Employee manager)
        {
            this.title = title;
            this.manager = manager;
            this.employees = new List<Employee>();
        }

        public string Title
        {
            get { return this.title; }
            set { this.title = value; }
        }

        public Employee Manager
        {
            get { return this.manager; }
            set { this.manager = value; }
        }
        
        
        public void AddEmployee(Employee employee)
        {
            if (employee != null && !this.employees.Contains(employee))
            {
                this.employees.Add(employee);
            }
        }
        
        public List<Employee> Employees
        {
            get { return this.employees; }
        }
        
        
        public override string ToString()
        {
            return this.title;
        }
    }
}