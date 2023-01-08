using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminUser
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            while (true)
            {
                Console.WriteLine("Добро пожаловать. Под каким пользователем вы хотите войти?");
                Console.WriteLine("1 - Админ \n2 - Программист \nЧтобы выйти введите 'q'");
                string user_input = Console.ReadLine();
                if(user_input == "q")
                {
                    Console.Clear();
                    Console.Write("Программа завершилась.");
                    Console.ReadLine();
                    break;
                }

                else if(user_input == "1")
                {
                    Console.Clear();
                    Manager admin1 = new Manager(0, "Ali", "Taghizada");


                    while (true)
                    {
                        Console.WriteLine("Выберите операцию, которую хотите выполнить");
                        Console.WriteLine("1 - Сделать прибавки зарплатам \nЧтобы выйти введите 'q'");
                        string admin_input = Console.ReadLine();

                        if(admin_input == "1")
                        {
                            Console.Clear();
                            Console.WriteLine("Сколько хотите сделать прибавку сотрудникам?");
                            int admin_raise_input = Convert.ToInt32(Console.ReadLine());

                            admin1.setGetARaise(admin_raise_input);
                            Console.ReadLine();
                            Console.Clear();
                        }
                        else if(admin_input == "q")
                        {
                            Console.Clear();
                            Console.WriteLine("Выход из текущего сеанса.");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Введите корректные данные.");
                        }
                    }
                }

                else if(user_input == "2")
                {
                    Console.Clear();
                    Programmer programmer1 = new Programmer(0, "Ali", "Taghizada");


                    while (true)
                    {
                        Console.Clear();
                        Console.WriteLine("Выберите операцию, которую хотите выполнить");
                        Console.WriteLine("1 - Установить систему \nЧтобы выйти введите 'q'");
                        string programmer_input = Console.ReadLine();

                        if (programmer_input == "1")
                        {
                            Console.Clear();
                            Console.WriteLine("Введите название операционной системы, которую хотите установить: ");
                            string os_input = Console.ReadLine();
                            programmer1.getOperatingSystem(os_input);
                            Console.ReadLine();
                            Console.Clear();
                        }
                        else if (programmer_input == "q")
                        {
                            Console.Clear();
                            Console.WriteLine("Выход из текущего сеанса.");
                            break;
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Введите корректные данные.");
                        }
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Введите корректные данные.");
                }
            }

        }
    }
}
