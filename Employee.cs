using System;
using System.Collections.Generic;

namespace Lab2
{
    internal class Employee
    {
        private string _name;
        private Department _department;

        public Employee()
        {
            _name = "Иван";
            _department = null;
        }

        public Employee(string name)
        {
            _name = name;
            _department = null;
        }

        public Employee(string name, Department department)
        {
            _name = name;
            Department = department;
        }
        
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        
        public Department Department
        {
            get { return _department; }
            set
            {
                _department = value;
                if (_department != null)
                {
                    _department.AddEmployee(this);
                }
            }
        }

        public List<Employee> GetDepartmentEmployees()
        {
            if (_department != null)
            {
                return _department.Employees;
            }
            return new List<Employee>();
        }
        
        public override string ToString()
        {
            if (_department == null)
            {
                return _name + " без отдела";
            }

            if (_department.Manager == this)
            {
                return _name + " начальник отдела " + _department.Title;
            }

            string bossName = _department.Manager != null ? _department.Manager.Name : "не назначен";
            return _name + " работает в отделе " + _department.Title + ", начальник которого " + bossName;
        }
    }
}
