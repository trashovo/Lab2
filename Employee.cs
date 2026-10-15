using System;
using System.Collections.Generic;

namespace Lab2
{
    internal class Employee
    {
        private string name;
        private Department department;

        public Employee()
        {
            this.name = "Иван";
            this.department = null;
        }

        public Employee(string name)
        {
            this.name = name;
            this.department = null;
        }

        public Employee(string name, Department department)
        {
            this.name = name;
            this.Department = department;
        }
        
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        
        public Department Department
        {
            get { return this.department; }
            set
            {
                this.department = value;
                if (this.department != null)
                {
                    this.department.AddEmployee(this);
                }
            }
        }
        public List<Employee> GetDepartmentEmployees()
        {
            if (this.department != null)
            {
                return this.department.Employees;
            }
            return new List<Employee>();
        }
        
        
        public override string ToString()
        {
            if (this.department == null)
            {
                return this.name + " без отдела";
            }

            if (this.department.Manager == this)
            {
                return this.name + " начальник отдела " + this.department.Title;
            }

            string bossName = this.department.Manager != null ? this.department.Manager.Name : "не назначен";
            return this.name + " работает в отделе " + this.department.Title + ", начальник которого " + bossName;
        }
    }
}
