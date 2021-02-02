using System;

namespace EmpWage
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage computation");
            int isPresent = 1;
            int empRatePerHr = 20;
            int empDailyHr = 8;
            Random randomNumber = new Random();
            int empCheck = randomNumber.Next(0, 2);
            Console.WriteLine(empCheck);
            if (empCheck == isPresent)
            {
                Console.WriteLine("present");
                int perDaySalary = empRatePerHr * empDailyHr;
                Console.WriteLine("Employee Per Day salary = " + perDaySalary);
            }
            else
                Console.WriteLine("absent");
        }
    }
}
