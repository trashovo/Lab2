using System;

namespace Lab2
{
    internal class Name
    {
        private string firstName;
        private string lastName;
        private string patronymic;
        
        public Name()
        {
            this.firstName = "Иван";
            this.lastName = "";
            this.patronymic = "";
        }
        
        public Name(string firstName)
        {
            this.firstName = firstName != null ? firstName : "";
            this.lastName = "";
            this.patronymic = "";
        }
        
        public Name(string firstName, string lastName)
        {
            this.firstName = firstName != null ? firstName : "";
            this.lastName = lastName != null ? lastName : "";
            this.patronymic = "";
        }
        
        public Name(string firstName, string lastName, string patronymic)
        {
            this.firstName = firstName != null ? firstName : "";
            this.lastName = lastName != null ? lastName : "";
            this.patronymic = patronymic != null ? patronymic : "";
        }
        
        public Name(Name other)
        {
            this.firstName = other.firstName;
            this.lastName = other.lastName;
            this.patronymic = other.patronymic;
        }

        public string FirstName
        {
            get { return this.firstName; }
            set 
            {
                if (value != null)
                {
                    this.firstName = value;
                }
                else
                {
                    this.firstName = "";
                }
            }
        }

        public string LastName
        {
            get { return this.lastName; }
            set 
            {
                if (value != null)
                {
                    this.lastName = value;
                }
                else
                {
                    this.lastName = "";
                }
            }
        }

        public string Patronymic
        {
            get { return this.patronymic; }
            set 
            {
                if (value != null)
                {
                    this.patronymic = value;
                }
                else
                {
                    this.patronymic = "";
                }
            }
        }
        
        public override string ToString()
        {
            string s = "";

            if (this.lastName != null && this.lastName != "")
            {
                s = s + this.lastName + " ";
            }
            if (this.firstName != null && this.firstName != "")
            {
                s = s + this.firstName + " ";
            }
            if (this.patronymic != null && this.patronymic != "")
            {
                s = s + this.patronymic + " ";
            }

            return s.Trim();
        }
    }
}