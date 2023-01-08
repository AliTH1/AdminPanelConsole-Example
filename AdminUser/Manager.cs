using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminUser
{
    internal class Manager: Employee
    {
        public Manager(int id, string name, string surname): base(id, name, surname) { }

        public void setGetARaise(int get_a_raise)
        {
            Console.WriteLine("Сотрудник " + getName() + " получил прибавки: " + get_a_raise);
        }
    }
}
