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
            

             
            switch (n) 
             
            {
                case 0:   Console.WriteLine("Employee is Absent " + wage);
                    break;

                case 1:
                         Console.WriteLine("Employee is Present");
                         wage = halfDay_hour * perHour_wage;
                         Console.WriteLine("Employee is Present for half day his daily wage is " + wage);
                    break;
                case 2:
                         wage = fullDay_hour * perHour_wage;
                         Console.WriteLine("Employee is Present for full day his daily wage is " + wage);
                    break;

            }
        }
    }
}
