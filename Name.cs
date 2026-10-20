using System;

namespace Lab2
{
    internal class Name
    {
        private string _firstName;
        private string _lastName;
        private string _patronymic;
        
        public Name()
        {
            this._firstName = "Иван";
            this._lastName = "";
            this._patronymic = "";
        }
        
        public Name(string firstName)
        {
            this._firstName = firstName != null ? firstName : "";
            this._lastName = "";
            this._patronymic = "";
        }
        
        public Name(string firstName, string lastName)
        {
            this._firstName = firstName != null ? firstName : "";
            this._lastName = lastName != null ? lastName : "";
            this._patronymic = "";
        }
        
        public Name(string firstName, string lastName, string patronymic)
        {
            this._firstName = firstName != null ? firstName : "";
            this._lastName = lastName != null ? lastName : "";
            this._patronymic = patronymic != null ? patronymic : "";
        }

        public string FirstName
        {
            get { return _firstName; }
            set 
            {
                if (value != null)
                {
                    _firstName = value;
                }
                else
                {
                    _firstName = "";
                }
            }
        }

        public string LastName
        {
            get { return _lastName; }
            set 
            {
                if (value != null)
                {
                    _lastName = value;
                }
                else
                {
                    _lastName = "";
                }
            }
        }

        public string Patronymic
        {
            get { return _patronymic; }
            set 
            {
                if (value != null)
                {
                    _patronymic = value;
                }
                else
                {
                    _patronymic = "";
                }
            }
        }
        
        public override string ToString()
        {
            string s = "";

            if (_lastName != null && _lastName != "")
            {
                s = s + _lastName + " ";
            }
            if (_firstName != null && _firstName != "")
            {
                s = s + _firstName + " ";
            }
            if (_patronymic != null && _patronymic != "")
            {
                s = s + _patronymic + " ";
            }

            return s.Trim();
        }
    }
}
