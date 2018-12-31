using System;

namespace Employee_Data
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            int employeeId = int.Parse(Console.ReadLine());
            double salary = double.Parse(Console.ReadLine());

            Console.WriteLine($"Name: {name}\nAge: {age}\nEmployee ID: {employeeId:d8}\nMontly Salary: {salary:f2}");

        }
    }
}
