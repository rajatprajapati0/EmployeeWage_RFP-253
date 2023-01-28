using System;
using System.Transactions;

namespace Employee_Wage
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            Console.WriteLine("Welcome to Employee Wage Computation");

            //Check Employee is Present or Absent-Use((RANDOM)) for AttendanceCheck
        
            Console.WriteLine("enter your name");
            string name = Console.ReadLine();

           

            Console.WriteLine(name);
            Attendance();


        }
        static void Attendance()
        {
            
            Random rnd = new Random();
            int n = rnd.Next(0, 2);

            if (n == 0)
            {
                Console.WriteLine(" Employee is Absent");
            }
            else
            {
                Console.WriteLine(" Employee is Present");
            }
        }
    }
}
