using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminUser
{
    internal class Employee
    {
        private int id;
        private string name, surname;

        public Employee(int _id, string _name, string _surname)
        {
            id = _id;
            name = _name;
            surname = _surname;
        }

        public int getId()
        {
            return id;
        }

        public string getName()
        {
            return name;
        }

        public string getSurname()
        {
            return surname;
        }
    }
}
