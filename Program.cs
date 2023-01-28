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
            int monthlyWage = 0;
            int day = 1;
            int count = 1;
            int absent = 1;
            while (day != 20 &&count!=30)

            {
                int n = rnd.Next(0, 3);
                switch (n)

                {
                    case 0: absent++;
                           count++;        
                        break;

                    case 1:
                        
                        wage = halfDay_hour * perHour_wage;
                        monthlyWage = wage + monthlyWage;
                        count++;
                        day++;
                        break;
                    case 2:
                        wage = fullDay_hour * perHour_wage;
                        monthlyWage = wage + monthlyWage;
                        count++;
                        day++;
                        break;

                }
                    
            }
            Console.WriteLine("monthly wage           :"+monthlyWage);
            Console.WriteLine("prasent days           :"+day);
            Console.WriteLine("total days in a month  :"+count);
            Console.WriteLine("total absent in a month:"+absent);
        }

    }
}
