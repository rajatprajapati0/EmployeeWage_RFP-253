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
            int halfday = 0;
            int fullday = 0;
            int wage = 0;
            Random rnd = new Random();
            int monthlyWage = 0;
            int day = 0;
            int count = 0;
            int absent = 0;
            int totalhour = 0;
            while (day != 20 && count != 30 && totalhour!=100 )

            {
                int n = rnd.Next(0, 3);
                switch (n)

                {
                    case 0:
                        absent++;
                        count++;
                        break;

                    case 1:

                        wage = halfDay_hour * perHour_wage;
                        monthlyWage = wage + monthlyWage;
                        count++;
                        halfday++;
                        day++;
                        totalhour += halfDay_hour;
                        
                        break;
                    case 2:
                        wage = fullDay_hour * perHour_wage;
                        monthlyWage = wage + monthlyWage;
                        count++;
                        day++;
                        fullday++;
                        totalhour += fullDay_hour;

                        break;
                }
            }
            Console.WriteLine("monthly wage                  :" + monthlyWage);
            Console.WriteLine("prasent days                  :" + day);
            Console.WriteLine("total half day taken          :" + halfday);
            Console.WriteLine("total full day taken          :" + fullday);
            Console.WriteLine("total absent in a month       :" + absent);
            Console.WriteLine("total worked hour in a month  :" + totalhour);
            Console.ReadLine();
         

        }




    }
}
