using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            double meal_cost = 100;
            int tip_percent = 15;
            int tax_percent = 8;
           
            double sum;
            sum = (meal_cost + tip_percent + tax_percent);

            Console.WriteLine("總餐費" + sum);

            */

            Console.WriteLine("請輸入值");
            int  x = int.Parse(Console.ReadLine());
            if (x % 2 != 0)
            {
                Console.WriteLine("weird");
            }
            else if (x % 2 == 0 &&  x > 2 && x < 5)
            {
                Console.WriteLine("Not weird");
            }
            else if (x % 2 == 0 && x > 6 && x < 20)
            {
                Console.WriteLine("weird");
            }
            else if (x % 2 == 0 && x > 20)
            {
                Console.WriteLine("Not weird");
            }

        }
    }
}
