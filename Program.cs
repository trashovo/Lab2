using System;
using System.Collections.Generic;

namespace Lab2
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Checked input = new Checked();

            while (true)
            {
                Console.Clear();
                
                Console.WriteLine("1. Задание 1 (Имена, Время)");
                Console.WriteLine("2. Задание 2 (Сотрудники и отделы)");
                Console.WriteLine("3. Задание 3 (Сотрудники и отделы (список всех сотрудников этого отдела)");
                Console.WriteLine("4. Задание 4 (Создаем Время)");
                Console.WriteLine("5. Задание 5 (Сколько сейчас времени?)");
                Console.WriteLine("0. Выход");

                int taskgroup = input.ReadInt("Введите номер задания (от 0 до 5): ");
                while (taskgroup < 0 || taskgroup > 5)
                {
                    taskgroup = input.ReadInt("Ошибка, Введите номер задания от 0 до 5: ");
                }
                Console.WriteLine();
                
                if (taskgroup == 0)
                {
                    Console.WriteLine("Завершение работы программы.");
                    break;
                }

                switch (taskgroup)
                {
                    case 1:
                    {
                        Console.WriteLine("1. Задача 1.3: Имена");
                        Console.WriteLine("2. Задача 1.4: Время");

                        int choice = input.ReadInt("\nВыберите номер задачи (1 или 2): ");
                        while (choice < 1 || choice > 2)
                        {
                            choice = input.ReadInt("Ошибка, Введите номер задачи (1 или 2): ");
                        }

                        Console.WriteLine();

                        switch (choice)
                        {
                            case 1:
                            {
                                Console.WriteLine("Создание объектов Имени");
                                Name name1 = new Name("Клеопатра");
                                Name name2 = new Name("Александр", "Пушкин", "Сергеевич");
                                Name name3 = new Name("Владимир", "Маяковский");

                                Console.WriteLine("1: " + name1);
                                Console.WriteLine("2: " + name2);
                                Console.WriteLine("3: " + name3);

                                Console.WriteLine("\nВведите имя с клавиатуры:");
                                Console.Write("Введите личное имя (Enter, чтобы пропустить): ");
                                string firstName = Console.ReadLine();
                                Console.Write("Введите фамилию (Enter, чтобы пропустить): ");
                                string lastName = Console.ReadLine();
                                Console.Write("Введите отчество (Enter, чтобы пропустить): ");
                                string patronymic = Console.ReadLine();

                                Name userName;
                                if (firstName == "")
                                {
                                    userName = new Name();
                                }
                                else
                                {
                                    userName = new Name(firstName, lastName, patronymic);
                                }

                                Console.WriteLine("Результат: " + userName);
                                break;
                            }
                            case 2:
                            {
                                Console.WriteLine("Создание объектов Времени");
                                Time t1 = new Time(10);
                                Time t2 = new Time(10000);
                                Time t3 = new Time(100000);

                                Console.WriteLine("10 секунд:     " + t1);
                                Console.WriteLine("10000 секунд:  " + t2);
                                Console.WriteLine("100000 секунд: " + t3);

                                int totalSeconds = input.NewReadInt("\nВведите неотрицательное количество секунд: ");
                                Time userTime = new Time(totalSeconds);
                                Console.WriteLine("Результат (ЧЧ:ММ:СС): " + userTime);
                                break;
                            }
                        }
                        break;
                    }

                    case 2:
                    {
                        Console.WriteLine("Задание 2.4: Сотрудники и отделы");
                        Department it = new Department("IT");

                        Employee petrov = new Employee("Петров", it);
                        Employee kozlov = new Employee("Козлов", it);
                        Employee sidorov = new Employee("Сидоров", it);
                        
                        it.Manager = kozlov;

                        Console.WriteLine(petrov);
                        Console.WriteLine(kozlov);
                        Console.WriteLine(sidorov);
                        break;
                    }

                    case 3:
                    {
                        Console.WriteLine("Задание 3.4: Список сотрудников через ссылку на сотрудника");
                        Department it = new Department("IT");

                        Employee petrov = new Employee("Петров", it);
                        Employee kozlov = new Employee("Козлов", it);
                        Employee sidorov = new Employee("Сидоров", it);
                        
                        it.Manager = kozlov;

                        Console.WriteLine("Ссылка взята у сотрудника: " + petrov.Name);
                        Console.WriteLine("Список всех коллег его отдела:");

                        List<Employee> colleagues = petrov.GetDepartmentEmployees();
                        for (int i = 0; i < colleagues.Count; i++)
                        {
                            Console.WriteLine((i + 1) + ". " + colleagues[i].Name);
                        }
                        break;
                    }

                    case 4:
                    {
                        Console.WriteLine("Задание 4.4: Создаем Время");
                        Time tSec = new Time(10000);
                        Console.WriteLine("1) Через секунды (10000 сек): " + tSec);

                        Time tHms = new Time(2, 3, 5);
                        Console.WriteLine("2) Через ч/м/с (2 ч, 3 мин, 5 сек): " + tHms);

                        Console.WriteLine("\nВвод пользовательского времени:");
                        int hours = input.NewReadInt("Введите часы: ");

                        int minutes = input.ReadInt("Введите минуты: ");
                        while (minutes < 0 || minutes >= 60)
                        {
                            minutes = input.ReadInt("Ошибка, минуты должны быть от 0 до 59: ");
                        }

                        int seconds = input.ReadInt("Введите секунды: ");
                        while (seconds < 0 || seconds >= 60)
                        {
                            seconds = input.ReadInt("Ошибка, секунды должны быть от 0 до 59: ");
                        }

                        Time customTime = new Time(hours, minutes, seconds);
                        Console.WriteLine("Итоговое время: " + customTime);
                        break;
                    }

                    case 5:
                    {
                        Console.WriteLine("Задание 5.4: Сколько сейчас времени?");
                        Time t1 = new Time(34056);
                        Console.WriteLine("1. Время 34056 секунд  Часов: " + t1.GetHours());

                        Time t2 = new Time(4532);
                        Console.WriteLine("2. Время 4532 секунды  Минут: " + t2.GetMinutes());

                        Time t3 = new Time(123);
                        Console.WriteLine("3. Время 123 секунды  Секунд: " + t3.GetSeconds());

                        int totalSeconds = input.NewReadInt("\nВведите число секунд для проверки: ");
                        Time userCheck = new Time(totalSeconds);

                        Console.WriteLine("Время: " + userCheck);
                        Console.WriteLine("Часов: " + userCheck.GetHours());
                        Console.WriteLine("Минут: " + userCheck.GetMinutes());
                        Console.WriteLine("Секунд: " + userCheck.GetSeconds());
                        break;
                    }
                }

                Console.WriteLine("\nНажмите любую клавишу для возврата в меню");
                Console.ReadKey();
                Console.WriteLine();
            }
        }
    }
}