using System;

namespace EmpWage
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage computation");
            int isFullTime = 1;
            int isPartTime = 2;
            int empRatePerHr = 20;
            int empDailyHr = 0;
            int perDaySalary = 0;
            Random randomNumber = new Random();
            int empCheck = randomNumber.Next(0, 3);
            Console.WriteLine(empCheck);
			switch ((int)empCheck)
			{
				case 1:
					empDailyHr = 10;
					Console.WriteLine("Full time Employee");
					perDaySalary = empRatePerHr * empDailyHr;
					Console.WriteLine("Employee per day salary = " + perDaySalary);
					break;
				case 2:
					empDailyHr = 8;
					Console.WriteLine("Part time Employee");
					perDaySalary = empRatePerHr * empDailyHr;
					Console.WriteLine("Employee per day salary = " + perDaySalary);
					break;
				default:
					empDailyHr = 0;
					perDaySalary = 0;
					Console.WriteLine("Employee per day salary = " + perDaySalary);
					break;
			}//switch
		}
    }
}
