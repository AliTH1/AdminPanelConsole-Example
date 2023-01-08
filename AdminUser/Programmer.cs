using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminUser
{
    internal class Programmer : Employee
    {

        public Programmer(int id, string name, string surname) : base(id, name, surname) { }

        public void getOperatingSystem(string operating_system)
        {
            Console.WriteLine("Идет форматирование операционной системы: " + operating_system);
        }
    }
}
