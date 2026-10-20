using System.Collections.Generic;

namespace Lab2
{
    internal class Department
    {
        private string _title;
        private Employee _manager;
        private List<Employee> _employees;

        public Department()
        {
            _title = "Общий отдел";
            _manager = null;
            _employees = new List<Employee>();
        }

        public Department(string title)
        {
            _title = title;
            _manager = null;
            _employees = new List<Employee>();
        }

        public Department(string title, Employee manager)
        {
            _title = title;
            _manager = manager;
            _employees = new List<Employee>();
        }

        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }

        public Employee Manager
        {
            get { return _manager; }
            set 
            {
                if (value != null && _employees.Contains(value))
                {
                _manager = value;
                }
                else
                {
                    Console.WriteLine("Ошибка, начальник должен быть сотрудником этого отдела");
                }
            }
        }
        
        public void AddEmployee(Employee employee)
        {
            if (employee != null && !_employees.Contains(employee))
            {
                _employees.Add(employee);
            }
        }
        
        public List<Employee> Employees
        {
            get { return _employees; }
        }
        
        public override string ToString()
        {
            return _title;
        }
    }
}
