using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul11
{
    public enum Vacancies
    {
        Manager,
        Developer,
        Designer
    }

    struct Employee
    {
        public string Name;
        public Vacancies Vacancy;
        public int[] EDate;
        public int Salary;
    }

    internal class Program1
    {
        static void Main(string[] args)
        {
            Employee employee;
            employee.Name = "Aigerim";
            employee.Vacancy = Vacancies.Developer;
            employee.EDate = new int[] { 2023, 08, 27 };
            employee.Salary = 200000;

            Console.WriteLine("Name: {employee.Name}");
            Console.WriteLine("Vacancy: {employee.Vacancy}");
            Console.WriteLine("Hire Date: {employee.EDate[0]}.{employee.EDate[1]}.{employee.EDate[2]}");
            Console.WriteLine("Salary: {employee.Salary}");
        }
    }
}
