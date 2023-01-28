using System;

namespace Employee_Wage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation");
            Attendance(); 
        }
        static void Attendance()
        {
            int perHour_wage = 20;
            int fullDay_hour = 8;
            int halfDay_hour = 4;
            int wage = 0;
            Random rnd = new Random();
            int n = rnd.Next(0, 3);


            if (n == 0)
            {
                Console.WriteLine("Employee is Absent");
            }
            else
            {
                Console.WriteLine("Employee is Present");

                if (n == 1)
                {
                    wage = halfDay_hour * perHour_wage;
                    Console.WriteLine("Employee is Present for half day his daily wage is " + wage);
                }
                else if (n == 2)

                {
                    wage = fullDay_hour * perHour_wage;
                    Console.WriteLine("Employee is Present for full day his daily wage is " + wage);
                }
            }
        }
    }
}