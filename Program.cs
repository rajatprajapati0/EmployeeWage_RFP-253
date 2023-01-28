using System;


namespace Employee_Wage
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            Console.WriteLine("Welcome to Employee Wage Computation");

            //Check Employee is Present or Absent-Use((RANDOM)) for AttendanceCheck
            Attendance();
       }
        static void Attendance()
        {
            int perHour_wage = 20;
            int fullDay_hour = 8;
           
            int wage = 0;
            Random rnd = new Random();
            int n = rnd.Next(0, 2);


            if (n == 0)
            {
                Console.WriteLine("Employee is Absent");
            }
            else
            {
                Console.WriteLine("Employee is Present");

                if (n==1)
                {
                    wage = fullDay_hour * perHour_wage;
                    Console.WriteLine("Employee is Present for h day his daily wage is :"+wage);
                }
                
            }
        }

    }
}
